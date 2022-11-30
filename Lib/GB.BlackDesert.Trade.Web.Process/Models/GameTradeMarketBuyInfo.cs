// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.Models.GameTradeMarketBuyInfo
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

namespace GB.BlackDesert.Trade.Web.Process.Models
{
    public class GameTradeMarketBuyInfo
    {
        public int nationCode { set; get; }

        public int worldNo { set; get; }

        public long userNo { set; get; }

        public int buyKeyType { set; get; }

        public int buyMainKey { set; get; }

        public int buySubKey { set; get; }

        public long buyPrice { set; get; }

        public long buyCount { set; get; }

        public int buyChooseKey { set; get; }

        public bool isWebAccess { set; get; }

        public string otp { set; get; }

        public long retryBiddingNo { set; get; }

        public GameTradeMarketBuyInfo()
        {
            this.nationCode = 0;
            this.worldNo = 0;
            this.userNo = 0L;
            this.buyKeyType = 0;
            this.buyMainKey = 0;
            this.buySubKey = 0;
            this.buyPrice = 0L;
            this.buyCount = 0L;
            this.buyChooseKey = 0;
            this.isWebAccess = false;
            this.otp = string.Empty;
            this.retryBiddingNo = 0L;
        }
    }
}
