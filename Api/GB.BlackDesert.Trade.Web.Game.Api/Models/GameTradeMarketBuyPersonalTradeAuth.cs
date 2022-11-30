// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.GameTradeMarketBuyPersonalTradeAuth
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

namespace GB.BlackDesert.Trade.Web.Game.Api.Models
{
    public class GameTradeMarketBuyPersonalTradeAuth
    {
        public long marketNo { set; get; }

        public int buyKeyType { set; get; }

        public int buyMainKey { set; get; }

        public int buySubKey { set; get; }

        public long buyCount { set; get; }

        public long moneyCount { set; get; }

        public long toUserNo { set; get; }

        public int toCertifiedKey { set; get; }

        public GameTradeMarketBuyPersonalTradeAuth()
        {
            this.marketNo = 0L;
            this.buyKeyType = 0;
            this.buyMainKey = 0;
            this.buySubKey = 0;
            this.buyCount = 0L;
            this.moneyCount = 0L;
            this.toUserNo = 0L;
            this.toCertifiedKey = 0;
        }
    }
}
