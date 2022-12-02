using BlackDesert.TradeMarket.Application.Xml;
using BlackDesert.TradeMarket.Db.TradeContext;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class GroupPriceChanger
    {
        public readonly TblWorldMarket _item;
        public readonly TradeMarketItemInfo _info;
        public long _nextPrice;
        public long _nextGraphPrice;

        public GroupPriceChanger(
          TblWorldMarket item,
          long nextPrice,
          long nextGraphPrice)
        {
            _item = item;
            _info = ItemInfoManager.This().getInfo(item.MainKey, item.SubKey);
            _nextPrice = nextPrice;
            _nextGraphPrice = nextGraphPrice;
        }

        public double priceRatio => (double)(_item.PricePerOne - _info._minPrice) / (double)(_info._maxPrice - _info._minPrice);

        public long price => _item.PricePerOne;

        public long nextPrice
        {
            get => _nextPrice;
            set
            {
                long val1_1 = Math.Max((long)(price * (1.0 - WorldMarketOptionManager.This().BiddingRatio)), _info._realMinPrice);
                long val1_2 = Math.Min((long)(price * (1.0 + WorldMarketOptionManager.This().BiddingRatio)), _info._realMaxPrice);
                value = Math.Max(val1_1, value);
                long val2 = value;
                value = Math.Min(val1_2, val2);
                value = VariedPriceInfoManager.This().calculatePrice(value);
                _nextPrice = value;
            }
        }

        public long nextGraphPrice
        {
            get => _nextGraphPrice;
            set => _nextGraphPrice = value;
        }

        public double nextPriceRatio
        {
            get => (nextPrice - _info._minPrice) / (double)(_info._maxPrice - _info._minPrice);
            set => nextPrice = _info._minPrice + (long)((_info._maxPrice - _info._minPrice) * value);
        }
    }
}
