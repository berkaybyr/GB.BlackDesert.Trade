// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.HttpRequestResult
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace BlackDesert.TradeMarket.Lib.Models
{
    public class HttpRequestResult
    {
        public int _resultCode { get; set; }

        public string _resultMsg { get; set; }

        public string _resultData { get; set; }

        public HttpRequestResult()
        {
            this._resultCode = 0;
            this._resultMsg = string.Empty;
            this._resultData = string.Empty;
        }
    }
}
