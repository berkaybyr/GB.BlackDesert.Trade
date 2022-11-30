// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.MyWalletInfoModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

namespace GB.BlackDesert.Trade.Web.Api.Models
{
    public class MyWalletInfoModel : ItemBaseInfoModel
    {
        public int nationCode { get; set; }

        public int serverNo { get; set; }

        public long userNo { get; set; }

        public bool isSealed { get; set; }
    }
}
