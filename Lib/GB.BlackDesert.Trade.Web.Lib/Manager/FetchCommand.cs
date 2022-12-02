// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.FetchCommand
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace BlackDesert.TradeMarket.Lib.Manager
{
    public class FetchCommand
    {
        private static object _locker = new object();
        private static bool _flag = false;

        public static void Excute(object state)
        {
            lock (FetchCommand._locker)
            {
                if (FetchCommand._flag)
                    return;
                FetchCommand._flag = true;
            }
            try
            {
                FetchCommand.fetchCommand();
                ServerLogManager.serverLogWrite(ServerLogType.eRunTimer, string.Format("[{0}]FetchCommand", state));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[{0}]FetchCommand Exception={1}", state, (object)ex.ToString()), "ERROR");
            }
            lock (FetchCommand._locker)
                FetchCommand._flag = false;
        }

        private static int fetchCommand()
        {
            CommandList commandList = new CommandList();
            int num1 = 0;
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            string errorMsg = string.Empty;
            try
            {
                using (SA_BETA_WORLDDB_0002 SA_BETA_WORLDDB_0002 = new SA_BETA_WORLDDB_0002())
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    commandList.list = ((IEnumerable<uspListWorldTradeMarketCommand_Result>)SA_BETA_WORLDDB_0002.uspListWorldTradeMarketCommand(symNo, rv)).ToList<uspListWorldTradeMarketCommand_Result>();
                    num1 = Convert.ToInt32(rv.Value);
                    if (num1 != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]fetchCommand() - uspListWorldTradeMarketCommand(), rv({0})", (object)num1), "WARN");
                        return num1;
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("[DB Exception] fetchCommand() - uspListWorldTradeMarketCommand() Exception : " + ex.ToString(), "ERROR");
                return num1;
            }
            foreach (uspListWorldTradeMarketCommand_Result marketCommandResult in commandList.list)
            {
                long num2 = marketCommandResult.C_commandNo.Value;
                string cCommandString = marketCommandResult.C_commandString;
                byte num3 = 2;
                string relResult = string.Empty;
                CommonModule.HttpRequest(ConstantMgr._processDomain + "/ProcessCommand", JsonConvert.SerializeObject((object)cCommandString), "POST", "text/json", out relResult, out errorMsg);
                CommonResult commonResult = JsonConvert.DeserializeObject<CommonResult>(relResult);
                if (commonResult == null)
                {
                    LogUtil.WriteLog(string.Format("HttpRequest processCommand commonResult is null. commandNo({0} )", (object)num2), "WARN");
                    num3 = (byte)3;
                }
                else if (commonResult.resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("HttpRequest processCommand commonResult Fail. commandNo({0}) commonResult({1}, {2})", (object)num2, (object)commonResult.resultCode, (object)commonResult.resultMsg), "WARN");
                    num3 = (byte)3;
                }
                try
                {
                    using (SA_BETA_WORLDDB_0002 SA_BETA_WORLDDB_0002 = new SA_BETA_WORLDDB_0002())
                    {
                        ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                        ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                        SA_BETA_WORLDDB_0002.uspSetWorldTradeMarketCommandResult(new long?(num2), new byte?(num3), symNo, rv);
                        int int32 = Convert.ToInt32(rv.Value);
                        if (int32 != 0)
                            LogUtil.WriteLog(string.Format("[DB Error] uspListWorldTradeMarketCommand({0}/{1}), rv({2})", (object)num2, (object)num3, (object)int32), "WARN");
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception] fetchCommand() - uspSetWorldTradeMarketCommandResult({0}/{1}) Exception : {2}", (object)num2, (object)num3, (object)ex.ToString()), "ERROR");
                }
            }
            return 0;
        }
    }
}
