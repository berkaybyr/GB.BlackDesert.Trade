using BlackDesert.TradeMarket.Application.Xml;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class TickCountManager
    {
        private static volatile TickCountManager _singleton;
        private static object _locker = new object();
        private Dictionary<int, int> _tickCountList;
        private List<int> _mainGroupList;
        private bool _isOpen;
        private const string _managerName = "TickCountManager";

        public TickCountManager()
        {
            _tickCountList = new Dictionary<int, int>();
            _mainGroupList = new List<int>();
            _isOpen = false;
        }

        public static TickCountManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new TickCountManager();
                }
            }
            return _singleton;
        }

        public int open(ServerType serverType)
        {
            Stopwatch stopwatch = new Stopwatch();
            lock (_locker)
            {
                if (_isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(TickCountManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(TickCountManager));
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
                    LogUtil.WriteLog(string.Format("TickCountManager UpdateTick Count Fail Mismatch xmlCount : {0}  DB Count : {1} ", str1, str2), "WARN");
                    return -2;
                }
                List<int> allowMainGroup = WorldMarketServerInfoManager.This().getAllowMainGroup();
                if (allowMainGroup == null)
                {
                    LogUtil.WriteLog(string.Format("[Http Info]TickCountManager getAllowMainGroup is Empty"), "WARN");
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
                    LogUtil.WriteLog(string.Format("[Http Info]TickCountManager _mainGroupList is  Empty"), "WARN");
                    return -5;
                }
                foreach (int mainGroup in _mainGroupList)
                    LogUtil.WriteLog(string.Format("[Http Info]TickCountManager Init GroupNo : {0} ", mainGroup.ToString()), "INFO");
                _isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(TickCountManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public int updateTickCountToRepositoryXXX()
        {
            ServerLogManager.serverLogWrite(ServerLogType.eStart, "TickCountManager updateTickCountToRepositoryXXX");
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
                LogUtil.WriteLog(string.Format("updateTickCountToRepositoryXXX Fail xmlCount : {0}  DB Count : {1} ", str1, str2), "WARN");
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
                //TODO: Do logging ??
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, "TickCountManager updateTickCountToRepositoryXXX", stopwatch.ElapsedMilliseconds.ToString());
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
                    if (res.IsSuccess)
                        LogUtil.WriteLog(string.Format("[DB Error] uspIncreaseTickCount({0}), rv({1})", mainGroup, res.resultCode), "WARN");
                    else if (Convert.ToBoolean(res.IsSuccess)) //TODO Check Here
                        intList.Add(mainGroup);
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("uspIncreaseTickCount Exception : {0}", ex.ToString()), "ERROR");
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
                        LogUtil.WriteLog(string.Format("getWorldMarketPassCount({0}, {1}),  Error pricePerOne {2} ", passBiddingCount, worldMarketPricePoint, item.PricePerOne), "WARN");
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
                                    var res = ApiDbManger.uspUpdateWorldMarketPassCount(item.KeyType,item.MainKey, item.SubKey);
                                    if (!res.IsSuccess)
                                        LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice fail Record({0}) , Result({1})", JsonConvert.SerializeObject(item), JsonConvert.SerializeObject(res)), "WARN");
                                }
                                catch (Exception ex)
                                {
                                    LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPassCount Exception : {0}", ex.ToString()), "ERROR");
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
                                        var res = ApiDbManger.uspListBiddingPrice(item.KeyType,item.MainKey,item.SubKey, enchantMaxGroup, ratio, item.PricePerOne);
                                    }
                                    catch (Exception ex)
                                    {
                                        TickCountCommon.enchantLevelCalc(cPricePerOne, item.SubKey, ref beforeEnchantPrice);
                                        LogUtil.WriteLog(string.Format("uspListBiddingPrice Exception : {0}", ex.ToString()), "ERROR");
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
                                LogUtil.WriteLog(string.Format("newPrice fail keyType - {0}, mainKey - {1}, subKey - {2}", item.KeyType, item.MainKey, item.SubKey), "WARN");
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
                                LogUtil.WriteLog(string.Format("calculatePrice fail keyType - {0}, mainKey - {1}, subKey - {2}, newPrice - {3}", item.KeyType, item.MainKey, item.SubKey, price), "WARN");
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
                                        var res =  ApiDbManger.uspUpdateWorldMarketPrice(item.KeyType, item.MainKey, item.SubKey, price, nextGraphPrice, fluctuationType, fluctuationPrice);
                                        if (!res.IsSuccess)
                                        {
                                            LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice fail keyType - {0}, mainKey - {1}, subKey - {2}, newPrice - {3}", item.KeyType, item.MainKey, item.SubKey, price), "WARN");
                                            TickCountCommon.enchantLevelCalc(cPricePerOne, item.SubKey, ref beforeEnchantPrice);
                                        }
                                        else
                                            TickCountCommon.enchantLevelCalc(price, item.SubKey, ref beforeEnchantPrice);
                                    }
                                    catch (Exception ex)
                                    {
                                        LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice Exception : {0}", ex.ToString()), "ERROR");
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
                            LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice fail keyType - {0}, mainKey - {1}, subKey - {2}, newPrice - {3}", record.KeyType, record.MainKey, record.SubKey, changer.nextPrice), "WARN");
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
                            LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice fail keyType - {0}, mainKey - {1}, subKey - {2}", record.KeyType, record.MainKey, record.SubKey), "WARN");
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPassCount Exception : {0}", ex.ToString()), "ERROR");
                    }
                }
            }
            GroupWeaponPriceChangerManager.This().update();
            LogUtil.WriteLog(string.Format("updatePriceWorldMarketXXX complete mainGroupNo:{0},  ", mainGroupNo), "INFO");
        }

        public bool isExistsMainGroupNo(int mainGroupNo) => _tickCountList.ContainsKey(mainGroupNo);

        public List<int> getMainGroupListXXX() => _mainGroupList;

        public void updatePriceTargetXXX(bool isIncrease, int keyType, int mainKey, int subKey)
        {
            var pricePerOne = ApiDbManger.uspGetItemPrice(keyType, mainKey, subKey);
            if (pricePerOne == 0)
            {
                LogUtil.WriteLog(string.Format("[DB Error] updatePriceTargetXXX(), rv({0})", pricePerOne), "WARN");
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
                    LogUtil.WriteLog(string.Format("updatePriceTargetXXX fail keyType - {0}, mainKey - {1}, subKey - {2}, newPrice - {3}", keyType, mainKey, subKey, price), "WARN");
            }
        }
    }
}
