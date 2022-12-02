using BlackDesert.TradeMarket.Db.LogContext;
using BlackDesert.TradeMarket.Lib;
using BlackDesert.TradeMarket.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDesert.TradeMarket.Application
{
    public static class DbLogger
    {
        private static void logXXX(
            OperationType operationType,
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
            //ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            //ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            using (PF_BETA_LOGDB_0001Context PF_BETA_LOGDB_000a1 = new PF_BETA_LOGDB_000())
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



    }
}
