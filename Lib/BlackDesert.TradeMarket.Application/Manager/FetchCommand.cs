using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class FetchCommand
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
                fetchCommand();
                ServerLogManager.serverLogWrite(ServerLogType.eRunTimer, string.Format("[{0}]FetchCommand", state));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[{0}]FetchCommand Exception={1}", state, ex.ToString()), "ERROR");
            }
            lock (_locker)
                _flag = false;
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
                    commandList.list = ((IEnumerable<uspListWorldTradeMarketCommand_Result>)SA_BETA_WORLDDB_0002.uspListWorldTradeMarketCommand(symNo, rv)).ToList();
                    num1 = Convert.ToInt32(rv.Value);
                    if (num1 != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]fetchCommand() - uspListWorldTradeMarketCommand(), rv({0})", num1), "WARN");
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
                CommonModule.HttpRequest(ConstantMgr._processDomain + "/ProcessCommand", JsonConvert.SerializeObject(cCommandString), "POST", "text/json", out relResult, out errorMsg);
                CommonResult commonResult = JsonConvert.DeserializeObject<CommonResult>(relResult);
                if (commonResult == null)
                {
                    LogUtil.WriteLog(string.Format("HttpRequest processCommand commonResult is null. commandNo({0} )", num2), "WARN");
                    num3 = 3;
                }
                else if (commonResult.resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("HttpRequest processCommand commonResult Fail. commandNo({0}) commonResult({1}, {2})", num2, commonResult.resultCode, commonResult.resultMsg), "WARN");
                    num3 = 3;
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
                            LogUtil.WriteLog(string.Format("[DB Error] uspListWorldTradeMarketCommand({0}/{1}), rv({2})", num2, num3, int32), "WARN");
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception] fetchCommand() - uspSetWorldTradeMarketCommandResult({0}/{1}) Exception : {2}", num2, num3, ex.ToString()), "ERROR");
                }
            }
            return 0;
        }
    }
}
