// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.ViewUserAuthResultModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Models;

namespace BlackDesert.TradeMarket.Lib.Models.Trade
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
