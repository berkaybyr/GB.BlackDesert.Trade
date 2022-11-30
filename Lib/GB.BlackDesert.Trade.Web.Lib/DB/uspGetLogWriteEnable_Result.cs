// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.DB.uspGetLogWriteEnable_Result
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace GB.BlackDesert.Trade.Web.Lib.DB
{
    public class uspGetLogWriteEnable_Result
    {
        public bool C_writeDebugLog { get; set; }

        public bool C_writeInfoLog { get; set; }

        public bool C_writeWarringLog { get; set; }

        public bool C_writeErrorLog { get; set; }

        public bool C_writeFatalLog { get; set; }
    }
}
