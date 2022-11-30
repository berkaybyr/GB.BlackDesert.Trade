// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.Models.GameTradeMarketBuyableReserve
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

namespace GB.BlackDesert.Trade.Web.Process.Api.Models
{
    public class GameTradeMarketBuyableReserve
    {
        public int keyType { set; get; }

        public int mainKey { set; get; }

        public int subKey { set; get; }

        public long count { set; get; }

        public long pricePerOne { set; get; }

        public int nationCode { set; get; }

        public int serverNo { set; get; }

        public long userNo { set; get; }

        public GameTradeMarketBuyableReserve()
        {
            this.keyType = 0;
            this.mainKey = 0;
            this.subKey = 0;
            this.count = 0L;
            this.pricePerOne = 0L;
            this.nationCode = 0;
            this.serverNo = 0;
            this.userNo = 0L;
        }
    }
}
