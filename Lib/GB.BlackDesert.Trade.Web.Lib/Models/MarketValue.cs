// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.MarketValue
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;

namespace BlackDesert.TradeMarket.Lib.Models
{
    public class MarketValue
    {
        public long _count { get; set; }

        public long _totalTradedCount { get; set; }

        public long _pricePerOne { get; set; }

        public long _minPrice { get; set; }

        public long _maxPrice { get; set; }

        public long _lastTradePrice { get; set; }

        public DateTime _lastTradeTime { get; set; }

        public int _isDisplay { get; set; }

        public MarketValue()
        {
            this._count = 0L;
            this._totalTradedCount = 0L;
            this._pricePerOne = 0L;
            this._minPrice = 0L;
            this._maxPrice = 0L;
            this._lastTradePrice = 0L;
            this._lastTradeTime = DateTime.MinValue;
            this._isDisplay = 0;
        }
    }
}
