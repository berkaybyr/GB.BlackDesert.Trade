// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.UserInfomationModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;

namespace BlackDesert.TradeMarket.Lib.Models
{
    public class UserInfomationModel
    {
        public string _userNickName { set; get; }

        public int _nationCode { set; get; }

        public int _worldNo { set; get; }

        public long _userNo { set; get; }

        public DateTime _valuePackageExpiration { get; set; }

        public bool _isWebAccess { set; get; }

        public bool _secondPwdPass { get; set; }

        public DateTime _addWeightBuffExpiration { get; set; }

        public bool _isReturn { get; set; }

        public UserInfomationModel()
        {
            this._nationCode = 0;
            this._worldNo = 0;
            this._userNickName = string.Empty;
            this._valuePackageExpiration = DateTime.MinValue;
            this._addWeightBuffExpiration = DateTime.MinValue;
            this._isWebAccess = false;
            this._secondPwdPass = false;
            this._isReturn = false;
        }
    }
}
