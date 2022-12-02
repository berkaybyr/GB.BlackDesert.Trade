// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.ListUserBiddingBuyModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

namespace BlackDesert.TradeMarket.Lib.Models.Trade
{
    public class ListUserBiddingBuyModel : ItemBaseInfoModel
    {
        public long buyNo { get; set; }

        public long leftCount { get; set; }

        public long boughtCount { get; set; }

        public long pricePerOne { get; set; }

        public long addEnchantPrice { get; set; }

        public long registerMoneyCount { get; set; }
    }
}
