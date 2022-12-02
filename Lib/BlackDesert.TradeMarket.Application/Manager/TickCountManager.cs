using BlackDesert.TradeMarket.Application.Xml;
using EasMe;
using EasMe.Extensions;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class TickCountManager
    {
        private static volatile TickCountManager _singleton;
        private static object _locker = new object();
        private Dictionary<int, int> _tickCountList = new();
        private List<int> _mainGroupList = new();
        private bool _isOpen = false;
        private const string _managerName = nameof(TickCountManager);
        
        private static readonly EasLog logger = IEasLog.CreateLogger(_managerName);
        private TickCountManager() { }
        public static TickCountManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    _singleton ??= new TickCountManager();
                }
            }
            return _singleton;
        }

        public int Open(ServerType serverType)
        {
            var stopwatch = new Stopwatch();
            lock (_locker)
            {
                if (_isOpen)
                {
                    ServerLogManager.ServerLogWrite(ServerLogType.eAlready, _managerName);
                    return 0;
                }
                ServerLogManager.ServerLogWrite(ServerLogType.eStart,_managerName);
                stopwatch.Start();
                _tickCountList = Xml_ItemMarketTickCount.Read(serverType);
                _mainGroupList = _tickCountList.Select(x => x.Key).ToList();
                var tickCountList = ApiDbManger.uspListTickCount();

                if (_tickCountList.Count != tickCountList.Count)
                {
                    int count = _tickCountList.Count;
                    string str1 = count.ToString();
                    count = tickCountList.Count;
                    string str2 = count.ToString();
                    logger.Warn($"UpdateTick Count Fail Mismatch xmlCount({str1}) dbCount({str2})");
                    return -2;
                }
                var allowMainGroup = WorldMarketServerInfoManager.This().getAllowMainGroup();
                if (allowMainGroup == null)
                {
                    logger.Warn($"GetAllowMainGroup is null");
                    return -3;
                }
                foreach (var listTickCountResult in tickCountList)
                {
                    var info = listTickCountResult;
                    if (!allowMainGroup.Exists(x => x == info.MainGroupNo))
                        _mainGroupList.Remove(info.MainGroupNo);
                }
                if (_mainGroupList.Count == 0)
                {
                    logger.Warn($"MainGroupList is Empty");
                    return -5;
                }
                foreach (int mainGroup in _mainGroupList)
                    logger.Info($"MainGroup({mainGroup})");
                _isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.ServerLogWrite(ServerLogType.eComplete, stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public int UpdateTickCountToRepositoryXXX()
        {
            ServerLogManager.ServerLogWrite(ServerLogType.eStart, "TickCountManager updateTickCountToRepositoryXXX");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Dictionary<int, int> dictionary = new Dictionary<int, int>(_tickCountList);
            var tickCountList = ApiDbManger.uspListTickCount();
            if (_tickCountList.Count != tickCountList.Count)
            {
                int count = _tickCountList.Count;
                string str1 = count.ToString();
                count = tickCountList.Count;
                string str2 = count.ToString();
                logger.Error($"updateTickCountToRepositoryXXX Fail xmlCount : {str1}  DB Count : {str2} ");
                return -3;
            }
            foreach (var listTickCountResult in tickCountList)
            {
                int cMainGroupNo = listTickCountResult.MainGroupNo;
                if (_tickCountList.ContainsKey(cMainGroupNo) && listTickCountResult.UpdateTickCount == _tickCountList[cMainGroupNo])
                    dictionary.Remove(cMainGroupNo);
            }
            foreach (KeyValuePair<int, int> keyValuePair in dictionary)
            {
                int key = keyValuePair.Key;
                int num = keyValuePair.Value;
                var res = ApiDbManger.uspSetUpdateTickCount(key, num);
                if (!res.IsSuccess)
                    logger.Warn($"UpdateTickCountToRepository Fail MainGroupNo({key})");
            }
            stopwatch.Stop();
            ServerLogManager.ServerLogWrite(ServerLogType.eComplete, "TickCountManager updateTickCountToRepositoryXXX", stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public void updateTickCountXXX()
        {
            List<int> intList = new List<int>();
            foreach (int mainGroup in _mainGroupList)
            {
                try
                {
                    var res = ApiDbManger.uspIncreaseTickCount(mainGroup);
                    if (!res.IsSuccess)
                        logger.Warn("Db Error", $"updateTickCountXXX({mainGroup}), rv({res.resultCode})");
                    else if (Convert.ToBoolean(res.IsSuccess)) //TODO Check Here
                        intList.Add(mainGroup);
                }
                catch (Exception ex)
                {
                    logger.Exception(ex, "uspIncreaseTickCount");
                }
            }
            foreach (int mainGroupNo in intList)
                updatePriceWorldMarketXXX(mainGroupNo);
        }

        public void updatePriceWorldMarketXXX(int mainGroupNo)
        {
            long beforeEnchantPrice = 0;
            var list = ApiDbManger.uspListWorldMarketAccumulateTrade(mainGroupNo);
            //TODO Do logging
            GroupPriceChangerManager.This().clear();
            GroupWeaponPriceChangerManager.This().clear();
            foreach (var item in list)
            {
                TradeMarketItemInfo info = ItemInfoManager.This().getInfo(item.MainKey, item.SubKey);
                if (!info.isValid())
                {
                    beforeEnchantPrice = 0L;
                }
                else
                {
                    long passBiddingCount = 0;
                    long worldMarketPricePoint = 0;
                    VariedPriceInfoManager.This().getWorldMarketPassCount(item.PricePerOne, ref passBiddingCount, ref worldMarketPricePoint);
                    if (passBiddingCount == 0L || worldMarketPricePoint == 0L)
                    {
                        beforeEnchantPrice = 0L;
                        logger.Warn("getWorldMarketPassCount({0}, {1}),  Error pricePerOne {2} ", passBiddingCount, worldMarketPricePoint, item.PricePerOne);
                    }
                    else if (0L < item.PriceGroupKey)
                    {
                        GroupWeaponPriceChangerManager.This().add(item, info);
                        beforeEnchantPrice = 0L;
                    }
                    else
                    {
                        long cPricePerOne = item.PricePerOne;
                        bool flag = beforeEnchantPrice != 0L && beforeEnchantPrice < cPricePerOne;
                        if (item.SumTradeCount < info._tradeCountToUpdate && item.AccumulateTickCount < worldMarketPricePoint && item.AccumulateBiddingCount < passBiddingCount && !flag)
                        {
                            if (info.hasPriceGroup())
                            {
                                GroupPriceChangerManager.This().add(item, item.PricePerOne, item.PricePerOne);
                                TickCountCommon.enchantLevelCalc(cPricePerOne, item.SubKey, ref beforeEnchantPrice);
                            }
                            else
                            {
                                try
                                {
                                    var ratio = WorldMarketOptionManager.This().BiddingRatio;
                                    var res = ApiDbManger.uspUpdateWorldMarketPassCount(item.KeyType, item.MainKey, item.SubKey);
                                    if (!res.IsSuccess)
                                        logger.Warn($"uspUpdateWorldMarketPrice fail Record({item.AsJson()}) , Result({res.AsJson()})");
                                }
                                catch (Exception ex)
                                {
                                    logger.Exception(ex ,"uspUpdateWorldMarketPassCount");
                                }
                                TickCountCommon.enchantLevelCalc(cPricePerOne, item.SubKey, ref beforeEnchantPrice);
                            }
                        }
                        else
                        {
                            long num1 = (long)(cPricePerOne * (1.0 - WorldMarketOptionManager.This().BiddingRatio));
                            long num2 = (long)(cPricePerOne * (1.0 + WorldMarketOptionManager.This().BiddingRatio));
                            if (num1 < info._realMinPrice)
                                num1 = info._realMinPrice;
                            if (info._realMaxPrice < num2)
                                num2 = info._realMaxPrice;
                            long newPrice;
                            if (info._tradeCountToUpdate <= item.SumTradeCount)
                                newPrice = item.SumTradePrice / item.SumTradeCount;
                            else if (worldMarketPricePoint <= item.AccumulateTickCount || passBiddingCount <= item.AccumulateBiddingCount || flag)
                            {
                                if (item.SumTradeCount == 0L)
                                {
                                    int enchantMaxGroup = ItemInfoManager.This().getEnchantMaxGroup(item.MainKey, info._enchantGroup);
                                    var biddingPriceList = new BiddingPriceList();
                                    try
                                    {
                                        var ratio = WorldMarketOptionManager.This().BiddingRatio;
                                        //uspListBiddingPrice_Result
                                        var res = ApiDbManger.uspListBiddingPrice(item.KeyType, item.MainKey, item.SubKey, enchantMaxGroup, ratio, item.PricePerOne);
                                    }
                                    catch (Exception ex)
                                    {
                                        TickCountCommon.enchantLevelCalc(cPricePerOne, item.SubKey, ref beforeEnchantPrice);
                                        logger.Exception(ex,"uspListBiddingPrice ");
                                        continue;
                                    }
                                    if (biddingPriceList.list != null && 0 < biddingPriceList.list.Count)
                                    {
                                        long num3 = 0;
                                        long num4 = 0;
                                        foreach (uspListBiddingPrice_Result biddingPriceResult in biddingPriceList.list)
                                        {
                                            if (0L < num3 + biddingPriceResult.C_pricePerOne * biddingPriceResult.C_leftCount)
                                            {
                                                num3 += biddingPriceResult.C_pricePerOne * biddingPriceResult.C_leftCount;
                                                num4 += biddingPriceResult.C_leftCount;
                                            }
                                            else
                                                break;
                                        }
                                        newPrice = (long)(num3 / (double)num4);
                                    }
                                    else
                                        newPrice = item.PricePerOne;
                                }
                                else
                                    newPrice = (long)((double)item.SumTradePrice / (double)item.SumTradeCount);
                            }
                            else
                            {
                                TickCountCommon.enchantLevelCalc(cPricePerOne, item.SubKey, ref beforeEnchantPrice);
                                logger.Warn("newPrice fail keyType - {0}, mainKey - {1}, subKey - {2}".FormatString(item.KeyType, item.MainKey, item.SubKey));
                                continue;
                            }
                            long nextGraphPrice = newPrice;
                            if (num1 > newPrice || newPrice > num2)
                            {
                                if (newPrice < num1)
                                    newPrice = num1;
                                if (num2 < newPrice)
                                    newPrice = num2;
                            }
                            long price = VariedPriceInfoManager.This().calculatePrice(newPrice);
                            if (price == 0L)
                            {
                                TickCountCommon.enchantLevelCalc(cPricePerOne, item.SubKey, ref beforeEnchantPrice);
                                logger.Warn("calculatePrice fail keyType - {0}, mainKey - {1}, subKey - {2}, newPrice - {3}".FormatString(item.KeyType, item.MainKey, item.SubKey, price));
                            }
                            else
                            {
                                TickCountCommon.checkAndUpdateBeforePrice(beforeEnchantPrice, ref price);
                                if (info.hasPriceGroup())
                                {
                                    GroupPriceChangerManager.This().add(item, price, nextGraphPrice);
                                    TickCountCommon.enchantLevelCalc(cPricePerOne, item.SubKey, ref beforeEnchantPrice);
                                }
                                else
                                {
                                    FluctuationType fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Normal;
                                    long fluctuationPrice = 0;
                                    TickCountCommon.fluctuationCalc(price, cPricePerOne, ref fluctuationType, ref fluctuationPrice);
                                    try
                                    {
                                        var res = ApiDbManger.uspUpdateWorldMarketPrice(item.KeyType, item.MainKey, item.SubKey, price, nextGraphPrice, fluctuationType, fluctuationPrice);
                                        if (!res.IsSuccess)
                                        {
                                            logger.Warn("uspUpdateWorldMarketPrice fail keyType - {0}, mainKey - {1}, subKey - {2}, newPrice - {3}", item.KeyType, item.MainKey, item.SubKey, price);
                                            TickCountCommon.enchantLevelCalc(cPricePerOne, item.SubKey, ref beforeEnchantPrice);
                                        }
                                        else
                                            TickCountCommon.enchantLevelCalc(price, item.SubKey, ref beforeEnchantPrice);
                                    }
                                    catch (Exception ex)
                                    {
                                        logger.Exception(ex,"uspUpdateWorldMarketPrice");
                                        TickCountCommon.enchantLevelCalc(cPricePerOne, item.SubKey, ref beforeEnchantPrice);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            GroupPriceChangerManager.This().update();
            foreach (GroupPriceChanger changer in GroupPriceChangerManager.This().changerList)
            {
                if (changer.priceRatio != changer.nextPriceRatio)
                {
                    long cMaxTradeCount = changer._item.MaxTradeCount;
                    FluctuationType fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Normal;
                    long fluctuationPrice = 0;
                    TickCountCommon.fluctuationCalc(changer.nextPrice, changer.price, ref fluctuationType, ref fluctuationPrice);
                    try
                    {
                        var record = changer._item;
                        var res = ApiDbManger.uspUpdateWorldMarketPrice(record.KeyType, record.MainKey, record.SubKey, changer.nextPrice, changer.nextGraphPrice, fluctuationType, fluctuationPrice, cMaxTradeCount);
                        if (!res.IsSuccess)
                            logger.Warn("uspUpdateWorldMarketPrice fail keyType - {0}, mainKey - {1}, subKey - {2}, newPrice - {3}".FormatString(record.KeyType, record.MainKey, record.SubKey, changer.nextPrice));
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice Exception : {0}", ex.ToString()), "ERROR");
                    }
                }
                else
                {
                    try
                    {
                        var record = changer._item;
                        var res = ApiDbManger.uspUpdateWorldMarketPassCount(record.KeyType, record.MainKey, record.SubKey, WorldMarketOptionManager.This().BiddingRatio);
                        if (!res.IsSuccess)
                            logger.Warn("uspUpdateWorldMarketPrice fail keyType - {0}, mainKey - {1}, subKey - {2}".FormatString(record.KeyType, record.MainKey, record.SubKey));
                    }
                    catch (Exception ex)
                    {
                        logger.Exception(ex,"uspUpdateWorldMarketPassCount");
                    }
                }
            }
            GroupWeaponPriceChangerManager.This().update();
            logger.Info($"updatePriceWorldMarketXXX complete mainGroupNo:{mainGroupNo}");
        }

        public bool isExistsMainGroupNo(int mainGroupNo) => _tickCountList.ContainsKey(mainGroupNo);

        public List<int> getMainGroupListXXX() => _mainGroupList;

        public void updatePriceTargetXXX(bool isIncrease, int keyType, int mainKey, int subKey)
        {
            var pricePerOne = ApiDbManger.uspGetItemPrice(keyType, mainKey, subKey);
            if (pricePerOne == 0)
            {
                logger.Warn("DB Error", "updatePriceTargetXXX(), rv({0})", pricePerOne);
            }
            else
            {
                long int64 = Convert.ToInt64(pricePerOne);
                long price;
                FluctuationType fluctuationType;
                long num;
                if (isIncrease)
                {
                    long newPrice = (long)(int64 * (1.0 + WorldMarketOptionManager.This().BiddingRatio));
                    price = VariedPriceInfoManager.This().calculatePrice(newPrice);
                    fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Up;
                    num = price - int64;
                }
                else
                {
                    long newPrice = (long)(int64 * (1.0 - WorldMarketOptionManager.This().BiddingRatio));
                    price = VariedPriceInfoManager.This().calculatePrice(newPrice);
                    fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Down;
                    num = int64 - price;
                }
                var res = ApiDbManger.uspUpdateWorldMarketPrice(keyType, mainKey, subKey, price, fluctuationType, num);
                if (!res.IsSuccess)
                    logger.Warn($"updatePriceTargetXXX fail keyType - {keyType}, mainKey - {mainKey}, subKey - {subKey}, newPrice - {price}");
            }
        }
    }
}
