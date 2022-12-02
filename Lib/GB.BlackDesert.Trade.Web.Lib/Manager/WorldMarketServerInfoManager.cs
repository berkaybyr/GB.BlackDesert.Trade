// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.WorldMarketServerInfoManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Xml;

namespace BlackDesert.TradeMarket.Lib.Manager
{
    public class WorldMarketServerInfoManager
    {
        private static volatile WorldMarketServerInfoManager _singleton;
        private static object _locker = new object();
        private bool _isOpen;
        private const string _managerName = "WorldMarketServerInfoManager";
        public Dictionary<string, TradeMarketServerInfo> _serverInfoList = new Dictionary<string, TradeMarketServerInfo>();

        public WorldMarketServerInfoManager() => this._isOpen = false;

        public static WorldMarketServerInfoManager This()
        {
            if (WorldMarketServerInfoManager._singleton == null)
            {
                lock (WorldMarketServerInfoManager._locker)
                {
                    if (WorldMarketServerInfoManager._singleton == null)
                        WorldMarketServerInfoManager._singleton = new WorldMarketServerInfoManager();
                }
            }
            return WorldMarketServerInfoManager._singleton;
        }

        public int open(ServerType serverType)
        {
            Stopwatch stopwatch = new Stopwatch();
            lock (WorldMarketServerInfoManager._locker)
            {
                if (this._isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(WorldMarketServerInfoManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(WorldMarketServerInfoManager));
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
                                                foreach (string str2 in ((IEnumerable<string>)str1.Split(chArray)).ToList<string>())
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
                                        this._serverInfoList.Add(marketServerInfo._ip, marketServerInfo);
#if DEBUG
                                        var first = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(x => x.AddressFamily == AddressFamily.InterNetwork).ToString();
                                        var debugServ = marketServerInfo;
                                        debugServ._ip = first;
                                        this._serverInfoList.Add(debugServ._ip, debugServ);

#endif
                                        LogUtil.WriteLog(string.Format("[XML INFO] serverInfoInsert : Ip{0} ", (object)marketServerInfo._ip.ToString()), "INFO");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    LogUtil.WriteLog(string.Format("serverInfoInsert Error 1 : ex{0} ", (object)ex.ToString()), "ERROR");
                                    return -1;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("serverInfoInsert Error 2 : ex{0} ", (object)ex.ToString()), "ERROR");
                    return -2;
                }
                this._isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(WorldMarketServerInfoManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public List<int> getAllowMainGroup()
        {
            TradeMarketServerInfo serverInfo = this.getServerInfo();
            if (serverInfo != null)
                return serverInfo._allowMainGroupNo;
            LogUtil.WriteLog(string.Format("getAllowMainGroup info NULL"), "WARN");
            return (List<int>)null;
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
            List<string> ipList = this.getIpList();
            TradeMarketServerInfo serverInfo1 = (TradeMarketServerInfo)null;
            foreach (string str in ipList)
            {
                foreach (KeyValuePair<string, TradeMarketServerInfo> serverInfo2 in this._serverInfoList)
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
                return (TradeMarketServerInfo)null;
            }
            if (serverInfo1.isValid())
                return serverInfo1;
            LogUtil.WriteLog(string.Format("getAllowMainGroup empty"), "WARN");
            return (TradeMarketServerInfo)null;
        }
    }
}
