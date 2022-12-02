using BlackDesert.TradeMarket.Application.Manager;
using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class VariedTradeCountManager
    {
        private static volatile VariedTradeCountManager _singleton;
        private static object _locker = new object();
        private List<TradeMarketVariedTradeCountInfo> _variedTradeCountInfoStaticStatusList;
        private bool _isOpen;
        private const string _managerName = "VariedTradeCountManager";

        public VariedTradeCountManager()
        {
            _variedTradeCountInfoStaticStatusList = new List<TradeMarketVariedTradeCountInfo>();
            _isOpen = false;
        }

        public static VariedTradeCountManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new VariedTradeCountManager();
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
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(VariedTradeCountManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(VariedTradeCountManager));
                stopwatch.Start();
                try
                {
                    XmlReader xmlFile = CommonModule.GetXmlFile("", "WorldMarketVariedTradeCount.xml", serverType);
                    _variedTradeCountInfoStaticStatusList.Clear();
                    while (xmlFile.Read())
                    {
                        if (xmlFile.Name.CompareTo("WorldTradeMarketVariedTradeCount") == 0 && xmlFile.NodeType == XmlNodeType.Element)
                        {
                            TradeMarketVariedTradeCountInfo variedTradeCountInfo = new TradeMarketVariedTradeCountInfo();
                            try
                            {
                                if (xmlFile.MoveToFirstAttribute())
                                {
                                    do
                                    {
                                        string name = xmlFile.Name;
                                        if (name.CompareTo("MinFamilyPoint") == 0)
                                            variedTradeCountInfo.minFamilyPoint = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("MaxFamilyPoint") == 0)
                                            variedTradeCountInfo.maxFamilyPoint = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("AddTradeCount") == 0)
                                            variedTradeCountInfo.addTradeCount = Convert.ToInt32(xmlFile.Value);
                                    }
                                    while (xmlFile.MoveToNextAttribute());
                                    _variedTradeCountInfoStaticStatusList.Add(variedTradeCountInfo);
                                }
                            }
                            catch (Exception ex)
                            {
                                LogUtil.WriteLog(string.Format("VariedTradeCountInfoManager fail read Attribute - {0}", ex.ToString()), "ERROR");
                                return -1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("VariedTradeCountInfoManager fail load xml - {0}", ex.ToString()), "ERROR");
                    return -1;
                }
                _variedTradeCountInfoStaticStatusList.Sort((a, b) =>
                {
                    if (a.minFamilyPoint > b.minFamilyPoint)
                        return 1;
                    return a.minFamilyPoint < b.minFamilyPoint ? -1 : 0;
                });
                _isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(VariedTradeCountManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public int getAddTradeCountByFamilyPoint(long familyPoint)
        {
            foreach (TradeMarketVariedTradeCountInfo infoStaticStatus in _variedTradeCountInfoStaticStatusList)
            {
                if (infoStaticStatus.minFamilyPoint <= familyPoint && familyPoint <= infoStaticStatus.maxFamilyPoint)
                    return infoStaticStatus.addTradeCount;
            }
            return 0;
        }

        public double getAddTaxDiscountRateByFamilyPoint(long familyPoint)
        {
            double rateByFamilyPoint;
            if (0L <= familyPoint && familyPoint < 1000L)
                rateByFamilyPoint = 0.0;
            else if (1000L <= familyPoint && familyPoint < 4000L)
                rateByFamilyPoint = 5000.0;
            else if (4000L <= familyPoint && familyPoint < 7000L)
                rateByFamilyPoint = 10000.0;
            else if (7000L <= familyPoint)
            {
                rateByFamilyPoint = 15000.0;
            }
            else
            {
                rateByFamilyPoint = 0.0;
                LogUtil.WriteLog(string.Format("getAddTaxDiscountRateByFamilyPoint {0}", familyPoint), "WARN");
            }
            return rateByFamilyPoint;
        }
    }
}
