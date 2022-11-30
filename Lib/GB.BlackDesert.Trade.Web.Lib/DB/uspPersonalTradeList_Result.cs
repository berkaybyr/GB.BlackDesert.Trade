// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.DB.uspPersonalTradeList_Result
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace GB.BlackDesert.Trade.Web.Lib.DB
{
    public class uspPersonalTradeList_Result
    {
        public long C_marketNo { get; set; }

        public int C_mainKey { get; set; }

        public int C_subKey { get; set; }

        public long C_pricePerOne { get; set; }

        public long C_count { get; set; }

        public int C_toNationCode { get; set; }

        public int C_toServerNo { get; set; }

        public long C_toUserNo { get; set; }

        public string C_userNickName { get; set; }
    }
}
