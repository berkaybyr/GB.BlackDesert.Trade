// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.TradeMarketBiddingInfo
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.Collections.Generic;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public class TradeMarketBiddingInfo
    {
        public int _itemKey { get; set; }

        public int _itemEnchantLevel { get; set; }

        public Dictionary<long, TradeMarketBiddingCount> _biddingList { get; set; }

        public TradeMarketBiddingInfo(int itemKey, int itemEnchantLevel)
        {
            this._itemKey = itemKey;
            this._itemEnchantLevel = itemEnchantLevel;
            this._biddingList = new Dictionary<long, TradeMarketBiddingCount>();
        }
    }
}
