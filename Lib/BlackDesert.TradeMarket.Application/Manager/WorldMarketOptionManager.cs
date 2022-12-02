// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.WorldMarketOptionManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using BlackDesert.TradeMarket.Application.Manager;
using BlackDesert.TradeMarket.Lib;
using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Xml;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class WorldMarketOptionManager
    {
        private static volatile WorldMarketOptionManager _singleton;
        private static object _locker = new object();
        private bool _isOpen;
        private const string _managerName = "WorldMarketOptionManager";
        private long _weight;
        private int _weightRate;
        private int _biddingPercent;
        private double _biddingRatio;
        private int _cashGroupNo;
        private int _systemBuyPercent;
        private int _systemStockPercent;
        private int _personalTradeMaxSell;
        private int _personalTradeMaxBuy;
        private int _personalTradeItemKey;
        private int _pearlItemLimitedMaxCount;
        private int _startSleepHour;
        private int _endSleepHour;
        private int _increasefamilyPointWeightRate;
        private int _increaseMaxWeight;
        private int _increaseWeightRateByBuff;
        private int _ringBuffRate;

        public WorldMarketOptionManager()
        {
            _isOpen = false;
            _weight = 0L;
            _weightRate = 0;
            _biddingPercent = 0;
            _biddingRatio = 0.0;
            _cashGroupNo = 0;
            _systemBuyPercent = 0;
            _systemStockPercent = 0;
            _personalTradeMaxSell = 0;
            _personalTradeMaxBuy = 0;
            _personalTradeItemKey = 0;
            _pearlItemLimitedMaxCount = 0;
            _startSleepHour = 0;
            _endSleepHour = 0;
            _increasefamilyPointWeightRate = 0;
            _increaseMaxWeight = 0;
            _increaseWeightRateByBuff = 0;
            _ringBuffRate = 0;
        }

        public static WorldMarketOptionManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new WorldMarketOptionManager();
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
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(WorldMarketOptionManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(WorldMarketOptionManager));
                stopwatch.Start();
                try
                {
                    XmlReader xmlFile = CommonModule.GetXmlFile("/" + ConstantMgr._serviceProject + "WorldTradeMarketItemData/" + ConstantMgr._serviceType, "WorldMarketOptionInfo.xml", serverType);
                    while (xmlFile.Read())
                    {
                        if (xmlFile.Name.CompareTo("WorldMarketOptionInfo") == 0)
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
                                            if (name.CompareTo("Weight") == 0)
                                                _weight = Convert.ToInt64(xmlFile.Value);
                                            else if (name.CompareTo("WeightRate") == 0)
                                                _weightRate = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("BiddingPercent") == 0)
                                                _biddingPercent = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("CashGroupNo") == 0)
                                                _cashGroupNo = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("BuyPercent") == 0)
                                                _systemBuyPercent = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("StockPercent") == 0)
                                                _systemStockPercent = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("PersonalTradeMaxSell") == 0)
                                                _personalTradeMaxSell = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("personalTradeMaxBuy") == 0)
                                                _personalTradeMaxBuy = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("PersonalTradeItemKey") == 0)
                                                _personalTradeItemKey = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("PearlItemLimitedMaxCount") == 0)
                                                _pearlItemLimitedMaxCount = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("StartSleepHour") == 0)
                                                _startSleepHour = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("EndSleepHour") == 0)
                                                _endSleepHour = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("IncreasefamilyPointWeightRate") == 0)
                                                _increasefamilyPointWeightRate = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("IncreaseMaxWeight") == 0)
                                                _increaseMaxWeight = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("IncreaseWeightByBuff") == 0)
                                                _increaseWeightRateByBuff = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("RingBuffRate") == 0)
                                                _ringBuffRate = Convert.ToInt32(xmlFile.Value);
                                        }
                                        while (xmlFile.MoveToNextAttribute());
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    return -1;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return -2;
                }
                if (_weight == 0L)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _weight is 0"), "WARN");
                    return -3;
                }
                if (_weightRate == 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _weightRate is 0"), "WARN");
                    return -4;
                }
                if (_biddingPercent == 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _biddingPercent is 0"), "WARN");
                    return -5;
                }
                BiddingRatio = _biddingPercent;
                if (_cashGroupNo == 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _cashGroupNo is 0"), "WARN");
                    return -6;
                }
                if (_systemBuyPercent < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _buyPercent is negative"), "WARN");
                    return -7;
                }
                if (_systemStockPercent < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _buyPercent is negative"), "WARN");
                    return -8;
                }
                if (0 >= _systemStockPercent || 0 >= _systemBuyPercent)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager either _buyPercent or _stockPercent is negative"), "WARN");
                    return -9;
                }
                if (_startSleepHour < 0 || 23 < _startSleepHour)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _startSleepHour is negative"), "WARN");
                    return -10;
                }
                if (_endSleepHour < 0 || 23 < _endSleepHour)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _endSleepHour is negative"), "WARN");
                    return -11;
                }
                if (_increaseMaxWeight < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _increaseMaxWeight is negative"), "WARN");
                    return -12;
                }
                if (_increaseWeightRateByBuff < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _increaseWeightRateByBuff is negative"), "WARN");
                    return -13;
                }
                if (_increasefamilyPointWeightRate < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _increasefamilyPointWeightRate is negative"), "WARN");
                    return -14;
                }
                if (ConstantMgr._serviceProject.Equals("BDM"))
                {
                    if (_personalTradeMaxSell == 0)
                    {
                        LogUtil.WriteLog(string.Format("WorldMarketOptionManager _personalTradeMaxSell is 0"), "WARN");
                        return -15;
                    }
                    if (_personalTradeMaxBuy == 0)
                    {
                        LogUtil.WriteLog(string.Format("WorldMarketOptionManager _personalTradeMaxBuy is 0"), "WARN");
                        return -16;
                    }
                    if (_personalTradeItemKey == 0)
                    {
                        LogUtil.WriteLog(string.Format("WorldMarketOptionManager _personalTradeItemKey is 0"), "WARN");
                        return -17;
                    }
                }
                if (ConstantMgr._serviceProject.Equals("BDO") && _ringBuffRate < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _ringBuffRate is negative"), "WARN");
                    return -19;
                }
                _isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(WorldMarketOptionManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public long getMaxWeight() => _weight;

        public int getMaxWeightRate() => _weightRate;

        public int getBiddingPercent() => _biddingPercent;

        public double BiddingRatio
        {
            get => _biddingRatio;
            set => _biddingRatio = value / 1000000.0;
        }

        public int getCashGroupNo() => _cashGroupNo;

        public int getSystemBuyPercent() => _systemBuyPercent;

        public int getSystemStockPercent() => _systemStockPercent;

        public int getPersonalTradeMaxSell() => _personalTradeMaxSell;

        public int getPersonalTradeMaxBuy() => _personalTradeMaxBuy;

        public int getPersonalTradeItemKey() => _personalTradeItemKey;

        public int getPearlItemLimitedMaxCount() => _pearlItemLimitedMaxCount;

        public bool isSleepTime()
        {
            int hour = DateTime.Now.Hour;
            if (_endSleepHour == _startSleepHour)
                return false;
            return _endSleepHour < _startSleepHour ? _startSleepHour <= hour || hour < _endSleepHour : _startSleepHour <= hour && hour < _endSleepHour;
        }

        public int getIncreaseWeightByFamilyPoint(int familyPoint)
        {
            int weightByFamilyPoint = familyPoint * _increasefamilyPointWeightRate;
            if (_increaseMaxWeight < weightByFamilyPoint)
                weightByFamilyPoint = _increaseMaxWeight;
            return weightByFamilyPoint;
        }

        public int getIncreaseWeightByBuff(DateTime buffExpiration) => buffExpiration < CommonModule.GetCustomTime() ? 0 : _increaseWeightRateByBuff;

        public int updateRingBuffRateXXX()
        {
            ServerLogManager.serverLogWrite(ServerLogType.eStart, "WorldMarketOptionManager updateRingBuffRateXXX");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    SA_BETA_TRADEDB_0002.uspUpdateRingBuffRate(new int?(_ringBuffRate), symNo, rv);
                    int int32 = Convert.ToInt32(rv.Value);
                    Convert.ToString(symNo.Value);
                    if (int32 != 0)
                    {
                        LogUtil.WriteLog(string.Format(string.Format("uspUpdateRingBuffRate fail : {0}", int32)), "WARN");
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("uspUpdateRingBuffRate Exception : {0}", ex.ToString()), "ERROR");
                return -2;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, "WorldMarketOptionManager updateRingBuffRateXXX", stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }
    }
}
