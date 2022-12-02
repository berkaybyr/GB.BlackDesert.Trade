// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Common.WorldMarketLog
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Data.Entity.Core.Objects;

namespace GB.BlackDesert.Trade.Web.Lib.Common
{
    public class WorldMarketLog
    {
        private static void logXXX(
          WorldMarketLog.OperationType operationType,
          short reasonType,
          DateTime currentTime,
          CommonModel.TradeMarketUserLogInfo userInfo,
          CommonModel.TradeMarketItemLogInfo itemInfo,
          long param1 = 0,
          long param2 = 0,
          long param3 = 0,
          long param4 = 0,
          long param5 = 0,
          long param6 = 0,
          long param7 = 0,
          long param8 = 0,
          long param9 = 0,
          long param10 = 0,
          long param11 = 0,
          long param12 = 0,
          string textParam1 = "",
          string textParam2 = "")
        {
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            using (PF_BETA_LOGDB_0001 PF_BETA_LOGDB_0001 = new PF_BETA_LOGDB_0001())
            {
                try
                {
                    PF_BETA_LOGDB_0001.uspLogWorldMarketForOperation(new short?((short)operationType), new DateTime?(currentTime), new int?(userInfo.nationCode), new int?(userInfo.serverNo), new long?(userInfo.userNo), new int?(itemInfo.keyType1), new int?(itemInfo.itemKey1), new int?(itemInfo.enchantLevel1), new long?(itemInfo.count1), new long?(itemInfo.beforeCount1), new long?(itemInfo.afterCount1), new int?(itemInfo.keyType2), new int?(itemInfo.itemKey2), new int?(itemInfo.enchantLevel2), new long?(itemInfo.count2), new long?(itemInfo.beforeCount2), new long?(itemInfo.afterCount2), new long?(param1), new long?(param2), new long?(param3), new long?(param4), new long?(param5), new long?(param6), new long?(param7), new long?(param8), new long?(param9), new long?(param10), new long?(param11), new long?(param12), textParam1, textParam2, new short?(reasonType), symNo, rv);
                    int int32 = Convert.ToInt32(rv.Value);
                    if (int32 == 0)
                        return;
                    LogUtil.WriteLog(string.Format("[DB Error] logXXX(operationType({0}),reasonType({1})", (object)(short)operationType, (object)reasonType) + string.Format(",userInfo({0}/{1}/{2})", (object)userInfo.nationCode, (object)userInfo.serverNo, (object)userInfo.userNo) + string.Format(",itemInfo1({0}/{1}/{2}/{3})/{4})/{5})", (object)itemInfo.keyType1, (object)itemInfo.itemKey1, (object)itemInfo.enchantLevel1, (object)itemInfo.count1, (object)itemInfo.beforeCount1, (object)itemInfo.afterCount1) + string.Format(",itemInfo2({0}/{1}/{2}/{3})/{4})/{5})", (object)itemInfo.keyType2, (object)itemInfo.itemKey2, (object)itemInfo.enchantLevel2, (object)itemInfo.count2, (object)itemInfo.beforeCount2, (object)itemInfo.afterCount2) + string.Format(",Param({0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}/{8}/{9}/{10}/{11})", (object)param1, (object)param2, (object)param3, (object)param4, (object)param5, (object)param6, (object)param7, (object)param8, (object)param9, (object)param10, (object)param11, (object)param12) + ",textParam(" + textParam1 + "/" + textParam2 + "))" + string.Format(", rv({0})", (object)int32), "WARN");
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("logXXX Exception : {0}", (object)ex.ToString()), "ERROR");
                }
            }
        }

        public static void logWorldMarket(
          WorldMarketLog.OperationType operationType,
          WorldMarketLog.ReasonType reasonType,
          DateTime currentTime,
          CommonModel.TradeMarketUserLogInfo userInfo,
          CommonModel.TradeMarketItemLogInfo itemInfo,
          long param1 = 0,
          long param2 = 0,
          long param3 = 0,
          long param4 = 0,
          long param5 = 0,
          long param6 = 0,
          long param7 = 0,
          long param8 = 0,
          long param9 = 0,
          long param10 = 0,
          long param11 = 0,
          long param12 = 0,
          string textParam1 = "",
          string textParam2 = "")
        {
            WorldMarketLog.logXXX(operationType, (short)reasonType, currentTime, userInfo, itemInfo, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, textParam1, textParam2);
        }

