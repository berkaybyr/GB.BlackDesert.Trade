// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.DB.uspGetShutDownInfo_Result
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;

namespace GB.BlackDesert.Trade.Web.Lib.DB
{
    public class uspGetShutDownInfo_Result
    {
        public string C_contentName { get; set; }

        public long C_shutDownKey { get; set; }

        public DateTime? C_contentStartDate { get; set; }

        public DateTime? C_contentEndDate { get; set; }

        public string C_mainMessage { get; set; }

        public string C_subMessage { get; set; }

        public string C_redirectUrl { get; set; }

        public string C_memo { get; set; }

        public bool C_isDisplay { get; set; }

        public bool C_isDelete { get; set; }

        public string C_cultureCode { get; set; }
    }
}
