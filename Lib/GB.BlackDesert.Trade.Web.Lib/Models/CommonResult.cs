// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.CommonResult
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace BlackDesert.TradeMarket.Lib.Models
{
    public class CommonResult
    {
        public int resultCode { get; set; }

        public string resultMsg { get; set; }

        public bool IsSuccess { get => resultCode == 0; }
        public CommonResult()
        {
            this.resultCode = 0;
            this.resultMsg = string.Empty;
        }
    }
}
