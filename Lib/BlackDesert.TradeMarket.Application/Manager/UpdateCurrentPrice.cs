using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class UpdateCurrentPrice
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
                updateCurrentPrice();
                ServerLogManager.serverLogWrite(ServerLogType.eRunTimer, string.Format("[{0}]UpdateCurrentPrice", state));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[{0}]UpdateCurrentPrice Exception={1}", state, ex.ToString()), "ERROR");
            }
            lock (_locker)
                _flag = false;
        }

        private static int updateCurrentPrice()
        {
            CommonResult commonResult = new CommonResult();
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            string errorMsg = string.Empty;
            string relResult = string.Empty;
            commonResult.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/updateCurrentPriceProcess", "", "POST", "text/json", out relResult, out errorMsg);
            if (commonResult.resultCode != 0)
            {
                LogUtil.WriteLog("[Http Error]updateCurrentPrice() - HttpRequest SyncNoticeItemListProcess errorMsg : " + errorMsg + " - HttpUrl : " + ConstantMgr._processDomain + "/updateCurrentPriceProcess", "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return commonResult.resultCode;
            }
            CommonDBResult<uspListWorldMarketCurrentPrice_Result> commonDbResult = JsonConvert.DeserializeObject<CommonDBResult<uspListWorldMarketCurrentPrice_Result>>(relResult);
            if (commonDbResult.resultCode != 0)
            {
                LogUtil.WriteLog("[Http Exception] updateCurrentPrice() Exception : " + commonDbResult.resultMsg, "WARN");
                return commonDbResult.resultCode;
            }
            if (commonDbResult.list.Count == 0)
            {
                LogUtil.WriteLog("[DB INFO] updateCurrentPrice() Count = 0", "INFO");
                return 0;
            }
            List<string> stringList = new List<string>();
            foreach (ConnectionStringSettings connectionString in (ConfigurationElementCollection)ConfigurationManager.ConnectionStrings)
            {
                if (connectionString.Name.ToLower().IndexOf("SA_BETA_GAMEDB_0002") == 0)
                    stringList.Add(connectionString.Name);
            }
            foreach (string name in stringList)
            {
                foreach (uspListWorldMarketCurrentPrice_Result currentPriceResult in commonDbResult.list)
                {
                    try
                    {
                        using (SA_BETA_GAMEDB_0002 SA_BETA_GAMEDB_0002 = new SA_BETA_GAMEDB_0002(name))
                            SA_BETA_GAMEDB_0002.uspUpdateCurrentPrice(new int?(currentPriceResult.C_mainKey), new int?(currentPriceResult.C_subKey), new long?(currentPriceResult.C_pricePerOne), rv, symNo);
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog(string.Format("[DB Exception] requpdateCurrentPrice() - uspUpdateCurrentPrice() Exception : {0} , symNo : {1}", ex.ToString(), symNo), "ERROR");
                    }
                }
            }
            return 0;
        }
    }
}
