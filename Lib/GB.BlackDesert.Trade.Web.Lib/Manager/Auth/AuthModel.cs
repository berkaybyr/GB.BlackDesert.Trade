// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.Auth.AuthModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;

namespace GB.BlackDesert.Trade.Web.Lib.Manager.Auth
{
    public class AuthModel
    {
        public string _mainEmail { get; set; }

        public string _email { get; set; }

        public long _accountNo { get; set; }

        public string _nationCode { get; set; }

        public long _personNo { get; set; }

        public string _ciCode { get; set; }

        public string _name { get; set; }

        public string _birthday { get; set; }

        public string _mobile { get; set; }

        public byte _loginType { get; set; }

        public DateTime _passwordChangeDate { get; set; }

        public DateTime _authExpiration { get; set; }

        public bool _isSns { get; set; }

        public bool _isOtp { get; set; }

        public bool _isOtpAuth { get; set; }

        public string _profileImageUrl { get; set; }

        public string _webNickName { get; set; }

        public AuthModel() => this._authExpiration = new DateTime();
    }
}
