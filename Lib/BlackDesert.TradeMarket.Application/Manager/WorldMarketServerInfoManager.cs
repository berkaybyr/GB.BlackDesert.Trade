using BlackDesert.TradeMarket.Application.Manager;
using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class WorldMarketServerInfoManager
    {
        private static volatile WorldMarketServerInfoManager _singleton;
        private static object _locker = new object();
        private bool _isOpen = false;
        private const string _managerName = "WorldMarketServerInfoManager";
        public Dictionary<string, TradeMarketServerInfo> _serverInfoList = new Dictionary<string, TradeMarketServerInfo>();

        private WorldMarketServerInfoManager() {  }
        public static WorldMarketServerInfoManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    _singleton = new WorldMarketServerInfoManager();
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
                    ServerLogManager.ServerLogWrite(ServerLogType.eAlready, nameof(WorldMarketServerInfoManager));
                    return 0;
                }
                ServerLogManager.ServerLogWrite(ServerLogType.eStart, nameof(WorldMarketServerInfoManager));
                try
                {
                    XmlReader xmlFile = CommonModule.GetXmlFile("/" + ConstantMgr._serviceProject + "WorldTradeMarketItemData/" + ConstantMgr._serviceType, "WorldTradeMarketServerInfo.xml", serverType);
                    while (xmlFile.Read())
                    {
                        if (xmlFile.Name.CompareTo("WorldMarketServerInfo") == 0)
                        {
                            if (xmlFile.NodeType == XmlNodeType.Element)
                            {
                                try
                                {
                                    if (xmlFile.MoveToFirstAttribute())
                                    {
                                        TradeMarketServerInfo marketServerInfo = new TradeMarketServerInfo();
                                        do
                                        {
                                            string name = xmlFile.Name;
                                            if (name.CompareTo("Ip") == 0)
                                                marketServerInfo._ip = Convert.ToString(xmlFile.Value);
                                            if (name.CompareTo("AllowMainGroupNo") == 0)
                                            {
                                                string str1 = xmlFile.Value;
                                                char[] chArray = new char[1] { '|' };
                                                foreach (string str2 in str1.Split(chArray).ToList<string>())
                                                {
                                                    if (!str2.ToUpper().Equals("0"))
                                                        marketServerInfo._allowMainGroupNo.Add(Convert.ToInt32(str2));
                                                }
                                            }
                                            if (name.CompareTo("ServerType") == 0)
                                                marketServerInfo._serverType = (ServerType)Convert.ToInt32(xmlFile.Value);
                                            if (name.CompareTo("IsTimerSet") == 0)
                                                marketServerInfo._setTimer = Convert.ToBoolean(xmlFile.Value);
                                            if (name.CompareTo("IsInitHistory") == 0)
                                                marketServerInfo._isInitHistory = Convert.ToBoolean(xmlFile.Value);
                                        }
                                        while (xmlFile.MoveToNextAttribute());
                                        if ("" == marketServerInfo._ip)
                                        {
                                            LogUtil.WriteLog(string.Format("WorldMarketServerInfoManager fail read IP"), "WARN");
                                            return -3;
                                        }
                                        _serverInfoList.Add(marketServerInfo._ip, marketServerInfo);
#if DEBUG
                                        var first = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(x => x.AddressFamily == AddressFamily.InterNetwork).ToString();
                                        var debugServ = marketServerInfo;
                                        debugServ._ip = first;
                                        _serverInfoList.Add(debugServ._ip, debugServ);

#endif
                                        LogUtil.WriteLog(string.Format("[XML INFO] serverInfoInsert : Ip{0} ", marketServerInfo._ip.ToString()), "INFO");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    LogUtil.WriteLog(string.Format("serverInfoInsert Error 1 : ex{0} ", ex.ToString()), "ERROR");
                                    return -1;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("serverInfoInsert Error 2 : ex{0} ", ex.ToString()), "ERROR");
                    return -2;
                }
                _isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.ServerLogWrite(ServerLogType.eComplete, nameof(WorldMarketServerInfoManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public List<int> getAllowMainGroup()
        {
            TradeMarketServerInfo serverInfo = getServerInfo();
            if (serverInfo != null)
                return serverInfo._allowMainGroupNo;
            LogUtil.WriteLog(string.Format("getAllowMainGroup info NULL"), "WARN");
            return null;
        }

        public List<string> getIpList()
        {
            List<string> ipList = new List<string>();
            var addresses = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            foreach (IPAddress address in addresses)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    ipList.Add(address.ToString());
            }
            return ipList;
        }

        public TradeMarketServerInfo getServerInfo()
        {
            List<string> ipList = getIpList();
            TradeMarketServerInfo serverInfo1 = null;
            foreach (string str in ipList)
            {
                foreach (KeyValuePair<string, TradeMarketServerInfo> serverInfo2 in _serverInfoList)
                {
                    if (serverInfo2.Value._ip == str)
                    {
                        serverInfo1 = serverInfo2.Value;
                        break;
                    }
                }
                if (serverInfo1 != null)
                    break;
            }
            if (serverInfo1 == null)
            {
                LogUtil.WriteLog(string.Format("getAllowMainGroup info NULL"), "WARN");
                return null;
            }
            if (serverInfo1.isValid())
                return serverInfo1;
            LogUtil.WriteLog(string.Format("getAllowMainGroup empty"), "WARN");
            return null;
        }
    }
}
