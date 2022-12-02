// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.MarketGroupInfo
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;
using System.Collections.Generic;

namespace GB.BlackDesert.Trade.Web.Lib.Models
{
    public class MarketGroupInfo
    {
        public DateTime _lastUpdateTime;
        public Dictionary<int, MarketValue> _infoList;

        public MarketGroupInfo()
        {
            this._lastUpdateTime = new DateTime();
            this._infoList = new Dictionary<int, MarketValue>();
        }
    }
}
