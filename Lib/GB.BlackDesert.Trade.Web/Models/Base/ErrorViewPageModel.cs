// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.Base.ErrorViewPageModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

namespace GB.BlackDesert.Trade.Web.Models.Base
{
    public class ErrorViewPageModel
    {
        public string type { get; set; }

        public string errorMessage { get; set; }

        public ErrorViewPageModel()
        {
            this.type = string.Empty;
            this.errorMessage = string.Empty;
        }
    }
}
