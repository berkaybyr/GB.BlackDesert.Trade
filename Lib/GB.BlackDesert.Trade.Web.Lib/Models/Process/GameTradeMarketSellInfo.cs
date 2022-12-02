// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.Models.GameTradeMarketSellInfo
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

namespace BlackDesert.TradeMarket.Lib.Models.Process
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

        public string otp { set; get; }

        public long retryBiddingNo { set; get; }

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
