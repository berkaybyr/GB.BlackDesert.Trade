namespace BlackDesert.TradeMarket.Lib.Models
{
    public class TradeMarketBiddingCount
    {
        public long _sellCount { get; set; }

        public long _buyCount { get; set; }

        public TradeMarketBiddingCount()
        {
            _sellCount = 0L;
            _buyCount = 0L;
        }
    }
}
