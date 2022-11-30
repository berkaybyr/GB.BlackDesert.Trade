// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.GameTradeMarketSellAuth
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

namespace GB.BlackDesert.Trade.Web.Game.Api.Models
{
    public class GameTradeMarketSellAuth
    {
        public long userNo { set; get; }

        public string certifiedKey { set; get; }

        public int sellKeyType { set; get; }

        public int sellMainKey { set; get; }

        public int sellSubKey { set; get; }

        public long sellPrice { set; get; }

        public long sellCount { set; get; }

        public int sellChooseKey { set; get; }

        public bool isSealed { set; get; }

        public bool isRingBuff { set; get; }

        public string otp { set; get; }

        public long retryBiddingNo { set; get; }

        public string ticketNo { set; get; }

        public GameTradeMarketSellAuth()
        {
            this.userNo = 0L;
            this.certifiedKey = string.Empty;
            this.sellKeyType = 0;
            this.sellMainKey = 0;
            this.sellSubKey = 0;
            this.sellPrice = 0L;
            this.sellCount = 0L;
            this.sellChooseKey = 0;
            this.isSealed = false;
            this.isRingBuff = false;
            this.otp = string.Empty;
            this.retryBiddingNo = 0L;
            this.ticketNo = string.Empty;
        }
    }
}
