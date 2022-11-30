// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.GameTradeMarketSellInfo
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

namespace GB.BlackDesert.Trade.Web.Game.Models
{
    public class GameTradeMarketSellInfo
    {
        public int nationCode { set; get; }

        public int worldNo { set; get; }

        public long userNo { set; get; }

        public int sellKeyType { set; get; }

        public int sellMainKey { set; get; }

        public int sellSubKey { set; get; }

        public long sellPrice { set; get; }

        public long sellCount { set; get; }

        public int sellChooseKey { set; get; }

        public bool isSealed { set; get; }

        public bool isWebAccess { set; get; }

        public bool isRingBuff { set; get; }

        public long retryBiddingNo { set; get; }

        public string otp { set; get; }

        public GameTradeMarketSellInfo()
        {
            this.nationCode = 0;
            this.worldNo = 0;
            this.userNo = 0L;
            this.sellKeyType = 0;
            this.sellMainKey = 0;
            this.sellSubKey = 0;
            this.sellPrice = 0L;
            this.sellCount = 0L;
            this.sellChooseKey = 0;
            this.isSealed = false;
            this.isWebAccess = false;
            this.isRingBuff = false;
            this.otp = string.Empty;
            this.retryBiddingNo = 0L;
        }
    }
}
