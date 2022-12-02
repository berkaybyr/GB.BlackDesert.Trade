using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class VariedPriceInfoManager
    {
        private static volatile VariedPriceInfoManager _singleton;
        private static object _locker = new object();
        private List<TradeMarketVariedPriceInfo> _variedPriceInfoStaticStatusList;
        private List<long> _variedPriceUnitList;
        private bool _isOpen;
        private const long MAXPRICERANGE = 10000000000000;
        private const string _managerName = "VariedPriceInfoManager";
        private const string _initName = "initCalculatePrice";

        public VariedPriceInfoManager()
        {
            _variedPriceInfoStaticStatusList = new List<TradeMarketVariedPriceInfo>();
            _variedPriceUnitList = new List<long>();
            _isOpen = false;
        }

        public static VariedPriceInfoManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new VariedPriceInfoManager();
                }
            }
            return _singleton;
        }

        public int open(ServerType serverType)
        {
            Stopwatch stopwatch = new Stopwatch();
            long startPrice = 0;
            long endPrice = 0;
            long uintPrice = 0;
            int index = 0;
            long passBiddingCount = 0;
            long worldMarketPricePoint = 0;
            lock (_locker)
            {
                if (_isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(VariedPriceInfoManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(VariedPriceInfoManager));
                stopwatch.Start();
                try
                {
                    XmlReader xmlFile = CommonModule.GetXmlFile("", "WorldMarketVariedPriceInfo.xml", serverType);
                    while (xmlFile.Read())
                    {
                        if (xmlFile.Name.CompareTo("WorldMarketVariedPriceInfo") == 0)
                        {
                            if (xmlFile.NodeType == XmlNodeType.Element)
                            {
                                try
                                {
                                    if (xmlFile.MoveToFirstAttribute())
                                    {
                                        do
                                        {
                                            string name = xmlFile.Name;
                                            if (name.CompareTo("StartRangePrice") == 0)
                                                startPrice = Convert.ToInt64(xmlFile.Value);
                                            else if (name.CompareTo("EndRangePrice") == 0)
                                                endPrice = Convert.ToInt64(xmlFile.Value);
                                            else if (name.CompareTo("UnitPrice") == 0)
                                                uintPrice = Convert.ToInt64(xmlFile.Value);
                                            else if (name.CompareTo("PassBiddingCount") == 0)
                                                passBiddingCount = Convert.ToInt64(xmlFile.Value);
                                            else if (name.CompareTo("WorldMarketPricePoint") == 0)
                                                worldMarketPricePoint = Convert.ToInt64(xmlFile.Value);
                                        }
                                        while (xmlFile.MoveToNextAttribute());
                                    }
                                }
                                catch (Exception ex)
                                {
                                    LogUtil.WriteLog(string.Format("VariedPriceInfoManager fail read Attribute - {0}", ex.ToString()), "ERROR");
                                    return -1;
                                }
                                if (endPrice == 0L)
                                    endPrice = long.MaxValue;
                                if (passBiddingCount <= 0L)
                                {
                                    LogUtil.WriteLog(string.Format("VariedPriceInfoManager fail read passBiddingCount - {0} change to long Max", passBiddingCount), "WARN");
                                    passBiddingCount = long.MaxValue;
                                }
                                if (worldMarketPricePoint <= 0L)
                                {
                                    LogUtil.WriteLog(string.Format("VariedPriceInfoManager fail read worldMarketPricePoint - {0} change to long Max", worldMarketPricePoint), "WARN");
                                    worldMarketPricePoint = long.MaxValue;
                                }
                                _variedPriceInfoStaticStatusList.Add(new TradeMarketVariedPriceInfo(startPrice, endPrice, uintPrice, index, passBiddingCount, worldMarketPricePoint));
                                ++index;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("VariedPriceInfoManager fail load xml - {0}", ex.ToString()), "ERROR");
                    return -1;
                }
                _variedPriceInfoStaticStatusList.Sort((a, b) =>
                {
                    if (a._startPrice > b._startPrice)
                        return 1;
                    return a._startPrice < b._startPrice ? -1 : 0;
                });
                _isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(VariedPriceInfoManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public long calculatePrice(long newPrice, string roundType = "")
        {
            TradeMarketVariedPriceInfo variedPriceInfoXxx = findTradeMarketVariedPriceInfoXXX(newPrice);
            if (variedPriceInfoXxx == null)
                return 0;
            long num1 = (newPrice - variedPriceInfoXxx._startPrice) / variedPriceInfoXxx._uintPrice;
            long num2 = (newPrice - variedPriceInfoXxx._startPrice) % variedPriceInfoXxx._uintPrice;
            return !string.IsNullOrEmpty(roundType) ? !roundType.Equals("UP") ? !roundType.Equals("DOWN") ? 0L : variedPriceInfoXxx._startPrice + variedPriceInfoXxx._uintPrice * num1 : variedPriceInfoXxx._startPrice + variedPriceInfoXxx._uintPrice * (num1 + 1L) : num2 > variedPriceInfoXxx._uintPrice / 2L ? variedPriceInfoXxx._startPrice + variedPriceInfoXxx._uintPrice * (num1 + 1L) : variedPriceInfoXxx._startPrice + variedPriceInfoXxx._uintPrice * num1;
        }

        public int initCalculatePrice()
        {
            if (!_isOpen)
            {
                ServerLogManager.serverLogWrite(ServerLogType.eNotOpen, nameof(initCalculatePrice));
                return -1;
            }
            Stopwatch stopwatch = new Stopwatch();
            ServerLogManager.serverLogWrite(ServerLogType.eStart, "VariedPriceInfoManager initCalculatePrice");
            stopwatch.Start();
            lock (_locker)
            {
                if (_variedPriceUnitList.Count == 0)
                {
                    for (int index = 0; index < _variedPriceInfoStaticStatusList.Count; ++index)
                    {
                        TradeMarketVariedPriceInfo infoStaticStatus = _variedPriceInfoStaticStatusList[index];
                        long num1 = infoStaticStatus._startPrice;
                        long num2 = infoStaticStatus._startPrice + infoStaticStatus._uintPrice;
                        long num3 = 10000000000000L <= infoStaticStatus._endPrice ? 20000000000000L : infoStaticStatus._endPrice;
                        while (num1 <= num3)
                        {
                            _variedPriceUnitList.Add(num1);
                            num1 = num2;
                            num2 += infoStaticStatus._uintPrice;
                        }
                    }
                }
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, "VariedPriceInfoManager initCalculatePrice", stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public List<TradeMarketVariedPriceInfo> getList() => _variedPriceInfoStaticStatusList;

        public List<long> getPriceUnitList() => _variedPriceUnitList;

        public long getUnitPrice(long pricePerOne)
        {
            TradeMarketVariedPriceInfo variedPriceInfoXxx = findTradeMarketVariedPriceInfoXXX(pricePerOne);
            return variedPriceInfoXxx == null ? 0L : variedPriceInfoXxx._uintPrice;
        }

        public List<long> getBiddingList(
          long basePrice,
          double rate,
          TradeMarketItemInfo itemStaticStatus)
        {
            long num1 = (long)(basePrice * (1.0 - rate));
            long num2 = (long)(basePrice * (1.0 + rate));
            List<long> biddingList = new List<long>();
            if (num1 < itemStaticStatus._minPrice)
                num1 = itemStaticStatus._minPrice;
            if (itemStaticStatus._maxPrice < num2)
                num2 = itemStaticStatus._maxPrice;
            long pricePerOne1 = basePrice;
            TradeMarketVariedPriceInfo variedPriceInfoXxx1 = findTradeMarketVariedPriceInfoXXX(pricePerOne1);
            if (variedPriceInfoXxx1 == null)
                return biddingList;
            while (pricePerOne1 <= num2)
            {
                pricePerOne1 += variedPriceInfoXxx1._uintPrice;
                if (num2 >= pricePerOne1)
                {
                    biddingList.Add(pricePerOne1);
                    if (variedPriceInfoXxx1._endPrice < pricePerOne1)
                    {
                        variedPriceInfoXxx1 = getTradeMarketVariedPriceInfoXXX(variedPriceInfoXxx1._index + 1);
                        if (variedPriceInfoXxx1 == null)
                            break;
                    }
                }
                else
                    break;
            }
            long pricePerOne2 = basePrice;
            TradeMarketVariedPriceInfo variedPriceInfoXxx2 = findTradeMarketVariedPriceInfoXXX(pricePerOne2);
            if (variedPriceInfoXxx2 == null)
                return biddingList;
            while (num1 <= pricePerOne2)
            {
                pricePerOne2 -= variedPriceInfoXxx2._uintPrice;
                if (pricePerOne2 >= num1)
                {
                    biddingList.Add(pricePerOne2);
                    if (pricePerOne2 <= variedPriceInfoXxx2._startPrice)
                    {
                        variedPriceInfoXxx2 = getTradeMarketVariedPriceInfoXXX(variedPriceInfoXxx2._index - 1);
                        if (variedPriceInfoXxx2 == null)
                            break;
                    }
                }
                else
                    break;
            }
            biddingList.Add(basePrice);
            biddingList.Sort((a, b) =>
            {
                if (a > b)
                    return 1;
                return a < b ? -1 : 0;
            });
            return biddingList;
        }

        public void getWorldMarketPassCount(
          long pricePerOne,
          ref long passBiddingCount,
          ref long worldMarketPricePoint)
        {
            TradeMarketVariedPriceInfo variedPriceInfoXxx = findTradeMarketVariedPriceInfoXXX(pricePerOne);
            if (variedPriceInfoXxx == null)
            {
                passBiddingCount = 0L;
                worldMarketPricePoint = 0L;
            }
            else
            {
                passBiddingCount = variedPriceInfoXxx._passBiddingCount;
                worldMarketPricePoint = variedPriceInfoXxx._worldMarketPricePoint;
            }
        }

        public TradeMarketVariedPriceInfo getTradeMarketVariedPriceInfoXXX(
          int index)
        {
            return 0 > index || index >= _variedPriceInfoStaticStatusList.Count ? null : _variedPriceInfoStaticStatusList[index];
        }

        public TradeMarketVariedPriceInfo findTradeMarketVariedPriceInfoXXX(
          long pricePerOne)
        {
            int num1 = 0;
            int num2 = _variedPriceInfoStaticStatusList.Count - 1;
            while (num1 <= num2)
            {
                int index = (num1 + num2) / 2;
                TradeMarketVariedPriceInfo infoStaticStatus = _variedPriceInfoStaticStatusList[index];
                if (infoStaticStatus._startPrice <= pricePerOne && pricePerOne <= infoStaticStatus._endPrice)
                    return infoStaticStatus;
                if (pricePerOne < infoStaticStatus._startPrice)
                    num2 = index - 1;
                else if (infoStaticStatus._endPrice < pricePerOne)
                    num1 = index + 1;
            }
            return null;
        }
    }
}
