// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.Models.GameTradeMarketBuyPersonalTrade
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

namespace BlackDesert.TradeMarket.Lib.Models.Process
{
    public class GameTradeMarketBuyPersonalTrade
    {
        public long marketNo { set; get; }

        public int buyKeyType { set; get; }

        public int buyMainKey { set; get; }

        public int buySubKey { set; get; }

        public long buyCount { set; get; }

        public long moneyCount { set; get; }

        public int toNationCode { set; get; }

        public int toServerNo { set; get; }

        public long toUserNo { set; get; }

        public GameTradeMarketBuyPersonalTrade()
        {
            this.marketNo = 0L;
            this.buyKeyType = 0;
            this.buyMainKey = 0;
            this.buySubKey = 0;
            this.buyCount = 0L;
            this.moneyCount = 0L;
            this.toNationCode = 0;
            this.toServerNo = 0;
            this.toUserNo = 0L;
        }
    }
}
