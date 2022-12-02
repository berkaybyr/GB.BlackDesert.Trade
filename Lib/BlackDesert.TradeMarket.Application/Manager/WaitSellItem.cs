using BlackDesert.TradeMarket.Application.Xml;
using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class WaitSellItem
    {
        private static object _locker = new object();
        private static bool _flag = false;

        public static void Excute(object state)
        {
            lock (_locker)
            {
                if (_flag)
                    return;
                _flag = true;
            }
            try
            {
                waitSellItem();
                ServerLogManager.ServerLogWrite(ServerLogType.eRunTimer, string.Format("[{0}]waitSellItem", state));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[{0}]waitSellItem Exception={1}", state, ex.ToString()), "ERROR");
            }
            lock (_locker)
                _flag = false;
        }

        private static void waitSellItem()
        {
            CommonDBResult<uspListWaitBiddingSell_Result> commonDbResult = new CommonDBResult<uspListWaitBiddingSell_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            if (!ServerControlManager.This().IsLoadComplete())
                LogUtil.WriteLog(string.Format("waitSellItem Fail is Not Open"), "WARN");
            else if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog(string.Format("waitSellItem log DB Exception"), "WARN");
            }
            else
            {
                try
                {
                    using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                        commonDbResult.list = ((IEnumerable<uspListWaitBiddingSell_Result>)SA_BETA_TRADEDB_0002.uspListWaitBiddingSell(symNo, rv)).ToList();
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog("[DB Error]waitSellItem - uspListWaitBiddingSell () errorMsg : " + ex.ToString(), "ERROR");
                    return;
                }
                commonDbResult.list.ForEach((Action<uspListWaitBiddingSell_Result>)(waitItem =>
                {
                    int num1 = 0;
                    waitItemModel model = new waitItemModel(waitItem);
                    rv = new ObjectParameter("rv", typeof(int));
                    symNo = new ObjectParameter("symNo", typeof(string));
                    ObjectParameter walletMoney = new ObjectParameter("walletMoney", typeof(long));
                    ObjectParameter realSellCount = new ObjectParameter("realSellCount", typeof(long));
                    ObjectParameter totalMoneyCount = new ObjectParameter("totalMoneyCount", typeof(long));
                    ObjectParameter originalTotalMoneyCount = new ObjectParameter("originalTotalMoneyCount", typeof(long));
                    ObjectParameter sellPricePerOne = new ObjectParameter("sellPricePerOne", typeof(long));
                    ObjectParameter packageExpiration = new ObjectParameter("packageExpiration", typeof(DateTime));
                    ObjectParameter sellNo = new ObjectParameter("sellNo", typeof(long));
                    ObjectParameter buyUserNo = new ObjectParameter("buyUserNo", typeof(long));
                    ObjectParameter buyUserId = new ObjectParameter("buyUserId", typeof(string));
                    ObjectParameter buyLeftCount = new ObjectParameter("buyLeftCount", typeof(long));
                    ObjectParameter buyNo = new ObjectParameter("buyNo", typeof(long));
                    ObjectParameter stopType = new ObjectParameter("stopType", typeof(int));
                    ObjectParameter isNextApplyRingBuff = new ObjectParameter("isNextApplyRingBuff", typeof(bool));
                    ObjectParameter resultWaitNo = new ObjectParameter("resultWaitNo", typeof(long));
                    ObjectParameter raceCount = new ObjectParameter("raceCount", typeof(long));
                    ObjectParameter beforeCount1 = new ObjectParameter("beforeCount1", typeof(long));
                    ObjectParameter beforeCount2 = new ObjectParameter("beforeCount2", typeof(long));
                    ObjectParameter beforeCount3 = new ObjectParameter("beforeCount3", typeof(long));
                    ObjectParameter beforeCount4 = new ObjectParameter("beforeCount4", typeof(long));
                    ObjectParameter afterCount1 = new ObjectParameter("afterCount1", typeof(long));
                    ObjectParameter afterCount2 = new ObjectParameter("afterCount2", typeof(long));
                    ObjectParameter afterCount3 = new ObjectParameter("afterCount3", typeof(long));
                    ObjectParameter afterCount4 = new ObjectParameter("afterCount4", typeof(long));
                    ObjectParameter soldCount = new ObjectParameter("soldCount", typeof(long));
                    ObjectParameter leftCount = new ObjectParameter("leftCount", typeof(long));
                    ObjectParameter moneyCount = new ObjectParameter("moneyCount", typeof(long));
                    ObjectParameter calculateMoney = new ObjectParameter("calculateMoney", typeof(long));
                    ObjectParameter isCalculateRingBuff = new ObjectParameter("isCalculateRingBuff", typeof(bool));
                    byte num2 = 2;
                    if (model.waitNo <= 0L)
                    {
                        LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) waitNo invaild{1}", model.toString(), model.waitNo), "WARN");
                    }
                    else
                    {
                        long unitPrice = VariedPriceInfoManager.This().getUnitPrice(model.sellPrice);
                        long num3 = model.sellPrice % unitPrice;
                        if (num3 != 0L)
                        {
                            LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) sellPrice Check Fail unitPrice({1} divide Result {2}", model.toString(), unitPrice, num3), "WARN");
                        }
                        else
                        {
                            TradeMarketItemInfo info1 = ItemInfoManager.This().getInfo(model.sellMainKey, model.sellChooseKey);
                            if (!info1.isValid())
                            {
                                LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) itemInfo({1}, {2}) Not Exist ItemInfo", model.toString(), model.sellMainKey, model.sellChooseKey), "WARN");
                            }
                            else
                            {
                                long num4 = info1._maxRegisterForWorldMarket * 10L;
                                if (ConstantMgr._serviceProject.Equals("BDO") && info1._mainGroupNo == WorldMarketOptionManager.This().getCashGroupNo())
                                    num4 = 100L;
                                if (num4 < model.sellCount)
                                {
                                    LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) sellCount({1}) Process Count Over", model.toString(), model.sellCount), "WARN");
                                }
                                else
                                {
                                    TradeMarketItemInfo tradeMarketItemInfo = new TradeMarketItemInfo();
                                    if (info1._enchantMaterialKey != 0)
                                    {
                                        tradeMarketItemInfo = ItemInfoManager.This().getInfo(info1._enchantMaterialKey, 0);
                                        if (!info1.isValid())
                                        {
                                            LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) itemInfo({1}, 0) Not Exist Material ItemInfo", model.toString(), info1._enchantMaterialKey), "WARN");
                                            return;
                                        }
                                    }
                                    int enchantMaxGroup1 = ItemInfoManager.This().getEnchantMaxGroup(model.sellMainKey, info1._enchantGroup);
                                    if (info1._enchantGroup > model.sellChooseKey || model.sellChooseKey > enchantMaxGroup1)
                                    {
                                        LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) getEnchantMaxGroup({1}, {2}) Group : Out Of Range", model.toString(), model.sellMainKey, info1._enchantGroup), "WARN");
                                    }
                                    else
                                    {
                                        if (model.sellSubKey != model.sellChooseKey)
                                        {
                                            TradeMarketItemInfo info2 = ItemInfoManager.This().getInfo(model.sellMainKey, model.sellSubKey);
                                            if (!info2.isValid())
                                            {
                                                LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) baseitemInfo({1}, {2}) Not Exist ItemInfo", model.toString(), model.sellMainKey, model.sellSubKey), "WARN");
                                                return;
                                            }
                                            int enchantMaxGroup2 = ItemInfoManager.This().getEnchantMaxGroup(model.sellMainKey, info2._enchantGroup);
                                            if (info2._enchantGroup > model.sellChooseKey || model.sellChooseKey > enchantMaxGroup2)
                                            {
                                                LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) getEnchantBaseMaxGroup({1}, {2}) Group : Out Of Range", model.toString(), model.sellMainKey, info2._enchantGroup), "WARN");
                                                return;
                                            }
                                        }
                                        CommonModel.TradeMarketUserLogInfo userInfo = new CommonModel.TradeMarketUserLogInfo();
                                        userInfo.nationCode = model.nationCode;
                                        userInfo.serverNo = model.worldNo;
                                        userInfo.userNo = model.userNo;
                                        CommonModel.TradeMarketItemLogInfo itemInfo = new CommonModel.TradeMarketItemLogInfo();
                                        itemInfo.keyType1 = model.sellKeyType;
                                        itemInfo.itemKey1 = model.sellMainKey;
                                        itemInfo.enchantLevel1 = model.sellSubKey;
                                        itemInfo.keyType2 = 0;
                                        itemInfo.itemKey2 = 1;
                                        itemInfo.enchantLevel2 = 0;
                                        DateTime customTime = CommonModule.GetCustomTime();
                                        List<string> buyUserIdList = new List<string>();
                                        using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                                        {
                                            try
                                            {
                                                ObjectParameter blocked = new ObjectParameter("blocked", typeof(bool));
                                                SA_BETA_TRADEDB_0002.uspCheckAndUpdateBlackUser(new int?(model.nationCode), new int?(model.worldNo), new long?(model.userNo), blocked, symNo, rv);
                                                if (Convert.ToBoolean(blocked.Value))
                                                {
                                                    LogUtil.WriteLog("[DB Exception]waitSellItem() - uspCheckAndUpdateBlackUser(" + model.toString() + ") Exception ", "WARN");
                                                    TradeModule.updateWaitFail(model, info1._weight, customTime);
                                                    return;
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                LogUtil.WriteLog("[DB Exception]waitSellItem() - uspCheckAndUpdateBlackUser(" + model.toString() + ") Exception : " + ex.ToString(), "ERROR");
                                                TradeModule.updateWaitFail(model, info1._weight, customTime);
                                                return;
                                            }
                                            long sellCount = model.sellCount;
                                            long num5 = 0;
                                            long num6 = 0;
                                            int num7 = 0;
                                            bool flag = false;
                                            if (ConstantMgr._serviceProject.Equals("BDO") && info1._mainGroupNo == WorldMarketOptionManager.This().getCashGroupNo())
                                                flag = true;
                                            if (ConstantMgr._serviceProject.Equals("BDO") && model.isRingBuff && info1._mainGroupNo != WorldMarketOptionManager.This().getCashGroupNo())
                                                num2 = 1;
                                            int num8 = 0;
                                            while (0L < sellCount)
                                            {
                                                try
                                                {
                                                    SA_BETA_TRADEDB_0002.uspSellBiddingToWorldMarket(new int?(model.nationCode), new int?(model.worldNo), new long?(model.userNo), new int?(model.sellKeyType), new int?(model.sellMainKey), new int?(model.sellSubKey), new int?(info1._mainGroupNo), new bool?(model.isSealed), new long?(model.sellPrice), new long?(sellCount), new int?(model.sellChooseKey), new int?(tradeMarketItemInfo._mainKey), new long?(info1._enchantNeedCount), new double?(WorldMarketOptionManager.This().BiddingRatio), new bool?(flag), new long?(info1._weight), new long?(WorldMarketOptionManager.This().getMaxWeight() * WorldMarketOptionManager.This().getMaxWeightRate()), new long?(WorldMarketOptionManager.This().getPearlItemLimitedMaxCount()), new DateTime?(customTime), new byte?(num2), new long?(model.waitNo), new bool?(model.isRingBuff), new long?(0L), walletMoney, realSellCount, totalMoneyCount, originalTotalMoneyCount, packageExpiration, buyNo, buyUserNo, buyUserId, buyLeftCount, stopType, isNextApplyRingBuff, resultWaitNo, raceCount, beforeCount1, afterCount1, beforeCount2, afterCount2, beforeCount3, afterCount3, beforeCount4, afterCount4, soldCount, leftCount, moneyCount, calculateMoney, isCalculateRingBuff, symNo, rv);
                                                    int int32_1 = Convert.ToInt32(rv.Value);
                                                    StopReasonType int32_2 = (StopReasonType)Convert.ToInt32(stopType.Value);
                                                    if (int32_1 == 0)
                                                    {
                                                        if (StopReasonType.eStopReasonType_Empty != int32_2)
                                                        {
                                                            if (StopReasonType.eStopReasonType_Fail == int32_2)
                                                            {
                                                                if (5 == num7)
                                                                {
                                                                    LogUtil.WriteLog(string.Format("[DB Error]waitSellItem - uspSellBiddingToWorldMarket({0}/{1}) Fail BuyBidding", model.toString(), sellCount), "WARN");
                                                                    TradeModule.updateWaitFail(model, info1._weight, customTime);
                                                                    return;
                                                                }
                                                                ++num7;
                                                            }
                                                            else if (int32_2 == StopReasonType.eStopReasonType_Normal)
                                                            {
                                                                long int64_1 = Convert.ToInt64(realSellCount.Value);
                                                                long int64_2 = Convert.ToInt64(totalMoneyCount.Value);
                                                                long int64_3 = Convert.ToInt64(originalTotalMoneyCount.Value);
                                                                long int64_4 = Convert.ToInt64(buyNo.Value);
                                                                Convert.ToInt64(walletMoney.Value);
                                                                if (num8 == 0 && Convert.ToBoolean(isNextApplyRingBuff.Value))
                                                                    num2 = 1;
                                                                ++num8;
                                                                sellCount -= int64_1;
                                                                num5 += int64_1;
                                                                num6 += int64_2;
                                                                itemInfo.count1 = int64_1;
                                                                itemInfo.beforeCount1 = Convert.ToInt64(beforeCount3.Value);
                                                                itemInfo.afterCount1 = Convert.ToInt64(afterCount3.Value);
                                                                itemInfo.count2 = int64_2;
                                                                itemInfo.beforeCount2 = Convert.ToInt64(beforeCount4.Value);
                                                                itemInfo.afterCount2 = Convert.ToInt64(afterCount4.Value);
                                                                WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_SellBidding, customTime, userInfo, itemInfo, int64_4, (long)model.sellChooseKey, Convert.ToInt64(model.isSealed), int64_3, 2L, Convert.ToInt64(num2), model.waitNo, Convert.ToInt64(buyUserNo.Value), Convert.ToInt64(raceCount.Value), Convert.ToInt64(model.isRingBuff), textParam1: packageExpiration.Value.ToString());
                                                                if (Convert.ToInt64(buyLeftCount.Value) == 0L)
                                                                {
                                                                    string str = buyUserId.Value.ToString();
                                                                    if (!buyUserIdList.Contains(str))
                                                                        buyUserIdList.Add(str);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                LogUtil.WriteLog(string.Format("[DB Error]waitSellItem - uspSellBiddingToWorldMarket({0}/{1}) StopReasonType({2}) is Invalid", model.toString(), sellCount, (int)int32_2), "WARN");
                                                                TradeModule.updateWaitFail(model, info1._weight, customTime);
                                                                return;
                                                            }
                                                        }
                                                        else
                                                            break;
                                                    }
                                                    else
                                                    {
                                                        LogUtil.WriteLog(string.Format("[DB Error]waitSellItem - uspSellBiddingToWorldMarket({0}/{1}), rv({2})", model.toString(), sellCount, int32_1), "WARN");
                                                        TradeModule.updateWaitFail(model, info1._weight, customTime);
                                                        return;
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    LogUtil.WriteLog(string.Format("[DB Exception]waitSellItem() - uspSellBiddingToWorldMarket({0}/{1}) Exception : {2}", model.toString(), sellCount, ex.ToString()), "ERROR");
                                                    TradeModule.updateWaitFail(model, info1._weight, customTime);
                                                    return;
                                                }
                                            }
                                            if (sellCount == 0L)
                                            {
                                                Task.Run(() => TradeModule.SendPearlAppAlarm(ref buyUserIdList, model.sellMainKey, "BUY"));
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    ObjectParameter isAppledRingBuff = new ObjectParameter("isAppledRingBuff", typeof(bool));
                                                    SA_BETA_TRADEDB_0002.uspSellToWorldMarket(new int?(model.nationCode), new int?(model.worldNo), new long?(model.userNo), new int?(model.sellKeyType), new int?(model.sellMainKey), new int?(model.sellSubKey), new int?(info1._mainGroupNo), new bool?(model.isSealed), new long?(model.sellPrice), new long?(sellCount), new int?(model.sellChooseKey), new int?(tradeMarketItemInfo._mainKey), new long?(info1._enchantNeedCount), new double?(WorldMarketOptionManager.This().BiddingRatio), new bool?(flag), new long?(info1._weight), new long?(WorldMarketOptionManager.This().getPearlItemLimitedMaxCount()), new DateTime?(customTime), new byte?(num2), new long?(model.waitNo), sellPricePerOne, realSellCount, totalMoneyCount, originalTotalMoneyCount, packageExpiration, sellNo, isAppledRingBuff, beforeCount1, afterCount1, beforeCount2, afterCount2, symNo, rv);
                                                    int int32 = Convert.ToInt32(rv.Value);
                                                    if (int32 == 0)
                                                    {
                                                        long int64_5 = Convert.ToInt64(realSellCount.Value);
                                                        long int64_6 = Convert.ToInt64(totalMoneyCount.Value);
                                                        long int64_7 = Convert.ToInt64(originalTotalMoneyCount.Value);
                                                        long int64_8 = Convert.ToInt64(sellNo.Value);
                                                        Convert.ToInt64(sellPricePerOne.Value);
                                                        long num9 = num5 + int64_5;
                                                        long num10 = num6 + int64_6;
                                                        if (num9 == 0L && int64_8 == 0L)
                                                        {
                                                            LogUtil.WriteLog("[Item Error]waitSellItem(" + model.toString() + ") ReserveBiddingFail", "WARN");
                                                            TradeModule.updateWaitFail(model, info1._weight, customTime);
                                                        }
                                                        else
                                                        {
                                                            if (0L < int64_5)
                                                            {
                                                                itemInfo.count1 = int64_5;
                                                                itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1.Value);
                                                                itemInfo.afterCount1 = Convert.ToInt64(afterCount1.Value);
                                                                itemInfo.count2 = int64_6;
                                                                itemInfo.beforeCount2 = Convert.ToInt64(beforeCount2.Value);
                                                                itemInfo.afterCount2 = Convert.ToInt64(afterCount2.Value);
                                                                WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_Sell, customTime, userInfo, itemInfo, (long)model.sellChooseKey, Convert.ToInt64(model.isSealed), int64_7, 2L, Convert.ToInt64(model.isRingBuff), Convert.ToInt64(num2), model.waitNo, textParam1: packageExpiration.Value.ToString());
                                                            }
                                                            if (0L >= int64_8)
                                                                return;
                                                            itemInfo.keyType1 = model.sellKeyType;
                                                            itemInfo.itemKey1 = model.sellMainKey;
                                                            itemInfo.enchantLevel1 = model.sellSubKey;
                                                            itemInfo.count1 = sellCount - int64_5;
                                                            itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1.Value);
                                                            itemInfo.afterCount1 = Convert.ToInt64(afterCount1.Value);
                                                            itemInfo.keyType2 = 0;
                                                            itemInfo.itemKey2 = 0;
                                                            itemInfo.enchantLevel2 = 0;
                                                            itemInfo.count2 = 0L;
                                                            itemInfo.beforeCount2 = 0L;
                                                            itemInfo.afterCount2 = 0L;
                                                            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingSellRegister, customTime, userInfo, itemInfo, int64_8, (long)model.sellChooseKey, Convert.ToInt64(model.isSealed), model.sellPrice, 2L, model.waitNo, textParam1: packageExpiration.Value.ToString());
                                                        }
                                                    }
                                                    else if (0L < num5)
                                                    {
                                                        Convert.ToInt64(sellPricePerOne.Value);
                                                        num1 = 0;
                                                        Task.Run(() => TradeModule.SendPearlAppAlarm(ref buyUserIdList, model.sellMainKey, "BUY"));
                                                    }
                                                    else
                                                    {
                                                        LogUtil.WriteLog(string.Format("[DB Error]waitSellItem - uspSellToWorldMarket({0}/{1}), rv({2})", model.toString(), sellCount, int32), "WARN");
                                                        TradeModule.updateWaitFail(model, info1._weight, customTime);
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    LogUtil.WriteLog(string.Format("[DB Exception]waitSellItem() - uspSellToWorldMarket({0}/{1}) Exception : {2}", model.toString(), sellCount, ex.ToString()), "ERROR");
                                                    TradeModule.updateWaitFail(model, info1._weight, customTime);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }));
            }
        }
    }
}
