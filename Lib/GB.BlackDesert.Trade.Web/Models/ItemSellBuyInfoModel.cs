// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.ItemSellBuyInfoModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Models;
using System.Collections.Generic;

namespace GB.BlackDesert.Trade.Web.Models
{
    public class ItemSellBuyInfoModel : CommonResult
    {
        public List<long> priceList { get; set; }

        public List<BiddingInfoModel> marketConditionList { get; set; }

        public long basePrice { get; set; }

        public int enchantGroup { get; set; }

        public int enchantMaxGroup { get; set; }

        public int enchantMaterialKey { get; set; }

        public long enchantMaterialPrice { get; set; }

        public long enchantNeedCount { get; set; }

        public long maxRegisterForWorldMarket { get; set; }

        public long countValue { get; set; }

        public long sellMaxCount { get; set; }

        public long buyMaxCount { get; set; }

        public bool isWaitItem { get; set; }

        public ItemSellBuyInfoModel() => this.priceList = new List<long>();
    }
}
