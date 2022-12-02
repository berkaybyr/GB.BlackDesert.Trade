// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.GameTradeMarketRegisterPersonalTradeAuth
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

namespace GB.BlackDesert.Trade.Web.Game.Models
{
    public class GameTradeMarketRegisterPersonalTradeAuth
    {
        public int keyType { set; get; }

        public int mainKey { set; get; }

        public int subKey { set; get; }

        public long count { set; get; }

        public long fromUserNo { set; get; }

        public int fromCertifiedKey { set; get; }

        public int toNationCode { set; get; }

        public int toServerNo { set; get; }

        public string toUserNickName { set; get; }

        public GameTradeMarketRegisterPersonalTradeAuth()
        {
            this.keyType = 0;
            this.mainKey = 0;
            this.subKey = 0;
            this.count = 0L;
            this.fromUserNo = 0L;
            this.toNationCode = 0;
            this.toServerNo = 0;
            this.toUserNickName = string.Empty;
        }
    }
}
