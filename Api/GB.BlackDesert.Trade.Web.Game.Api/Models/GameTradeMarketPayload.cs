// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.GameTradeMarketPayload
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

using GB.BlackDesert.Trade.Web.Lib.Models;

namespace GB.BlackDesert.Trade.Web.Game.Api.Models
{
    public class GameTradeMarketPayload
    {
        public long payload { set; get; }

        public CommonResult result { set; get; }

        public GameTradeMarketPayload()
        {
            this.payload = 0L;
            this.result = new CommonResult();
        }
    }
}
