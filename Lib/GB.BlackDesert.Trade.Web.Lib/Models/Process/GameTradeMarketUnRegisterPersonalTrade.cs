// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.Models.GameTradeMarketUnRegisterPersonalTrade
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

namespace BlackDesert.TradeMarket.Lib.Models.Process
{
    public class GameTradeMarketUnRegisterPersonalTrade
    {
        public long marketNo { set; get; }

        public int keyType { set; get; }

        public int mainKey { set; get; }

        public int subKey { set; get; }

        public long pricePerOne { set; get; }

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
