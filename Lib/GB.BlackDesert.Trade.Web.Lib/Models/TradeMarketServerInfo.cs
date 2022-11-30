// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.TradeMarketServerInfo
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using System.Collections.Generic;

namespace GB.BlackDesert.Trade.Web.Lib.Models
{
    public class TradeMarketServerInfo
    {
        public string _ip;
        public List<int> _allowMainGroupNo;
        public bool _setTimer;
        public ServerType _serverType;
        public bool _isInitHistory;

        public TradeMarketServerInfo()
        {
            this._ip = "";
            this._allowMainGroupNo = new List<int>();
            this._allowMainGroupNo.Clear();
            this._setTimer = false;
            this._serverType = ServerType.eCount;
            this._isInitHistory = false;
        }

        public bool isValid() => !this._ip.Equals("");
    }
}
