// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.GameTradeMarketUnRegisterPersonalTradeAuth
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

namespace GB.BlackDesert.Trade.Web.Game.Models
{
    public class GameTradeMarketUnRegisterPersonalTradeAuth
    {
        public long marketNo { set; get; }

        public int keyType { set; get; }

        public int mainKey { set; get; }

        public int subKey { set; get; }

        public long pricePerOne { set; get; }

        public long count { set; get; }

        public long fromUserNo { set; get; }

        public int fromCertifiedKey { set; get; }

        public GameTradeMarketUnRegisterPersonalTradeAuth()
        {
            this.marketNo = 0L;
            this.keyType = 0;
            this.mainKey = 0;
            this.subKey = 0;
            this.pricePerOne = 0L;
            this.count = 0L;
            this.fromUserNo = 0L;
            this.fromCertifiedKey = 0;
        }
    }
}
