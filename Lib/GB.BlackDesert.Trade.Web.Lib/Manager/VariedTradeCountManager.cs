// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.VariedTradeCountManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace BlackDesert.TradeMarket.Lib.Manager
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
            this._variedTradeCountInfoStaticStatusList = new List<TradeMarketVariedTradeCountInfo>();
            this._isOpen = false;
        }

        public static VariedTradeCountManager This()
        {
            if (VariedTradeCountManager._singleton == null)
            {
                lock (VariedTradeCountManager._locker)
                {
                    if (VariedTradeCountManager._singleton == null)
                        VariedTradeCountManager._singleton = new VariedTradeCountManager();
                }
            }
            return VariedTradeCountManager._singleton;
        }

        public int open(ServerType serverType)
        {
            Stopwatch stopwatch = new Stopwatch();
            lock (VariedTradeCountManager._locker)
            {
                if (this._isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(VariedTradeCountManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(VariedTradeCountManager));
                stopwatch.Start();
                try
                {
                    XmlReader xmlFile = CommonModule.GetXmlFile("", "WorldMarketVariedTradeCount.xml", serverType);
                    this._variedTradeCountInfoStaticStatusList.Clear();
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
                                    this._variedTradeCountInfoStaticStatusList.Add(variedTradeCountInfo);
                                }
                            }
                            catch (Exception ex)
                            {
                                LogUtil.WriteLog(string.Format("VariedTradeCountInfoManager fail read Attribute - {0}", (object)ex.ToString()), "ERROR");
                                return -1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("VariedTradeCountInfoManager fail load xml - {0}", (object)ex.ToString()), "ERROR");
                    return -1;
                }
                this._variedTradeCountInfoStaticStatusList.Sort((Comparison<TradeMarketVariedTradeCountInfo>)((a, b) =>
                {
                    if (a.minFamilyPoint > b.minFamilyPoint)
                        return 1;
                    return a.minFamilyPoint < b.minFamilyPoint ? -1 : 0;
                }));
                this._isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(VariedTradeCountManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public int getAddTradeCountByFamilyPoint(long familyPoint)
        {
            foreach (TradeMarketVariedTradeCountInfo infoStaticStatus in this._variedTradeCountInfoStaticStatusList)
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
                LogUtil.WriteLog(string.Format("getAddTaxDiscountRateByFamilyPoint {0}", (object)familyPoint), "WARN");
            }
            return rateByFamilyPoint;
        }
    }
}
