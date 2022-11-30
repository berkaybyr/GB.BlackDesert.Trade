// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.TradeMarketBiddingCount
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public class TradeMarketBiddingCount
    {
        public long _sellCount { get; set; }

        public long _buyCount { get; set; }

        public TradeMarketBiddingCount()
        {
            this._sellCount = 0L;
            this._buyCount = 0L;
        }
    }
}
