// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.Auth.Oauth2CallBackModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.ComponentModel.DataAnnotations;

namespace GB.BlackDesert.Trade.Web.Lib.Manager.Auth
{
    public class Oauth2CallBackModel
    {
        [Required]
        public string code { get; set; }

        [Required]
        public string state { get; set; }
    }
}
