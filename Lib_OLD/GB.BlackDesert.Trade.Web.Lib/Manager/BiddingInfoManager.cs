// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.BiddingInfoManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public class BiddingInfoManager
    {
        private static volatile BiddingInfoManager _singleton;
        private static object _locker = new object();
        private Dictionary<KeyValuePair<int, int>, TradeMarketBiddingInfo> _biddinginfoList;
        private Dictionary<KeyValuePair<int, int>, DateTime> _biddingTimeList;
        private bool _isOpen;
        private const string _managerName = "BiddingInfoManager";

        public BiddingInfoManager()
        {
            this._biddinginfoList = new Dictionary<KeyValuePair<int, int>, TradeMarketBiddingInfo>();
            this._biddingTimeList = new Dictionary<KeyValuePair<int, int>, DateTime>();
            this._isOpen = false;
        }

        public static BiddingInfoManager This()
        {
            if (BiddingInfoManager._singleton == null)
            {
                lock (BiddingInfoManager._locker)
                {
                    if (BiddingInfoManager._singleton == null)
                        BiddingInfoManager._singleton = new BiddingInfoManager();
                }
            }
            return BiddingInfoManager._singleton;
        }

        public int open(ServerType serverType)
        {
            if (!ItemInfoManager.This().isOpen())
            {
                ServerLogManager.serverLogWrite(ServerLogType.eNotOpen, "BiddingInfoManager-ItemInfoManager");
                return -1;
            }
            Stopwatch stopwatch = new Stopwatch();
            lock (BiddingInfoManager._locker)
            {
                if (this._isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(BiddingInfoManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(BiddingInfoManager));
                stopwatch.Start();
                foreach (KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo> keyValuePair in ItemInfoManager.This().getItemListXXX())
                {
                    int mainKey = keyValuePair.Value._mainKey;
                    int subKey = keyValuePair.Value._subKey;
                    this._biddinginfoList[keyValuePair.Key] = new TradeMarketBiddingInfo(mainKey, subKey);
                    this._biddingTimeList[keyValuePair.Key] = new DateTime();
                }
                this._isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(BiddingInfoManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public bool checkBiddingUpdateTimeXXX(int mainKey, int subKey, DateTime currentTime)
        {
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainKey, subKey);
            lock (BiddingInfoManager._locker)
            {
                if (!this._biddingTimeList.ContainsKey(key))
                    return false;
                DateTime biddingTime = this._biddingTimeList[key];
                if (currentTime < biddingTime.AddSeconds(1.0))
                    return false;
                this._biddingTimeList[key] = currentTime;
            }
            return true;
        }

        public bool updateBiddingInfoListXXX(
          int mainKey,
          int subKey,
          ref CommonDBResult<uspListBiddingInfo_Result> list)
        {
            if (list.list.Count <= 0)
                return false;
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainKey, subKey);
            lock (BiddingInfoManager._locker)
            {
                if (!this._biddinginfoList.ContainsKey(key))
                    return false;
                this._biddinginfoList[key]._biddingList.Clear();
                foreach (uspListBiddingInfo_Result biddingInfoResult in list.list)
                {
                    long cSellCount = biddingInfoResult.C_sellCount;
                    long cBuyCount = biddingInfoResult.C_buyCount;
                    long cPricePerOne = biddingInfoResult.C_pricePerOne;
                    if (!this._biddinginfoList[key]._biddingList.ContainsKey(cPricePerOne))
                    {
                        this._biddinginfoList[key]._biddingList[cPricePerOne] = new TradeMarketBiddingCount();
                        this._biddinginfoList[key]._biddingList[cPricePerOne]._buyCount = cBuyCount;
                        this._biddinginfoList[key]._biddingList[cPricePerOne]._sellCount = cSellCount;
                    }
                    else
                    {
                        this._biddinginfoList[key]._biddingList[cPricePerOne]._buyCount += cBuyCount;
                        this._biddinginfoList[key]._biddingList[cPricePerOne]._sellCount += cSellCount;
                    }
                }
            }
            return true;
        }

        public void getJsonStringByBiddingListXXX(int mainKey, int subKey, ref CommonResult jsonResult)
        {
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainKey, subKey);
            lock (BiddingInfoManager._locker)
            {
                if (!this._biddinginfoList.ContainsKey(key))
                    jsonResult.resultMsg = "0";
                else if (this._biddinginfoList[key]._biddingList.Count <= 0)
                {
                    jsonResult.resultMsg = "0";
                }
                else
                {
                    foreach (KeyValuePair<long, TradeMarketBiddingCount> bidding in this._biddinginfoList[key]._biddingList)
                        jsonResult.resultMsg = jsonResult.resultMsg + Convert.ToString(bidding.Key) + "-" + Convert.ToString(bidding.Value._sellCount) + "-" + Convert.ToString(bidding.Value._buyCount) + "|";
                }
            }
        }
    }
}
