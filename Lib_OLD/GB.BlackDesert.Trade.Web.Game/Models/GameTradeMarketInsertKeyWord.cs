// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.GameTradeMarketInsertKeyWord
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

namespace GB.BlackDesert.Trade.Web.Game.Models
{
    public class GameTradeMarketInsertKeyWord
    {
        public long userNo { set; get; }

        public string certifiedKey { set; get; }

        public int keyType { set; get; }

        public string keyWord { set; get; }

        public GameTradeMarketInsertKeyWord()
        {
            this.userNo = 0L;
            this.certifiedKey = string.Empty;
            this.keyType = 0;
            this.keyWord = string.Empty;
        }
    }
}
