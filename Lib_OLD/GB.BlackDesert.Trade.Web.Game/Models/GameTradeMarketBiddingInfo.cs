// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.GameTradeMarketBiddingInfo
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

namespace GB.BlackDesert.Trade.Web.Game.Models
{
    public class GameTradeMarketBiddingInfo
    {
        public long biddingNo { set; get; }

        public int keyType { set; get; }

        public int mainKey { set; get; }

        public int subKey { set; get; }

        public bool isSealed { set; get; }

        public long count { set; get; }

        public int nationCode { set; get; }

        public int serverNo { set; get; }

        public long userNo { set; get; }

        public bool isWebAccess { set; get; }

        public GameTradeMarketBiddingInfo()
        {
            this.keyType = 0;
            this.mainKey = 0;
            this.subKey = 0;
            this.isSealed = false;
            this.count = 0L;
            this.nationCode = 0;
            this.serverNo = 0;
            this.userNo = 0L;
            this.isWebAccess = false;
        }
    }
}
