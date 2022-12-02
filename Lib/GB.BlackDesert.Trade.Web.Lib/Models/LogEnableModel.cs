// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.LogEnableModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace BlackDesert.TradeMarket.Lib.Models
{
    public class LogEnableModel
    {
        public bool Debug { get; set; }

        public bool Info { get; set; }

        public bool Warring { get; set; }

        public bool Error { get; set; }

        public bool Fatal { get; set; }

        public LogEnableModel()
        {
            this.Debug = false;
            this.Info = false;
            this.Warring = true;
            this.Error = true;
            this.Fatal = true;
        }
    }
}
