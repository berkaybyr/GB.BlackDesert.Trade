// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.TradeMarketListUserBidding
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Sql;

namespace BlackDesert.TradeMarket.Lib.Models.Trade
{
    public class TradeMarketListUserBidding
    {
        public List<uspListUserBiddingBuy_Result> buylist { get; set; }

        public List<uspListUserBiddingSell_Result> selllist { get; set; }
    }
}
