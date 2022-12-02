// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.Auth.GetSessionInfoResultModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Models;
using System;

namespace BlackDesert.TradeMarket.Lib.Manager.Auth
{
    public class GetSessionInfoResultModel
    {
        public string _sessionId { get; set; }

        public long _accountNo { get; set; }

        public string _accessToken { get; set; }

        public string _refreshToken { get; set; }

        public string _expireDate { get; set; }

        public DateTime _sessionSearchTime { get; set; }

        public string _authTicket { get; set; }

        public long _ipCheckTime { get; set; }

        public bool _isPearlApp { get; set; }

        public UserInfomationModel userInfoModel { get; set; }
    }
}
