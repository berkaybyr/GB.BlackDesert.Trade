// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.Models.GameTradeMarketState
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

using GB.BlackDesert.Trade.Web.Lib.Models;

namespace BlackDesert.TradeMarket.Lib.Models.Process
{
    public class GameTradeMarketState
    {
        public int state { set; get; }

        public CommonResult result { set; get; }

        public GameTradeMarketState()
        {
            this.state = 0;
            this.result = new CommonResult();
        }
    }
}
