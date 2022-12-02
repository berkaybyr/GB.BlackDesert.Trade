namespace BlackDesert.TradeMarket.Application.Manager
{
    public class stockInfoListWrapper :
    IEnumerable<KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo>>,
    IEnumerable
    {
        private readonly Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> _stockInfoList;

        public stockInfoListWrapper(
          Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> list)
        {
            _stockInfoList = list;
        }

        public IEnumerator<KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo>> GetEnumerator() => _stockInfoList.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _stockInfoList.GetEnumerator();

        public Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> getXXX() => _stockInfoList;
    }
}
