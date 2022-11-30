// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.WorldMarketSubOneModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Models;

namespace GB.BlackDesert.Trade.Web.Api.Models
{
    public class WorldMarketSubOneModel : CommonResult
    {
        public int enchantGroup { get; set; }

        public int enchantMaxGroup { get; set; }

        public long pricePerOneValue { get; set; }

        public long countValue { get; set; }

        public long sellMaxCount { get; set; }

        public long buyMaxCount { get; set; }

        public string name { get; set; }

        public int grade { get; set; }

        public long minPrice { get; set; }

        public long maxPrice { get; set; }
    }
}
