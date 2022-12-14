// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.GameTradeMarketInsertKeyWordInfo
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

namespace GB.BlackDesert.Trade.Web.Game.Models
{
    public class GameTradeMarketInsertKeyWordInfo
    {
        public int _nationCode { set; get; }

        public int _serverNo { set; get; }

        public long _userNo { set; get; }

        public int _keyType { set; get; }

        public string _keyWord { set; get; }

        public bool _isWebAccess { set; get; }

        public GameTradeMarketInsertKeyWordInfo()
        {
            this._nationCode = 0;
            this._serverNo = 0;
            this._userNo = 0L;
            this._keyType = 0;
            this._keyWord = string.Empty;
            this._isWebAccess = false;
        }

        public override string ToString() => string.Format("{0}, {1}, {2}, {3}, {4}, {5}", (object)this._nationCode, (object)this._serverNo, (object)this._userNo, (object)this._keyType, (object)this._keyWord, (object)this._isWebAccess);
    }
}
