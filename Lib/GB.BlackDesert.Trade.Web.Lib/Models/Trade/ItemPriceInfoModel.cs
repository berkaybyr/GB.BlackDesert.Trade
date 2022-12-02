// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.ItemPriceInfoModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Models;

namespace BlackDesert.TradeMarket.Lib.Models.Trade
{
    public class ItemPriceInfoModel : CommonResult
    {
        public List<long> priceList { get; set; }

        public List<BiddingInfoModel> marketConditionList { get; set; }

        public ItemPriceInfoModel()
        {
            this.priceList = new List<long>();
            this.marketConditionList = new List<BiddingInfoModel>();
        }
    }
}
