// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.CommonModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace BlackDesert.TradeMarket.Lib.Models
{
    public class CommonModel
    {
        public class TradeMarketUserLogInfo
        {
            public int nationCode { get; set; }

            public int serverNo { get; set; }

            public long userNo { get; set; }

            public TradeMarketUserLogInfo()
            {
                this.nationCode = 0;
                this.serverNo = 0;
                this.userNo = 0L;
            }
        }

        public class TradeMarketItemLogInfo
        {
            public int keyType1 { get; set; }

            public int itemKey1 { get; set; }

            public int enchantLevel1 { get; set; }

            public long count1 { get; set; }

            public long beforeCount1 { get; set; }

            public long afterCount1 { get; set; }

            public int keyType2 { get; set; }

            public int itemKey2 { get; set; }

            public int enchantLevel2 { get; set; }

            public long count2 { get; set; }

            public long beforeCount2 { get; set; }

            public long afterCount2 { get; set; }

            public TradeMarketItemLogInfo()
            {
                this.keyType1 = 0;
                this.itemKey1 = 0;
                this.enchantLevel1 = 0;
                this.count1 = 0L;
                this.beforeCount1 = 0L;
                this.afterCount1 = 0L;
                this.keyType2 = 0;
                this.itemKey2 = 0;
                this.enchantLevel2 = 0;
                this.count2 = 0L;
                this.beforeCount2 = 0L;
                this.afterCount2 = 0L;
            }
        }
    }
}
