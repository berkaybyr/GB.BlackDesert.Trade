﻿// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.Auth.GetGameAccessModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace BlackDesert.TradeMarket.Lib.Manager.Auth
{
    public class GetGameAccessModel
    {
        public long _accountNo { get; set; }

        public int _gameCode { get; set; }

        public string _startDateUnixTime { get; set; }

        public string _expireDateUnixTime { get; set; }
    }
}
