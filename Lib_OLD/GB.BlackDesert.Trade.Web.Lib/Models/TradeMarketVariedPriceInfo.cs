// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.TradeMarketVariedPriceInfo
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace GB.BlackDesert.Trade.Web.Lib.Models
{
    public class TradeMarketVariedPriceInfo
    {
        public readonly long _startPrice;
        public readonly long _endPrice;
        public readonly long _uintPrice;
        public readonly int _index;
        public readonly long _passBiddingCount;
        public readonly long _worldMarketPricePoint;

        public TradeMarketVariedPriceInfo()
        {
            this._startPrice = 0L;
            this._endPrice = 0L;
            this._uintPrice = 0L;
            this._index = 0;
            this._passBiddingCount = 0L;
            this._worldMarketPricePoint = 0L;
        }

        public TradeMarketVariedPriceInfo(
          long startPrice,
          long endPrice,
          long uintPrice,
          int index,
          long passBiddingCount,
          long worldMarketPricePoint)
        {
            this._startPrice = startPrice;
            this._endPrice = endPrice;
            this._uintPrice = uintPrice;
            this._index = index;
            this._passBiddingCount = passBiddingCount;
            this._worldMarketPricePoint = worldMarketPricePoint;
        }
    }
}
