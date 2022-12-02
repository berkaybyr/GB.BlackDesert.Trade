// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.WorldMarketServantInfoManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using BlackDesert.TradeMarket.Lib;
using BlackDesert.TradeMarket.Lib.Interface;
using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager.Interface;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class WorldMarketServantInfoManager : StockInfoManger
    {
        private static volatile WorldMarketServantInfoManager _singleton;
        private static object _locker = new object();

        public WorldMarketServantInfoManager(string managerName, KeyType keyType)
          : base(managerName, keyType)
        {
        }

        public static WorldMarketServantInfoManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new WorldMarketServantInfoManager(nameof(WorldMarketServantInfoManager), KeyType.eServant);
                }
            }
            return _singleton;
        }
    }
}
