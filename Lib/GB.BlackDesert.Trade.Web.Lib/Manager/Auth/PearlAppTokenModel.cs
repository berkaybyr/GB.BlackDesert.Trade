// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.Auth.PearlAppTokenModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace GB.BlackDesert.Trade.Web.Lib.Manager.Auth
{
    public class PearlAppTokenModel
    {
        public string _accessToken { get; set; }

        public string _refreshToken { get; set; }

        public string _expireDate { get; set; }

        public PearAppSessionInfoModel _pearAppSessionInfoModel { get; set; }

        public long _userNo { get; set; }

        public PearlAppTokenModel()
        {
            this._accessToken = string.Empty;
            this._refreshToken = string.Empty;
            this._userNo = 0L;
            this._pearAppSessionInfoModel = new PearAppSessionInfoModel();
        }
    }
}
