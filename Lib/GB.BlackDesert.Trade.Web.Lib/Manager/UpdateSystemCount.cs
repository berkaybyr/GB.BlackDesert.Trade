// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.UpdateSystemCount
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace BlackDesert.TradeMarket.Lib.Manager
{
    public class UpdateSystemCount
    {
        private static object _locker = new object();
        private static bool _flag = false;

        public static void Excute(object state)
        {
            lock (UpdateSystemCount._locker)
            {
                if (UpdateSystemCount._flag)
                    return;
                UpdateSystemCount._flag = true;
            }
            try
            {
                UpdateSystemCount.updateSystemCount();
                ServerLogManager.serverLogWrite(ServerLogType.eRunTimer, string.Format("[{0}]UpdateSystemCount", state));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[{0}]UpdateSystemCount Exception={1}", state, (object)ex.ToString()), "ERROR");
            }
            lock (UpdateSystemCount._locker)
                UpdateSystemCount._flag = false;
        }

        private static void updateSystemCount()
        {
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("updateSystemCount Fail is Not Open"), "WARN");
            }
            else
            {
                int systemBuyPercent = WorldMarketOptionManager.This().getSystemBuyPercent();
                int systemStockPercent = WorldMarketOptionManager.This().getSystemStockPercent();
                if (systemBuyPercent <= 0 || systemStockPercent <= 0)
                    return;
                foreach (int num1 in TickCountManager.This().getMainGroupListXXX())
                {
                    if (num1 == WorldMarketOptionManager.This().getCashGroupNo())
                    {
                        TradeMarketMainGroupList marketMainGroupList = new TradeMarketMainGroupList();
                        ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                        ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                        using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                        {
                            try
                            {
                                marketMainGroupList.list = ((IEnumerable<uspListWorldMarketByMainGroup_Result>)SA_BETA_TRADEDB_0002.uspListWorldMarketByMainGroup(new int?(num1), symNo, rv)).ToList<uspListWorldMarketByMainGroup_Result>();
                            }
                            catch (Exception ex)
                            {
                                LogUtil.WriteLog(string.Format("uspListWorldMarketByMainGroup Exception : {0}", (object)ex.ToString()), "ERROR");
                                break;
                            }
                        }
                        foreach (uspListWorldMarketByMainGroup_Result byMainGroupResult in marketMainGroupList.list)
                        {
                            Random random = new Random();
                            int num2 = random.Next(0, 1000000);
                            if (systemBuyPercent >= num2)
                            {
                                int maxValue = (int)(((long)int.MaxValue >= byMainGroupResult.C_count ? (double)(int)byMainGroupResult.C_count : (double)int.MaxValue) * ((double)systemStockPercent / 1000000.0));
                                if (maxValue == 0)
                                    maxValue = 1;
                                int buyCount = random.Next(1, maxValue);
                                UpdateSystemCount.BuyItemSystemProcess(byMainGroupResult.C_keyType, byMainGroupResult.C_mainKey, byMainGroupResult.C_subKey, (long)buyCount);
                            }
                        }
                    }
                }
            }
        }

        private static void BuyItemSystemProcess(
          int buyKeyType,
          int buyMainKey,
          int buySubKey,
          long buyCount)
        {
            if (!ServerControlManager.This().IsLoadComplete())
                LogUtil.WriteLog(string.Format("BuyItemSystemProcess Fail is Not Open"), "WARN");
            else if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog(string.Format("BuyItemSystemProcess log DB Exception"), "WARN");
            }
            else
            {
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                ObjectParameter realBuyCount = new ObjectParameter("realBuyCount", typeof(long));
                ObjectParameter totalMoneyCount = new ObjectParameter("totalMoneyCount", typeof(long));
                ObjectParameter sellNo = new ObjectParameter("sellNo", typeof(long));
                ObjectParameter buyNo = new ObjectParameter("buyNo", typeof(long));
                ObjectParameter stopType = new ObjectParameter("stopType", typeof(int));
                CommonModel.TradeMarketUserLogInfo userInfo = new CommonModel.TradeMarketUserLogInfo();
                TradeMarketItemInfo info = ItemInfoManager.This().getInfo(buyMainKey, buySubKey);
                if (!info.isValid())
                {
                    LogUtil.WriteLog(string.Format("[Item Error]BuyItemSystemProcess() itemInfo({0}, {0}) Not Exist ItemInfo", (object)buyMainKey, (object)buySubKey), "WARN");
                }
                else
                {
                    TradeMarketItemInfo tradeMarketItemInfo = new TradeMarketItemInfo();
                    if (info._enchantMaterialKey != 0)
                    {
                        tradeMarketItemInfo = ItemInfoManager.This().getInfo(info._enchantMaterialKey, 0);
                        if (!info.isValid())
                        {
                            LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess() itemInfo({0}, {1}) Not Exist Material ItemInfo", (object)info._enchantMaterialKey, (object)0), "WARN");
                            return;
                        }
                    }
                    long num1 = buyCount;
                    long num2 = 0;
                    long num3 = 0;
                    int num4 = 0;
                    DateTime customTime = CommonModule.GetCustomTime();
                    using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                    {
                        while (0L < num1)
                        {
                            try
                            {
                                SA_BETA_TRADEDB_0002.uspBuyBiddingFromWorldMarketBySystem(1,new int?(buyKeyType), new int?(buyMainKey), new int?(buySubKey), new long?(num1), new int?(buySubKey), new int?(tradeMarketItemInfo._mainKey), new long?(info._enchantNeedCount), new double?(WorldMarketOptionManager.This().BiddingRatio), realBuyCount, totalMoneyCount, sellNo, stopType, symNo, rv);
                                int int32_1 = Convert.ToInt32(rv.Value);
                                StopReasonType int32_2 = (StopReasonType)Convert.ToInt32(stopType.Value);
                                if (int32_1 == 0)
                                {
                                    if (StopReasonType.eStopReasonType_Empty != int32_2)
                                    {
                                        if (StopReasonType.eStopReasonType_Fail == int32_2)
                                        {
                                            if (5 == num4)
                                            {
                                                LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}) Fail BuyBidding", (object)num1), "WARN");
                                                return;
                                            }
                                            ++num4;
                                        }
                                        else if (int32_2 == StopReasonType.eStopReasonType_Normal)
                                        {
                                            num1 -= Convert.ToInt64(realBuyCount.Value);
                                            num2 += Convert.ToInt64(realBuyCount.Value);
                                            num3 += Convert.ToInt64(totalMoneyCount.Value);
                                            long int64 = Convert.ToInt64(sellNo.Value);
                                            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BuyBiddingSystem, customTime, userInfo, new CommonModel.TradeMarketItemLogInfo()
                                            {
                                                keyType1 = buyKeyType,
                                                itemKey1 = buyMainKey,
                                                enchantLevel1 = buySubKey,
                                                count1 = Convert.ToInt64(realBuyCount.Value),
                                                keyType2 = 0,
                                                itemKey2 = 1,
                                                enchantLevel2 = 0,
                                                count2 = Convert.ToInt64(totalMoneyCount.Value)
                                            }, int64);
                                        }
                                        else
                                        {
                                            LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}) StopReasonType({1}) is Invalid", (object)num1, (object)(int)int32_2), "WARN");
                                            return;
                                        }
                                    }
                                    else
                                        break;
                                }
                                else
                                {
                                    LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}), rv({1})", (object)num1, (object)int32_1), "WARN");
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspBuyBiddingFromWorldMarket({0}) Exception : {1}", (object)num1, (object)ex.ToString()), "ERROR");
                                return;
                            }
                        }
                        if (num1 == 0L)
                            return;
                        try
                        {
                            SA_BETA_TRADEDB_0002.uspBuyFromWorldMarketBySystem(new int?(buyKeyType), new int?(buyMainKey), new int?(buySubKey), new long?(num1), new int?(buySubKey), new int?(tradeMarketItemInfo._mainKey), new long?(info._enchantNeedCount), new double?(WorldMarketOptionManager.This().BiddingRatio), realBuyCount, totalMoneyCount, buyNo, symNo, rv);
                            int int32 = Convert.ToInt32(rv.Value);
                            if (int32 == 0)
                            {
                                if (0L >= num2 + Convert.ToInt64(realBuyCount.Value))
                                    return;
                                WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BuySystem, customTime, userInfo, new CommonModel.TradeMarketItemLogInfo()
                                {
                                    keyType1 = buyKeyType,
                                    itemKey1 = buyMainKey,
                                    enchantLevel1 = buySubKey,
                                    count1 = Convert.ToInt64(realBuyCount.Value),
                                    keyType2 = 0,
                                    itemKey2 = 1,
                                    enchantLevel2 = 0,
                                    count2 = 0L
                                }, (long)buySubKey);
                            }
                            else
                            {
                                if (0L < num2)
                                    return;
                                LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyFromWorldMarket({0}), rv({1})", (object)num1, (object)int32), "WARN");
                            }
                        }
                        catch (Exception ex)
                        {
                            LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspBuyFromWorldMarket({0}) Exception : {1}", (object)num1, (object)ex.ToString()), "ERROR");
                        }
                    }
                }
            }
        }
    }
}
