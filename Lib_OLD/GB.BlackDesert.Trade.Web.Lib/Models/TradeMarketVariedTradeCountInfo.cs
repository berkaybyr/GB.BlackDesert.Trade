// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.TradeMarketVariedTradeCountInfo
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace GB.BlackDesert.Trade.Web.Lib.Models
{
    public class TradeMarketVariedTradeCountInfo
    {
        public long minFamilyPoint { get; set; }

        public long maxFamilyPoint { get; set; }

        public int addTradeCount { get; set; }

        public TradeMarketVariedTradeCountInfo()
        {
            this.minFamilyPoint = 0L;
            this.maxFamilyPoint = 0L;
            this.addTradeCount = 0;
        }
    }
}
