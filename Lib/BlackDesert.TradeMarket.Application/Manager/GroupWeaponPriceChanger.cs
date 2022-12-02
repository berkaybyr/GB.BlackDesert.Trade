using BlackDesert.TradeMarket.Db.TradeContext;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class GroupWeaponPriceChanger
    {
        public readonly TblWorldMarket _record;
        public readonly TradeMarketItemInfo _itemInfo;

        public GroupWeaponPriceChanger(
          TblWorldMarket record,
          TradeMarketItemInfo itemInfo)
        {
            _record = record;
            _itemInfo = itemInfo;
        }
    }
}
