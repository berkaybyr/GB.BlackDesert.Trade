using BlackDesert.TradeMarket.Db.LogContext;
using BlackDesert.TradeMarket.Lib;
using BlackDesert.TradeMarket.Lib.Models;
using BlackDesert.TradeMarket.Lib.Util;
using Newtonsoft.Json;
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
            TradeMarketUserLogInfo userInfo,
            TradeMarketItemLogInfo itemInfo,
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
            LogUtil.WriteLog($"[DB Error] logXXX(operationType({operationType}),reasonType({reasonType}),user({JsonConvert.SerializeObject(userInfo)}),item({itemInfo}),params(" + string.Format(",Param({0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}/{8}/{9}/{10}/{11})", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12) + ",textParam(" + textParam1 + "/" + textParam2 + "))", "WARN");
        }

        public static void logWorldMarket(
          OperationType operationType,
          ReasonType reasonType,
          DateTime currentTime,
          TradeMarketUserLogInfo userInfo,
          TradeMarketItemLogInfo itemInfo,
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
            logXXX(operationType, (short)reasonType, currentTime, userInfo, itemInfo, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, textParam1, textParam2);
        }

        public static void logCommand(
          CommandReasonType type,
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
            logXXX(OperationType.eWorldMarket_OperationType_Command, (short)type, currentTime, new TradeMarketUserLogInfo(), new TradeMarketItemLogInfo(), param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, textParam1, textParam2);
        }



    }
}
