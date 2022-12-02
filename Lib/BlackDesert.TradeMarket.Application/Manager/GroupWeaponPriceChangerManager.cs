using BlackDesert.TradeMarket.Application.Xml;
using BlackDesert.TradeMarket.Db.TradeContext;
using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class GroupWeaponPriceChangerManager
    {
        private static object _locker = new object();
        private static volatile GroupWeaponPriceChangerManager _singleton;
        private Dictionary<long, GroupWeaponPriceList> _priceData;

        public static GroupWeaponPriceChangerManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new GroupWeaponPriceChangerManager();
                }
            }
            return _singleton;
        }

        private GroupWeaponPriceChangerManager() => clear();

        public void clear() => _priceData = new Dictionary<long, GroupWeaponPriceList>();

        public void add(TblWorldMarket item, TradeMarketItemInfo itemInfo)
        {
            if (!_priceData.ContainsKey(itemInfo._marketPriceGroup))
                _priceData.Add(itemInfo._marketPriceGroup, new GroupWeaponPriceList());
            _priceData[itemInfo._marketPriceGroup]._list.Add(new GroupWeaponPriceChanger(item, itemInfo));
        }

        public void update()
        {
            IOrderedEnumerable<long> orderedEnumerable = _priceData.Keys.ToList().OrderByDescending(key => key);
            long beforeEnchantPrice = 0;
            foreach (long key in (IEnumerable<long>)orderedEnumerable)
            {
                GroupWeaponPriceList groupWeaponPriceList = _priceData[key];
                groupWeaponPriceList.averageCurrentPrice();
                VariedPriceInfoManager.This().getWorldMarketPassCount(groupWeaponPriceList._currentPrice, ref groupWeaponPriceList._passBiddingCount, ref groupWeaponPriceList._worldMarketPricePoint);
                int enchantLevel = (int)key % 100;
                long currentPrice = groupWeaponPriceList._currentPrice;
                bool flag1 = beforeEnchantPrice != 0L && beforeEnchantPrice < currentPrice;
                int count1 = groupWeaponPriceList._list.Count;
                for (int index = 0; index < count1; ++index)
                {
                    GroupWeaponPriceChanger weaponPriceChanger = _priceData[key]._list[index];
                    if (weaponPriceChanger._record.C_sumTradeCount >= weaponPriceChanger._itemInfo._tradeCountToUpdate || weaponPriceChanger._record.C_accumulateTickCount >= groupWeaponPriceList._worldMarketPricePoint || weaponPriceChanger._record.C_accumulateBiddingCount >= groupWeaponPriceList._passBiddingCount || flag1)
                    {
                        groupWeaponPriceList._isChange = true;
                        break;
                    }
                }
                if (groupWeaponPriceList._isChange)
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    BiddingGroupPriceList biddingGroupPriceList = new BiddingGroupPriceList();
                    using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                    {
                        try
                        {
                            biddingGroupPriceList.list = ((IEnumerable<uspListGroupBiddingPrice_Result>)SA_BETA_TRADEDB_0002.uspListGroupBiddingPrice(new long?(key), new double?(WorldMarketOptionManager.This().BiddingRatio), new long?(groupWeaponPriceList._currentPrice), symNo, rv)).ToList();
                        }
                        catch (Exception ex)
                        {
                            TickCountCommon.enchantLevelCalc(currentPrice, enchantLevel, ref beforeEnchantPrice);
                            LogUtil.WriteLog("uspListGroupBiddingPrice error : " + ex.ToString(), "ERROR");
                            continue;
                        }
                    }
                    bool flag2 = false;
                    long num1 = 0;
                    long num2 = 0;
                    if (biddingGroupPriceList.list != null && 0 < biddingGroupPriceList.list.Count)
                    {
                        foreach (uspListGroupBiddingPrice_Result biddingPriceResult in biddingGroupPriceList.list)
                        {
                            if (0L <= num1 + biddingPriceResult.C_pricePerOne * biddingPriceResult.C_leftCount)
                            {
                                if (0L < biddingPriceResult.C_leftCount)
                                {
                                    num1 += biddingPriceResult.C_pricePerOne * biddingPriceResult.C_leftCount;
                                    num2 += biddingPriceResult.C_leftCount;
                                }
                            }
                            else
                            {
                                flag2 = true;
                                break;
                            }
                        }
                    }
                    int count2 = groupWeaponPriceList._list.Count;
                    if (!flag2 && 0 < count2)
                    {
                        for (int index = 0; index < count2; ++index)
                        {
                            GroupWeaponPriceChanger weaponPriceChanger = _priceData[key]._list[index];
                            if (0L <= num1 + weaponPriceChanger._record.C_sumTradePrice)
                            {
                                num1 += weaponPriceChanger._record.C_sumTradePrice;
                                num2 += weaponPriceChanger._record.C_sumTradeCount;
                            }
                            else
                                break;
                        }
                    }
                    long newPrice = (long)(num1 / (double)num2);
                    long num3 = newPrice;
                    if (num2 == 0L)
                        newPrice = currentPrice;
                    long num4 = (long)(groupWeaponPriceList._currentPrice * (1.0 - WorldMarketOptionManager.This().BiddingRatio));
                    long num5 = (long)(groupWeaponPriceList._currentPrice * (1.0 + WorldMarketOptionManager.This().BiddingRatio));
                    if (num4 < groupWeaponPriceList._list[0]._itemInfo._realMinPrice)
                        num4 = groupWeaponPriceList._list[0]._itemInfo._realMinPrice;
                    if (groupWeaponPriceList._list[0]._itemInfo._realMaxPrice < num5)
                        num5 = groupWeaponPriceList._list[0]._itemInfo._realMaxPrice;
                    if (num4 > newPrice || newPrice > num5)
                    {
                        if (newPrice < num4)
                            newPrice = num4;
                        if (num5 < newPrice)
                            newPrice = num5;
                    }
                    long price = VariedPriceInfoManager.This().calculatePrice(newPrice);
                    if (price == 0L)
                    {
                        TickCountCommon.enchantLevelCalc(currentPrice, enchantLevel, ref beforeEnchantPrice);
                    }
                    else
                    {
                        TickCountCommon.checkAndUpdateBeforePrice(beforeEnchantPrice, ref price);
                        if (num2 == 0L)
                            num3 = price;
                        FluctuationType fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Normal;
                        long fluctuationPrice = 0;
                        TickCountCommon.fluctuationCalc(price, groupWeaponPriceList._currentPrice, ref fluctuationType, ref fluctuationPrice);
                        using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                        {
                            try
                            {
                                SA_BETA_TRADEDB_0002.uspUpdateWorldMarketGroupPrice(new long?(key), new long?(price), new long?(num3), new byte?((byte)fluctuationType), new long?(fluctuationPrice), symNo, rv);
                                int int32 = Convert.ToInt32(rv.Value);
                                if (int32 != 0)
                                {
                                    LogUtil.WriteLog(string.Format("uspUpdateWorldMarketGroupPrice fail : {0} rv : {1}", key, int32), "WARN");
                                    TickCountCommon.enchantLevelCalc(currentPrice, enchantLevel, ref beforeEnchantPrice);
                                }
                                else
                                    TickCountCommon.enchantLevelCalc(price, enchantLevel, ref beforeEnchantPrice);
                            }
                            catch (Exception ex)
                            {
                                LogUtil.WriteLog("uspUpdateWorldMarketGroupPrice error : " + ex.ToString(), "ERROR");
                                TickCountCommon.enchantLevelCalc(currentPrice, enchantLevel, ref beforeEnchantPrice);
                            }
                        }
                    }
                }
                else
                {
                    _priceData[key]._list.ForEach((Action<GroupWeaponPriceChanger>)(weaponChanger =>
                    {
                        ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                        ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                        using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                        {
                            try
                            {
                                uspListWorldMarketAccumulateTrade_Result record = weaponChanger._record;
                                SA_BETA_TRADEDB_0002.uspUpdateWorldMarketPassCount(new int?(record.C_keyType), new int?(record.C_mainKey), new int?(record.C_subKey), new double?(WorldMarketOptionManager.This().BiddingRatio), symNo, rv);
                                int int32 = Convert.ToInt32(rv.Value);
                                if (int32 == 0)
                                    return;
                                LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice fail keyType - {0}, mainKey - {1}, subKey - {2}, rv - {3}", (object)record.C_keyType, (object)record.C_mainKey, (object)record.C_subKey, int32), "WARN");
                            }
                            catch (Exception ex)
                            {
                                LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPassCount Exception : {0}", ex.ToString()), "ERROR");
                            }
                        }
                    }));
                    TickCountCommon.enchantLevelCalc(currentPrice, enchantLevel, ref beforeEnchantPrice);
                }
            }
        }
    }
}
