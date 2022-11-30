// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.GroupPriceChanger
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.DB;
using GB.BlackDesert.Trade.Web.Lib.Models;
using System;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public class GroupPriceChanger
    {
        public readonly uspListWorldMarketAccumulateTrade_Result _record;
        public readonly TradeMarketItemInfo _info;
        public long _nextPrice;
        public long _nextGraphPrice;

        public GroupPriceChanger(
          uspListWorldMarketAccumulateTrade_Result record,
          long nextPrice,
          long nextGraphPrice)
        {
            this._record = record;
            this._info = ItemInfoManager.This().getInfo(record.C_mainKey, record.C_subKey);
            this._nextPrice = nextPrice;
            this._nextGraphPrice = nextGraphPrice;
        }

        public double priceRatio => (double)(this._record.C_pricePerOne - this._info._minPrice) / (double)(this._info._maxPrice - this._info._minPrice);

        public long price => this._record.C_pricePerOne;

        public long nextPrice
        {
            get => this._nextPrice;
            set
            {
                long val1_1 = Math.Max((long)((double)this.price * (1.0 - WorldMarketOptionManager.This().BiddingRatio)), this._info._realMinPrice);
                long val1_2 = Math.Min((long)((double)this.price * (1.0 + WorldMarketOptionManager.This().BiddingRatio)), this._info._realMaxPrice);
                value = Math.Max(val1_1, value);
                long val2 = value;
                value = Math.Min(val1_2, val2);
                value = VariedPriceInfoManager.This().calculatePrice(value);
                this._nextPrice = value;
            }
        }

        public long nextGraphPrice
        {
            get => this._nextGraphPrice;
            set => this._nextGraphPrice = value;
        }

        public double nextPriceRatio
        {
            get => (double)(this.nextPrice - this._info._minPrice) / (double)(this._info._maxPrice - this._info._minPrice);
            set => this.nextPrice = this._info._minPrice + (long)((double)(this._info._maxPrice - this._info._minPrice) * value);
        }
    }
}
