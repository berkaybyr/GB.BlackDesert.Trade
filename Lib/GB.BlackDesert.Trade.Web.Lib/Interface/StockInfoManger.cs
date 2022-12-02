// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.Interface.StockInfoManger
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using BlackDesert.TradeMarket.Lib.Manager;

namespace BlackDesert.TradeMarket.Lib.Interface
{
    public abstract class StockInfoManger
    {
        protected object _managerlocker = new object();
        protected object _stockInfoLocker = new object();
        protected object _stockGroupLocker = new object();
        protected object _stockDetailLocker = new object();
        protected object _stockHotLocker = new object();
        protected object _stockWaitLocker = new object();
        protected Dictionary<int, MarketItemInfo> _stockInfoList;
        protected Dictionary<KeyValuePair<int, int>, MarketGroupInfo> _stockGroupInfoList;
        protected Dictionary<KeyValuePair<int, int>, DetailInfo> _stockDetailInfoList;
        protected Dictionary<int, MarketHotItemInfo> _stockHotInfoList;
        protected List<MarketWaitValue> _stockWaitInfoList;
        protected DateTime _lastHotStockUpdateTime;
        protected DateTime _lastWaitStockUpdateTime;
        protected readonly string _managerName;
        protected readonly KeyType _keyType;
        protected bool _isOpen;

        public StockInfoManger()
        {
            _stockInfoList = new Dictionary<int, MarketItemInfo>();
            _stockGroupInfoList = new Dictionary<KeyValuePair<int, int>, MarketGroupInfo>();
            _stockDetailInfoList = new Dictionary<KeyValuePair<int, int>, DetailInfo>();
            _stockHotInfoList = new Dictionary<int, MarketHotItemInfo>();
            _stockWaitInfoList = new List<MarketWaitValue>();
            _lastHotStockUpdateTime = new DateTime();
            _managerName = "stockInfoManager";
            _keyType = KeyType.eCount;
            _isOpen = false;
        }

        public StockInfoManger(string managerName, KeyType keyType)
          : this()
        {
            _managerName = !managerName.IsNullOrEmpty() ? managerName : "stockInfoManager";
            _keyType = keyType;
        }

