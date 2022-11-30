// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.DB.uspListWorldMarketHot_Result
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;

namespace GB.BlackDesert.Trade.Web.Lib.DB
{
    public class uspListWorldMarketHot_Result
    {
        public int C_keyType { get; set; }

        public int C_mainKey { get; set; }

        public int C_subKey { get; set; }

        public long? C_pricePerOne { get; set; }

        public long? C_count { get; set; }

        public long? C_totalTradeCount { get; set; }

        public byte C_fluctuationType { get; set; }

        public long C_fluctuationPrice { get; set; }

        public long C_minPrice { get; set; }

        public long C_maxPrice { get; set; }

        public DateTime C_lastTradeTime { get; set; }

        public long C_lastTradePrice { get; set; }
    }
}
