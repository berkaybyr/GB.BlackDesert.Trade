namespace BlackDesert.TradeMarket.Application.Manager
{
    public class GroupWeaponPriceList
    {
        public List<GroupWeaponPriceChanger> _list;
        public long _passBiddingCount;
        public long _worldMarketPricePoint;
        public bool _isChange;
        public long _currentPrice;

        public GroupWeaponPriceList()
        {
            _list = new List<GroupWeaponPriceChanger>();
            _passBiddingCount = 0L;
            _worldMarketPricePoint = 0L;
            _isChange = false;
            _currentPrice = 0L;
        }

        public void averageCurrentPrice() => _currentPrice = (long)_list.Average((Func<GroupWeaponPriceChanger, long>)(info => info._record.C_pricePerOne));
    }
}
