// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.ViewUserAuthResultModel
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

using GB.BlackDesert.Trade.Web.Lib.Models;

namespace BlackDesert.TradeMarket.Lib.Models.Game
{
    public class ViewUserAuthResultModel
    {
        public int nationCode { set; get; }

        public int worldNo { set; get; }

        public long userNo { set; get; }

        public CommonResult result { set; get; }

        public ViewUserAuthResultModel()
        {
            this.nationCode = 0;
            this.worldNo = 0;
            this.userNo = 0L;
            this.result = new CommonResult();
        }
    }
}
