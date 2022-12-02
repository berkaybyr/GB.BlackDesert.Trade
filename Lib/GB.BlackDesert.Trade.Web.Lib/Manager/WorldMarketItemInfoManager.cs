// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.WorldMarketItemInfoManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager.Interface;

namespace BlackDesert.TradeMarket.Lib.Manager
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
            if (WorldMarketItemInfoManager._singleton == null)
            {
                lock (WorldMarketItemInfoManager._locker)
                {
                    if (WorldMarketItemInfoManager._singleton == null)
                        WorldMarketItemInfoManager._singleton = new WorldMarketItemInfoManager(nameof(WorldMarketItemInfoManager), KeyType.eItem);
                }
            }
            return WorldMarketItemInfoManager._singleton;
        }
    }
}
