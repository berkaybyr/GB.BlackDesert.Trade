// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.EnchantInfoModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Models;

namespace BlackDesert.TradeMarket.Lib.Models.Trade
{
    public class EnchantInfoModel : CommonResult
    {
        public long enchantNeedCount { get; set; }

        public int keyType { get; set; }

        public int mainKey { get; set; }

        public int subKey { get; set; }

        public int chooseKey { get; set; }

        public long pricePerOne { get; set; }

        public long count { get; set; }

        public long totalTradeCount { get; set; }
    }
}
