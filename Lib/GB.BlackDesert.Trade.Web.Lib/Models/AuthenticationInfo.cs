// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.AuthenticationInfo
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;

namespace GB.BlackDesert.Trade.Web.Lib.Models
{
    public class AuthenticationInfo
    {
        public long accountNo { get; set; }

        public string certifiedKey { get; set; }

        public string LoginIP { get; set; }

        public string publisherID { get; set; }

        public UserInfomationModel userInfoModel { get; set; }

        private DateTime loginTime { get; set; }

        private DateTime authExpiration { get; set; }

        public DateTime LoginTime
        {
            get => this.loginTime;
            set => this.loginTime = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

        public DateTime AuthExpiration
        {
            get => this.authExpiration;
            set => this.authExpiration = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

        public AuthenticationInfo() => this.userInfoModel = new UserInfomationModel();
    }
}
