// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.MarketWaitValue
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;

namespace GB.BlackDesert.Trade.Web.Lib.Models
{
    public class MarketWaitValue
    {
        public int _mainKey { get; set; }

        public int _subKey { get; set; }

        public long _pricePerOne { get; set; }

        public DateTime _waitEndTime { get; set; }

        public MarketWaitValue()
        {
            this._mainKey = 0;
            this._subKey = 0;
            this._pricePerOne = 0L;
            this._waitEndTime = DateTime.MinValue;
        }
    }
}