        public static void logCommand(
          WorldMarketLog.CommandReasonType type,
          DateTime currentTime,
          long param1 = 0,
          long param2 = 0,
          long param3 = 0,
          long param4 = 0,
          long param5 = 0,
          long param6 = 0,
          long param7 = 0,
          long param8 = 0,
          long param9 = 0,
          long param10 = 0,
          long param11 = 0,
          long param12 = 0,
          string textParam1 = "",
          string textParam2 = "")
        {
            WorldMarketLog.logXXX(WorldMarketLog.OperationType.eWorldMarket_OperationType_Command, (short)type, currentTime, new CommonModel.TradeMarketUserLogInfo(), new CommonModel.TradeMarketItemLogInfo(), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, textParam1, textParam2);
        }

        public static bool logDbCheck()
        {
            try
            {
                using (new PF_BETA_LOGDB_0001())
                    ;
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("logDbCheck Exception : {0}", (object)ex.ToString()), "ERROR");
                return false;
            }
            return true;
        }

        public enum OperationType
        {
            eWorldMarket_OperationType_Item,
            eWorldMarket_OperationType_User,
            eWorldMarket_OperationType_Command,
            eWorldMarket_OperationType_Servant,
            eWorldMarket_OperationType_End,
        }

        public enum ReasonType
        {
            eWorldMarket_ReasonType_Buy = 0,
            eWorldMarket_ReasonType_Sell = 1,
            eWorldMarket_ReasonType_BuyBidding = 2,
            eWorldMarket_ReasonType_SellBidding = 3,
            eWorldMarket_ReasonType_Push = 4,
            eWorldMarket_ReasonType_Pop = 5,
            eWorldMarket_ReasonType_PersonalRegister = 6,
            eWorldMarket_ReasonType_PersonalUnRegister = 7,
            eWorldMarket_ReasonType_PersonalBuy = 8,
            eWorldMarket_ReasonType_PersonalReset = 9,
            eWorldMarket_ReasonType_BiddingBuyRegister = 10, // 0x0000000A
            eWorldMarket_ReasonType_BiddingBuyWithdraw = 11, // 0x0000000B
            eWorldMarket_ReasonType_BiddingBuyCalculate = 12, // 0x0000000C
            eWorldMarket_ReasonType_BiddingSellRegister = 13, // 0x0000000D
            eWorldMarket_ReasonType_BiddingSellWithdraw = 14, // 0x0000000E
            eWorldMarket_ReasonType_BiddingSellCalculate = 15, // 0x0000000F
            eWorldMarket_ReasonType_BuySystem = 16, // 0x00000010
            eWorldMarket_ReasonType_BuyBiddingSystem = 17, // 0x00000011
            eWorldMarket_ReasonType_MoneyLog = 18, // 0x00000012
            eWorldMarket_ReasonType_PayloadRestoration = 19, // 0x00000013
            eWorldMarket_ReasonType_Fail_Push = 20, // 0x00000014
            eWorldMarket_ReasonType_Fail_Pop = 21, // 0x00000015
            eWorldMarket_ReasonType_Restoration = 22, // 0x00000016
            eWorldMarket_ReasonType_SellWait = 23, // 0x00000017
            eWorldMarket_ReasonType_SellWaitFailUpdate = 24, // 0x00000018
            eWorldMarket_ReasonType_CreateWallet = 1000, // 0x000003E8
            eWorldMarket_ReasonType_KeyWordInsert = 1001, // 0x000003E9
            eWorldMarket_ReasonType_KeyWordDelete = 1002, // 0x000003EA
            eWorldMarket_ReasonType_End = 1003, // 0x000003EB
        }

        public enum CommandReasonType
        {
            eCommandType_InsertBlockItem,
            eCommandType_RemoveBlockItem,
            eCommandType_UpdateTickCount,
            eCommandType_UpdatePrice,
            eCommandType_InsertBlockUser,
            eCommandType_RemoveBlockUser,
            eCommandType_SetContentsOpen,
            eCommandType_SetMaxPrice,
            eCommandType_AddTrade,
            eCommandType_UpdateTargetPrice,
            eCommandType_Count,
        }
    }
}
