// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.TradeMarketListUserBiddingModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Models;

namespace GB.BlackDesert.Trade.Web.Api.Models
{
    public class TradeMarketListUserBiddingModel : CommonResult
    {
        public List<ListUserBiddingBuyModel> buyList { get; set; }

        public List<ListUserBiddingSellModel> sellList { get; set; }

        public TradeMarketListUserBiddingModel()
        {
            this.buyList = new List<ListUserBiddingBuyModel>();
            this.sellList = new List<ListUserBiddingSellModel>();
        }
    }
}
