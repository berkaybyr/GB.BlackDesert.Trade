// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.WorldMarketOptionManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.DB;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Xml;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
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
            this._isOpen = false;
            this._weight = 0L;
            this._weightRate = 0;
            this._biddingPercent = 0;
            this._biddingRatio = 0.0;
            this._cashGroupNo = 0;
            this._systemBuyPercent = 0;
            this._systemStockPercent = 0;
            this._personalTradeMaxSell = 0;
            this._personalTradeMaxBuy = 0;
            this._personalTradeItemKey = 0;
            this._pearlItemLimitedMaxCount = 0;
            this._startSleepHour = 0;
            this._endSleepHour = 0;
            this._increasefamilyPointWeightRate = 0;
            this._increaseMaxWeight = 0;
            this._increaseWeightRateByBuff = 0;
            this._ringBuffRate = 0;
        }

        public static WorldMarketOptionManager This()
        {
            if (WorldMarketOptionManager._singleton == null)
            {
                lock (WorldMarketOptionManager._locker)
                {
                    if (WorldMarketOptionManager._singleton == null)
                        WorldMarketOptionManager._singleton = new WorldMarketOptionManager();
                }
            }
            return WorldMarketOptionManager._singleton;
        }

        public int open(ServerType serverType)
        {
            Stopwatch stopwatch = new Stopwatch();
            lock (WorldMarketOptionManager._locker)
            {
                if (this._isOpen)
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
                                                this._weight = Convert.ToInt64(xmlFile.Value);
                                            else if (name.CompareTo("WeightRate") == 0)
                                                this._weightRate = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("BiddingPercent") == 0)
                                                this._biddingPercent = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("CashGroupNo") == 0)
                                                this._cashGroupNo = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("BuyPercent") == 0)
                                                this._systemBuyPercent = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("StockPercent") == 0)
                                                this._systemStockPercent = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("PersonalTradeMaxSell") == 0)
                                                this._personalTradeMaxSell = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("personalTradeMaxBuy") == 0)
                                                this._personalTradeMaxBuy = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("PersonalTradeItemKey") == 0)
                                                this._personalTradeItemKey = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("PearlItemLimitedMaxCount") == 0)
                                                this._pearlItemLimitedMaxCount = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("StartSleepHour") == 0)
                                                this._startSleepHour = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("EndSleepHour") == 0)
                                                this._endSleepHour = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("IncreasefamilyPointWeightRate") == 0)
                                                this._increasefamilyPointWeightRate = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("IncreaseMaxWeight") == 0)
                                                this._increaseMaxWeight = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("IncreaseWeightByBuff") == 0)
                                                this._increaseWeightRateByBuff = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("RingBuffRate") == 0)
                                                this._ringBuffRate = Convert.ToInt32(xmlFile.Value);
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
                if (this._weight == 0L)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _weight is 0"), "WARN");
                    return -3;
                }
                if (this._weightRate == 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _weightRate is 0"), "WARN");
                    return -4;
                }
                if (this._biddingPercent == 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _biddingPercent is 0"), "WARN");
                    return -5;
                }
                this.BiddingRatio = (double)this._biddingPercent;
                if (this._cashGroupNo == 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _cashGroupNo is 0"), "WARN");
                    return -6;
                }
                if (this._systemBuyPercent < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _buyPercent is negative"), "WARN");
                    return -7;
                }
                if (this._systemStockPercent < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _buyPercent is negative"), "WARN");
                    return -8;
                }
                if (0 >= this._systemStockPercent || 0 >= this._systemBuyPercent)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager either _buyPercent or _stockPercent is negative"), "WARN");
                    return -9;
                }
                if (this._startSleepHour < 0 || 23 < this._startSleepHour)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _startSleepHour is negative"), "WARN");
                    return -10;
                }
                if (this._endSleepHour < 0 || 23 < this._endSleepHour)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _endSleepHour is negative"), "WARN");
                    return -11;
                }
                if (this._increaseMaxWeight < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _increaseMaxWeight is negative"), "WARN");
                    return -12;
                }
                if (this._increaseWeightRateByBuff < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _increaseWeightRateByBuff is negative"), "WARN");
                    return -13;
                }
                if (this._increasefamilyPointWeightRate < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _increasefamilyPointWeightRate is negative"), "WARN");
                    return -14;
                }
                if (ConstantMgr._serviceProject.Equals("BDM"))
                {
                    if (this._personalTradeMaxSell == 0)
                    {
                        LogUtil.WriteLog(string.Format("WorldMarketOptionManager _personalTradeMaxSell is 0"), "WARN");
                        return -15;
                    }
                    if (this._personalTradeMaxBuy == 0)
                    {
                        LogUtil.WriteLog(string.Format("WorldMarketOptionManager _personalTradeMaxBuy is 0"), "WARN");
                        return -16;
                    }
                    if (this._personalTradeItemKey == 0)
                    {
                        LogUtil.WriteLog(string.Format("WorldMarketOptionManager _personalTradeItemKey is 0"), "WARN");
                        return -17;
                    }
                }
                if (ConstantMgr._serviceProject.Equals("BDO") && this._ringBuffRate < 0)
                {
                    LogUtil.WriteLog(string.Format("WorldMarketOptionManager _ringBuffRate is negative"), "WARN");
                    return -19;
                }
                this._isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(WorldMarketOptionManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public long getMaxWeight() => this._weight;

        public int getMaxWeightRate() => this._weightRate;

        public int getBiddingPercent() => this._biddingPercent;

        public double BiddingRatio
        {
            get => this._biddingRatio;
            set => this._biddingRatio = value / 1000000.0;
        }

        public int getCashGroupNo() => this._cashGroupNo;

        public int getSystemBuyPercent() => this._systemBuyPercent;

        public int getSystemStockPercent() => this._systemStockPercent;

        public int getPersonalTradeMaxSell() => this._personalTradeMaxSell;

        public int getPersonalTradeMaxBuy() => this._personalTradeMaxBuy;

        public int getPersonalTradeItemKey() => this._personalTradeItemKey;

        public int getPearlItemLimitedMaxCount() => this._pearlItemLimitedMaxCount;

        public bool isSleepTime()
        {
            int hour = DateTime.Now.Hour;
            if (this._endSleepHour == this._startSleepHour)
                return false;
            return this._endSleepHour < this._startSleepHour ? this._startSleepHour <= hour || hour < this._endSleepHour : this._startSleepHour <= hour && hour < this._endSleepHour;
        }

        public int getIncreaseWeightByFamilyPoint(int familyPoint)
        {
            int weightByFamilyPoint = familyPoint * this._increasefamilyPointWeightRate;
            if (this._increaseMaxWeight < weightByFamilyPoint)
                weightByFamilyPoint = this._increaseMaxWeight;
            return weightByFamilyPoint;
        }

        public int getIncreaseWeightByBuff(DateTime buffExpiration) => buffExpiration < CommonModule.GetCustomTime() ? 0 : this._increaseWeightRateByBuff;

        public int updateRingBuffRateXXX()
        {
            ServerLogManager.serverLogWrite(ServerLogType.eStart, "WorldMarketOptionManager updateRingBuffRateXXX");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    tradeWebDb.uspUpdateRingBuffRate(new int?(this._ringBuffRate), symNo, rv);
                    int int32 = Convert.ToInt32(rv.Value);
                    Convert.ToString(symNo.Value);
                    if (int32 != 0)
                    {
                        LogUtil.WriteLog(string.Format(string.Format("uspUpdateRingBuffRate fail : {0}", (object)int32)), "WARN");
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("uspUpdateRingBuffRate Exception : {0}", (object)ex.ToString()), "ERROR");
                return -2;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, "WorldMarketOptionManager updateRingBuffRateXXX", stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }
    }
}
