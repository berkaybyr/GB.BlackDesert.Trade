// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.GetWorldMarketListModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

namespace GB.BlackDesert.Trade.Web.Models
{
    public class GetWorldMarketListModel
    {
        public int keyType { get; set; }

        public int mainCategory { get; set; }

        public int subCategory { get; set; }

        public GetWorldMarketListModel()
        {
            this.keyType = 2;
            this.mainCategory = 0;
            this.subCategory = 0;
        }
    }
}
