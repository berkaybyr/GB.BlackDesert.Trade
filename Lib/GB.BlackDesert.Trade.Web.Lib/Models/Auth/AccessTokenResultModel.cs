// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.Auth.AccessTokenResultModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace BlackDesert.TradeMarket.Lib.Models.Auth
{
    public class AccessTokenResultModel
    {
        public string access_token { get; set; }

        public string token_type { get; set; }

        public string refresh_token { get; set; }

        public long expires_in { get; set; }

        public string scope { get; set; }

        public string returnUrl { get; set; }
    }
}
