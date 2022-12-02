// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.GameTradeMarketUnRegisterPersonalTrade
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

namespace BlackDesert.TradeMarket.Lib.Models.Game
{
    public class GameTradeMarketUnRegisterPersonalTrade
    {
        public long marketNo { set; get; }

        public int keyType { set; get; }

        public int mainKey { set; get; }

        public long pricePerOne { set; get; }

        public int subKey { set; get; }

        public long count { set; get; }

        public int fromNationCode { set; get; }

        public int fromServerNo { set; get; }

        public long fromUserNo { set; get; }

        public GameTradeMarketUnRegisterPersonalTrade()
        {
            this.marketNo = 0L;
            this.keyType = 0;
            this.mainKey = 0;
            this.subKey = 0;
            this.pricePerOne = 0L;
            this.count = 0L;
            this.fromNationCode = 0;
            this.fromServerNo = 0;
            this.fromUserNo = 0L;
        }
    }
}
