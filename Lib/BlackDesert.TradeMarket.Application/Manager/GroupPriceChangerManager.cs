using BlackDesert.TradeMarket.Db.TradeContext;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class GroupPriceChangerManager
    {
        private static object _locker = new object();
        private static volatile GroupPriceChangerManager _singleton;
        private Dictionary<long, List<GroupPriceChanger>> _priceData;

        public IEnumerable<GroupPriceChanger> changerList => _priceData.SelectMany(price => price.Value);

        public static GroupPriceChangerManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new GroupPriceChangerManager();
                }
            }
            return _singleton;
        }

        private GroupPriceChangerManager() => clear();

        public void clear() => _priceData = new Dictionary<long, List<GroupPriceChanger>>();

        public void add(
          TblWorldMarket record,
          long nextPrice,
          long nextGraphPrice)
        {
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(record.MainKey, record.SubKey);
            if (!_priceData.ContainsKey(info._marketPriceGroup))
                _priceData.Add(info._marketPriceGroup, new List<GroupPriceChanger>());
            _priceData[info._marketPriceGroup].Add(new GroupPriceChanger(record, nextPrice, nextGraphPrice));
        }

        public void update() => _priceData.Keys.ToList().ForEach(group =>
        {
            List<GroupPriceChanger> source1 = _priceData[group];
            double num = source1.Max(groupPriceChanger => groupPriceChanger.priceRatio);
            bool flag = false;
            foreach (GroupPriceChanger groupPriceChanger in source1)
            {
                if (0.05 < Math.Abs(num - groupPriceChanger.priceRatio))
                {
                    groupPriceChanger.nextPriceRatio = num;
                    flag = true;
                }
            }
            if (flag)
                return;
            IEnumerable<double> source2 = source1.Select(groupPriceChanger => groupPriceChanger.nextPriceRatio - groupPriceChanger.priceRatio).Where(ratioDiff => 0.0 != ratioDiff);
            if (!source2.Any())
                return;
            double validDiffRatioAverage = source2.Average();
            source1.ForEach(groupPriceChanger => groupPriceChanger.nextPriceRatio = groupPriceChanger.priceRatio + validDiffRatioAverage);
        });
    }
}
