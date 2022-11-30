// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Util.LogMessageModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Models;
using System.Collections.Generic;

namespace GB.BlackDesert.Trade.Web.Lib.Util
{
    public class LogMessageModel
    {
        public string HttpMethod { get; set; }

        public string RequestUrl { get; set; }

        public Dictionary<string, string> Headers { get; set; }

        public Dictionary<string, string> FormData { get; set; }

        public string Ip { get; set; }

        public AuthenticationInfo AuthInfo { get; set; }

        public object LogMessage { get; set; }

        public string LogException { get; set; }

        public string ProjectName { get; set; }

        public string ServiceType { get; set; }

        public string Branches { get; set; }

        public string PlatformIndex { get; set; }
    }
}
