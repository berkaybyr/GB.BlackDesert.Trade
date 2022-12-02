// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.ViewUserAuthModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

namespace GB.BlackDesert.Trade.Web.Models
{
    public class ViewUserAuthModel
    {
        public long userNo { set; get; }

        public string certifiedKey { set; get; }

        public int type { set; get; }

        public ViewUserAuthModel()
        {
            this.userNo = 0L;
            this.certifiedKey = string.Empty;
            this.type = 0;
        }
    }
}