        public int open(ServerType serverType)
        {
            if (!ItemInfoManager.This().isOpen())
            {
                ServerLogManager.serverLogWrite(ServerLogType.eNotOpen, _managerName + "-ItemInfoManager");
                return -1;
            }
            Stopwatch stopwatch = new Stopwatch();
            lock (_managerlocker)
            {
                if (_isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, _managerName);
                    return 0;
                }
                stockInfoListWrapper stockInfoListWrapper;
                switch (_keyType)
                {
                    case KeyType.eItem:
                        stockInfoListWrapper = ItemInfoManager.This().getItemListXXX();
                        break;
                    case KeyType.eServant:
                        stockInfoListWrapper = ItemInfoManager.This().getServantListXXX();
                        break;
                    default:
                        ServerLogManager.serverLogWrite(ServerLogType.eImpossible, _managerName);
                        return -2;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, _managerName);
                stopwatch.Start();
                foreach (KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo> keyValuePair in stockInfoListWrapper)
                {
                    int mainKey = keyValuePair.Value._mainKey;
                    int subKey = keyValuePair.Value._subKey;
                    if (keyValuePair.Value._enchantGroup == subKey)
                    {
                        KeyValuePair<int, int> key1 = new KeyValuePair<int, int>(keyValuePair.Value._mainGroupNo, keyValuePair.Value._subGroupNo);
                        KeyValuePair<int, int> key2 = new KeyValuePair<int, int>(keyValuePair.Value._mainGroupNo, 0);
                        if (!_stockInfoList.ContainsKey(mainKey))
                            _stockInfoList[mainKey] = new MarketItemInfo();
                        _stockInfoList[mainKey]._infoList[subKey] = new MarketValue();
                        if (!_stockGroupInfoList.ContainsKey(key1))
                            _stockGroupInfoList[key1] = new MarketGroupInfo();
                        if (!_stockGroupInfoList[key1]._infoList.ContainsKey(mainKey))
                            _stockGroupInfoList[key1]._infoList[mainKey] = new MarketValue();
                        if (!_stockGroupInfoList.ContainsKey(key2))
                            _stockGroupInfoList[key2] = new MarketGroupInfo();
                        if (!_stockGroupInfoList[key2]._infoList.ContainsKey(mainKey))
                            _stockGroupInfoList[key2]._infoList[mainKey] = new MarketValue();
                        if (!_stockDetailInfoList.ContainsKey(key1))
                            _stockDetailInfoList[key1] = new DetailInfo();
                        _stockDetailInfoList[key1]._infoList[keyValuePair.Key] = new MarketValue();
                        if (!_stockDetailInfoList.ContainsKey(key2))
                            _stockDetailInfoList[key2] = new DetailInfo();
                        _stockDetailInfoList[key2]._infoList[keyValuePair.Key] = new MarketValue();
                    }
                }
                _isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, _managerName, stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public CommonResult GetStockListByCategory(int mainCategory, int subCategory)
        {
            CommonDBResult<uspListWorldMarket_Result> commonDbResult1 = new CommonDBResult<uspListWorldMarket_Result>();
            TradeMarketList updateList = new TradeMarketList();
            CommonResult result = new CommonResult();
            if (checkUpdateTimeByGroupInfo(mainCategory, subCategory, CommonModule.GetCustomTime()))
            {
                CommonDBResult<uspListWorldMarket_Result> commonDbResult2 = WebDBManager.ListWorldMarket(_keyType, mainCategory, subCategory);
                result.resultCode = commonDbResult2.resultCode;
                result.resultMsg = commonDbResult2.resultMsg;
                if (result.resultCode != 0)
                    return result;
                updateList.list = commonDbResult2.list;
                if (!updateByGroupInfo(mainCategory, subCategory, ref updateList))
                {
                    result.resultMsg = "0";
                    return result;
                }
            }
            if (getJsonStringByGroupInfo(mainCategory, subCategory, ref result))
                return result;
            result.resultMsg = "0";
            return result;
        }

        public CommonResult GetStockSubListBystockKey(int stockKey)
        {
            TradeMarketListDetail marketListDetail = new TradeMarketListDetail();
            CommonDBResult<uspListWorldMarketDetail_Result> commonDbResult = new CommonDBResult<uspListWorldMarketDetail_Result>();
            CommonResult result = new CommonResult();
            if (WorldMarketItemInfoManager.This().checkUpdateTimeByItemInof(stockKey, CommonModule.GetCustomTime()))
            {
                CommonDBResult<uspListWorldMarketDetail_Result> updateList = WebDBManager.ListWorldMarketDetail(_keyType, stockKey, true);
                result.resultCode = updateList.resultCode;
                result.resultMsg = updateList.resultMsg;
                if (result.resultCode != 0)
                    return result;
                marketListDetail.list = updateList.list;
                if (!WorldMarketItemInfoManager.This().updateByItemInfo(ref updateList))
                {
                    result.resultMsg = "0";
                    return result;
                }
            }
            if (WorldMarketItemInfoManager.This().getJsonStringByItemInfo(stockKey, ref result))
                return result;
            result.resultMsg = "0";
            return result;
        }

        public bool checkUpdateTimeByItemInof(int mainKey, DateTime currentTime)
        {
            if (mainKey <= 0)
                return false;
            lock (_stockInfoLocker)
            {
                if (!_stockInfoList.ContainsKey(mainKey))
                    return false;
                DateTime lastUpdateTime = _stockInfoList[mainKey]._lastUpdateTime;
                if (currentTime < lastUpdateTime.AddSeconds(1.0))
                    return false;
                _stockInfoList[mainKey]._lastUpdateTime = currentTime;
            }
            return true;
        }

        private bool checkUpdateTimeByGroupInfo(int mainGroupNo, int subGroupNo, DateTime currentTime)
        {
            if (mainGroupNo <= 0 || subGroupNo < 0)
                return false;
            lock (_stockGroupLocker)
            {
                KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
                if (!_stockGroupInfoList.ContainsKey(key))
                    return false;
                DateTime lastUpdateTime = _stockGroupInfoList[key]._lastUpdateTime;
                if (currentTime < lastUpdateTime.AddSeconds(1.0))
                    return false;
                _stockGroupInfoList[key]._lastUpdateTime = currentTime;
            }
            return true;
        }

        public bool checkUpdateTimeByDetailInfo(int mainGroupNo, int subGroupNo, DateTime currentTime)
        {
            if (mainGroupNo <= 0 || subGroupNo < 0)
                return false;
            lock (_stockDetailLocker)
            {
                KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
                if (!_stockDetailInfoList.ContainsKey(key))
                    return false;
                DateTime lastUpdateTime = _stockDetailInfoList[key]._lastUpdateTime;
                if (currentTime < lastUpdateTime.AddSeconds(1.0))
                    return false;
                _stockDetailInfoList[key]._lastUpdateTime = currentTime;
            }
            return true;
        }

        public bool checkUpdateTimeByHotItemInfo(DateTime currentTime)
        {
            lock (_stockHotLocker)
            {
                DateTime hotStockUpdateTime = _lastHotStockUpdateTime;
                if (currentTime < hotStockUpdateTime.AddSeconds(1.0))
                    return false;
                _lastHotStockUpdateTime = currentTime;
            }
            return true;
        }

        public bool checkUpdateTimeByWaitItemInfo(DateTime currentTime)
        {
            lock (_stockWaitLocker)
            {
                DateTime waitStockUpdateTime = _lastWaitStockUpdateTime;
                if (currentTime < waitStockUpdateTime.AddSeconds(1.0))
                    return false;
                _lastWaitStockUpdateTime = currentTime;
            }
            return true;
        }

        public bool updateByItemInfo(
          ref CommonDBResult<uspListWorldMarketDetail_Result> updateList)
        {
            if (updateList.list.Count <= 0)
                return false;
            lock (_stockInfoLocker)
            {
                foreach (uspListWorldMarketDetail_Result marketDetailResult in updateList.list)
                {
                    int cMainKey = marketDetailResult.C_mainKey;
                    int cSubKey = marketDetailResult.C_subKey;
                    if (_stockInfoList.ContainsKey(cMainKey) && _stockInfoList[cMainKey]._infoList.ContainsKey(cSubKey))
                    {
                        MarketValue info1 = _stockInfoList[cMainKey]._infoList[cSubKey];
                        long? nullable = marketDetailResult.C_count;
                        long num1 = nullable.Value;
                        info1._count = num1;
                        MarketValue info2 = _stockInfoList[cMainKey]._infoList[cSubKey];
                        nullable = marketDetailResult.C_totalTradeCount;
                        long num2 = nullable.Value;
                        info2._totalTradedCount = num2;
                        MarketValue info3 = _stockInfoList[cMainKey]._infoList[cSubKey];
                        nullable = marketDetailResult.C_pricePerOne;
                        long num3 = nullable.Value;
                        info3._pricePerOne = num3;
                        _stockInfoList[cMainKey]._infoList[cSubKey]._minPrice = marketDetailResult.C_minPrice;
                        _stockInfoList[cMainKey]._infoList[cSubKey]._maxPrice = marketDetailResult.C_maxPrice;
                        _stockInfoList[cMainKey]._infoList[cSubKey]._lastTradePrice = marketDetailResult.C_lastTradePrice;
                        _stockInfoList[cMainKey]._infoList[cSubKey]._lastTradeTime = marketDetailResult.C_lastTradeTime;
                        _stockInfoList[cMainKey]._infoList[cSubKey]._isDisplay = marketDetailResult.C_isDisplay.Value;
                    }
                }
            }
            return true;
        }

        private bool updateByGroupInfo(int mainGroupNo, int subGroupNo, ref TradeMarketList updateList)
        {
            if (mainGroupNo <= 0 || subGroupNo < 0 || updateList.list.Count <= 0)
                return false;
            lock (_stockGroupLocker)
            {
                KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
                if (!_stockGroupInfoList.ContainsKey(key))
                    return false;
                foreach (uspListWorldMarket_Result worldMarketResult in updateList.list)
                {
                    int cMainKey = worldMarketResult.C_mainKey;
                    if (_stockGroupInfoList[key]._infoList.ContainsKey(cMainKey))
                    {
                        MarketValue info1 = _stockGroupInfoList[key]._infoList[cMainKey];
                        long? nullable = worldMarketResult.C_sumCount;
                        long num1 = nullable.Value;
                        info1._count = num1;
                        MarketValue info2 = _stockGroupInfoList[key]._infoList[cMainKey];
                        nullable = worldMarketResult.C_totalSumCount;
                        long num2 = nullable.Value;
                        info2._totalTradedCount = num2;
                        MarketValue info3 = _stockGroupInfoList[key]._infoList[cMainKey];
                        nullable = worldMarketResult.C_minPrice;
                        long num3 = nullable.Value;
                        info3._pricePerOne = num3;
                        _stockGroupInfoList[key]._infoList[cMainKey]._isDisplay = worldMarketResult.C_isDisplay.Value;
                    }
                }
            }
            return true;
        }

        public bool updateByDetailInfo(
          int mainGroupNo,
          int subGroupNo,
          ref TradeMarketListDetailByCategory updateList)
        {
            if (mainGroupNo <= 0 || subGroupNo < 0 || updateList.list.Count <= 0)
                return false;
            lock (_stockDetailLocker)
            {
                KeyValuePair<int, int> key1 = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
                if (!_stockDetailInfoList.ContainsKey(key1))
                    return false;
                foreach (uspListWorldMarketDetailByCategory_Result byCategoryResult in updateList.list)
                {
                    KeyValuePair<int, int> key2 = new KeyValuePair<int, int>(byCategoryResult.C_mainKey, byCategoryResult.C_subKey);
                    if (_stockDetailInfoList[key1]._infoList.ContainsKey(key2))
                    {
                        MarketValue info1 = _stockDetailInfoList[key1]._infoList[key2];
                        long? nullable = byCategoryResult.C_count;
                        long num1 = nullable.Value;
                        info1._count = num1;
                        MarketValue info2 = _stockDetailInfoList[key1]._infoList[key2];
                        nullable = byCategoryResult.C_totalTradeCount;
                        long num2 = nullable.Value;
                        info2._totalTradedCount = num2;
                        MarketValue info3 = _stockDetailInfoList[key1]._infoList[key2];
                        nullable = byCategoryResult.C_pricePerOne;
                        long num3 = nullable.Value;
                        info3._pricePerOne = num3;
                        _stockDetailInfoList[key1]._infoList[key2]._minPrice = byCategoryResult.C_minPrice;
                        _stockDetailInfoList[key1]._infoList[key2]._maxPrice = byCategoryResult.C_maxPrice;
                        _stockDetailInfoList[key1]._infoList[key2]._isDisplay = byCategoryResult.C_isDisplay.Value;
                    }
                }
            }
            return true;
        }

        public bool updateByHotItemInfo(
          ref CommonDBResult<uspListWorldMarketHot_Result> updateList)
        {
            lock (_stockHotLocker)
            {
                _stockHotInfoList.Clear();
                _stockHotInfoList = new Dictionary<int, MarketHotItemInfo>();
                foreach (uspListWorldMarketHot_Result worldMarketHotResult in updateList.list)
                {
                    int cMainKey = worldMarketHotResult.C_mainKey;
                    int cSubKey = worldMarketHotResult.C_subKey;
                    TradeMarketItemInfo tradeMarketItemInfo = new TradeMarketItemInfo();
                    switch (_keyType)
                    {
                        case KeyType.eItem:
                            tradeMarketItemInfo = ItemInfoManager.This().getInfo(cMainKey, cSubKey);
                            break;
                        case KeyType.eServant:
                            tradeMarketItemInfo = ItemInfoManager.This().getServantInfo(cMainKey, cSubKey);
                            break;
                    }
                    if (tradeMarketItemInfo.isValid())
                    {
                        if (!_stockHotInfoList.ContainsKey(cMainKey))
                            _stockHotInfoList[cMainKey] = new MarketHotItemInfo();
                        if (!_stockHotInfoList[cMainKey]._infoList.ContainsKey(cSubKey))
                            _stockHotInfoList[cMainKey]._infoList[cSubKey] = new MarketHotValue();
                        MarketHotValue info1 = _stockHotInfoList[cMainKey]._infoList[cSubKey];
                        long? nullable = worldMarketHotResult.C_count;
                        long num1 = nullable.Value;
                        info1._count = num1;
                        MarketHotValue info2 = _stockHotInfoList[cMainKey]._infoList[cSubKey];
                        nullable = worldMarketHotResult.C_totalTradeCount;
                        long num2 = nullable.Value;
                        info2._totalTradedCount = num2;
                        MarketHotValue info3 = _stockHotInfoList[cMainKey]._infoList[cSubKey];
                        nullable = worldMarketHotResult.C_pricePerOne;
                        long num3 = nullable.Value;
                        info3._pricePerOne = num3;
                        _stockHotInfoList[cMainKey]._infoList[cSubKey]._fluctuationType = worldMarketHotResult.C_fluctuationType;
                        _stockHotInfoList[cMainKey]._infoList[cSubKey]._fluctuationPrice = worldMarketHotResult.C_fluctuationPrice;
                        _stockHotInfoList[cMainKey]._infoList[cSubKey]._minPrice = worldMarketHotResult.C_minPrice;
                        _stockHotInfoList[cMainKey]._infoList[cSubKey]._maxPrice = worldMarketHotResult.C_maxPrice;
                        _stockHotInfoList[cMainKey]._infoList[cSubKey]._lastTradePrice = worldMarketHotResult.C_lastTradePrice;
                        _stockHotInfoList[cMainKey]._infoList[cSubKey]._lastTradeTime = worldMarketHotResult.C_lastTradeTime;
                    }
                }
            }
            return true;
        }

        public bool updateByWaitItemInfo(
          ref CommonDBResult<uspListWorldMarketWait_Result> updateList)
        {
            lock (_stockWaitLocker)
            {
                _stockWaitInfoList.Clear();
                _stockWaitInfoList = new List<MarketWaitValue>();
                foreach (uspListWorldMarketWait_Result marketWaitResult in updateList.list)
                {
                    int cMainKey = marketWaitResult.C_mainKey;
                    int cChooseSubKey = marketWaitResult.C_chooseSubKey;
                    TradeMarketItemInfo tradeMarketItemInfo = new TradeMarketItemInfo();
                    switch (_keyType)
                    {
                        case KeyType.eItem:
                            tradeMarketItemInfo = ItemInfoManager.This().getInfo(cMainKey, cChooseSubKey);
                            break;
                        case KeyType.eServant:
                            tradeMarketItemInfo = ItemInfoManager.This().getServantInfo(cMainKey, cChooseSubKey);
                            break;
                    }
                    if (tradeMarketItemInfo.isValid())
                        _stockWaitInfoList.Add(new MarketWaitValue()
                        {
                            _mainKey = marketWaitResult.C_mainKey,
                            _subKey = marketWaitResult.C_chooseSubKey,
                            _pricePerOne = marketWaitResult.C_pricePerOne,
                            _waitEndTime = marketWaitResult.C_waitEndTime.Value
                        });
                }
            }
            return true;
        }

        public bool getJsonStringByItemInfo(int mainKey, ref CommonResult result)
        {
            if (mainKey <= 0 || !_stockInfoList.ContainsKey(mainKey))
                return false;
            int num1 = 0;
            foreach (KeyValuePair<int, MarketValue> info in _stockInfoList[mainKey]._infoList)
            {
                if (0 < info.Value._isDisplay)
                {
                    long num2 = CommonModule.ConvertUnixTime(info.Value._lastTradeTime.ToUniversalTime());
                    if (num2 <= 0L)
                        num2 = 0L;
                    result.resultMsg = result.resultMsg + Convert.ToString(mainKey) + "-" + Convert.ToString(info.Key) + "-" + Convert.ToString(ItemInfoManager.This().getEnchantMaxGroup(mainKey, info.Key)) + "-" + Convert.ToString(info.Value._pricePerOne) + "-" + Convert.ToString(info.Value._count) + "-" + Convert.ToString(info.Value._totalTradedCount) + "-" + Convert.ToString(info.Value._minPrice) + "-" + Convert.ToString(info.Value._maxPrice) + "-" + Convert.ToString(info.Value._lastTradePrice) + "-" + Convert.ToString(num2) + "|";
                    ++num1;
                }
            }
            return num1 != 0;
        }

        public long getMaterialItemInfoXXX(int mainKey) => mainKey <= 0 || !_stockInfoList.ContainsKey(mainKey) || 1 != _stockInfoList[mainKey]._infoList.Count ? 0L : _stockInfoList[mainKey]._infoList[0]._pricePerOne;

        private bool getJsonStringByGroupInfo(int mainGroupNo, int subGroupNo, ref CommonResult result)
        {
            if (mainGroupNo <= 0 || subGroupNo < 0)
                return false;
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
            if (!_stockGroupInfoList.ContainsKey(key))
            {
                result.resultMsg = "0";
                return false;
            }
            int num = 0;
            foreach (KeyValuePair<int, MarketValue> info in _stockGroupInfoList[key]._infoList)
            {
                if (0 < info.Value._isDisplay)
                {
                    result.resultMsg = result.resultMsg + Convert.ToString(info.Key) + "-" + Convert.ToString(info.Value._count) + "-" + Convert.ToString(info.Value._totalTradedCount) + "-" + Convert.ToString(info.Value._pricePerOne) + "|";
                    ++num;
                }
            }
            if (num == 0)
                result.resultMsg = "0";
            return true;
        }

        public bool getJsonStringByDetailInfo(int mainGroupNo, int subGroupNo, ref CommonResult result)
        {
            if (mainGroupNo <= 0 || subGroupNo < 0)
                return false;
            KeyValuePair<int, int> key1 = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
            if (!_stockDetailInfoList.ContainsKey(key1))
            {
                result.resultMsg = "0";
                return false;
            }
            int num = 0;
            foreach (KeyValuePair<KeyValuePair<int, int>, MarketValue> info in _stockDetailInfoList[key1]._infoList)
            {
                if (0 < info.Value._isDisplay)
                {
                    int key2 = info.Key.Key;
                    int groupLevel = info.Key.Value;
                    result.resultMsg = result.resultMsg + Convert.ToString(key2) + "-" + Convert.ToString(groupLevel) + "-" + Convert.ToString(ItemInfoManager.This().getEnchantMaxGroup(key2, groupLevel)) + "-" + Convert.ToString(info.Value._pricePerOne) + "-" + Convert.ToString(info.Value._count) + "-" + Convert.ToString(info.Value._totalTradedCount) + "-" + Convert.ToString(info.Value._minPrice) + "-" + Convert.ToString(info.Value._maxPrice) + "|";
                    ++num;
                }
            }
            if (num != 0)
                return true;
            result.resultMsg = "0";
            return false;
        }

        public bool getJsonStringByHotItemInfo(ref CommonResult result)
        {
            lock (_stockHotLocker)
            {
                if (_stockHotInfoList.Count == 0)
                {
                    result.resultMsg = "0";
                    return false;
                }
                int num1 = 0;
                foreach (KeyValuePair<int, MarketHotItemInfo> stockHotInfo in _stockHotInfoList)
                {
                    int key = stockHotInfo.Key;
                    foreach (KeyValuePair<int, MarketHotValue> info in stockHotInfo.Value._infoList)
                    {
                        long num2 = CommonModule.ConvertUnixTime(info.Value._lastTradeTime.ToUniversalTime());
                        if (num2 <= 0L)
                            num2 = 0L;
                        result.resultMsg = result.resultMsg + Convert.ToString(key) + "-" + Convert.ToString(info.Key) + "-" + Convert.ToString(ItemInfoManager.This().getEnchantMaxGroup(key, info.Key)) + "-" + Convert.ToString(info.Value._pricePerOne) + "-" + Convert.ToString(info.Value._count) + "-" + Convert.ToString(info.Value._totalTradedCount) + "-" + Convert.ToString(info.Value._fluctuationType) + "-" + Convert.ToString(info.Value._fluctuationPrice) + "-" + Convert.ToString(info.Value._minPrice) + "-" + Convert.ToString(info.Value._maxPrice) + "-" + Convert.ToString(info.Value._lastTradePrice) + "-" + Convert.ToString(num2) + "|";
                        ++num1;
                    }
                }
                if (num1 == 0)
                {
                    result.resultMsg = "0";
                    return false;
                }
            }
            return true;
        }

        public bool getJsonStringByWaitItemInfo(ref CommonResult result)
        {
            lock (_stockWaitLocker)
            {
                if (_stockWaitInfoList.Count == 0)
                {
                    result.resultMsg = "0";
                    return false;
                }
                foreach (MarketWaitValue stockWaitInfo in _stockWaitInfoList)
                {
                    long num = CommonModule.ConvertUnixTime(stockWaitInfo._waitEndTime.ToUniversalTime());
                    if (num <= 0L)
                        num = 0L;
                    result.resultMsg = result.resultMsg + Convert.ToString(stockWaitInfo._mainKey) + "-" + Convert.ToString(stockWaitInfo._subKey) + "-" + Convert.ToString(stockWaitInfo._pricePerOne) + "-" + Convert.ToString(num) + "|";
                }
            }
            return true;
        }
    }
}
