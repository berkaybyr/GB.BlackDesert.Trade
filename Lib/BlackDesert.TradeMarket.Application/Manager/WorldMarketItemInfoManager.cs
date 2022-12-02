using BlackDesert.TradeMarket.Lib;
using BlackDesert.TradeMarket.Lib.Interface;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class WorldMarketItemInfoManager : StockInfoManger
    {
        private static volatile WorldMarketItemInfoManager _singleton;
        private static object _locker = new object();

        public WorldMarketItemInfoManager(string managerName, KeyType keyType)
          : base(managerName, keyType)
        {
        }

        public static WorldMarketItemInfoManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new WorldMarketItemInfoManager(nameof(WorldMarketItemInfoManager), KeyType.eItem);
                }
            }
            return _singleton;
        }
    }
}
