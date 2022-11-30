// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.Models.GameTradeMarketDeleteKeyWordInfo
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

namespace GB.BlackDesert.Trade.Web.Process.Api.Models
{
    public class GameTradeMarketDeleteKeyWordInfo
    {
        public int _nationCode { set; get; }

        public int _serverNo { set; get; }

        public long _userNo { set; get; }

        public int _keyType { set; get; }

        public long _keyWordNo { set; get; }

        public bool _isWebAccess { set; get; }

        public GameTradeMarketDeleteKeyWordInfo()
        {
            this._nationCode = 0;
            this._serverNo = 0;
            this._userNo = 0L;
            this._keyType = 0;
            this._keyWordNo = 0L;
            this._isWebAccess = false;
        }

        public override string ToString() => string.Format("{0}, {1}, {2}, {3}, {4}, {5}", (object)this._nationCode, (object)this._serverNo, (object)this._userNo, (object)this._keyType, (object)this._keyWordNo, (object)this._isWebAccess);
    }
}
