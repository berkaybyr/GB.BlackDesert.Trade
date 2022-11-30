// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.ListUserBiddingSellModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

namespace GB.BlackDesert.Trade.Web.Api.Models
{
    public class ListUserBiddingSellModel : ItemBaseInfoModel
    {
        public long sellNo { get; set; }

        public long leftCount { get; set; }

        public long pricePerOne { get; set; }

        public long soldCount { get; set; }

        public long accumulateMoneyCount { get; set; }

        public bool isSealed { get; set; }

        public long enchantNeedCount { get; set; }

        public long enchantMaterialPrice { get; set; }

        public bool ringBuff { get; set; }
    }
}
