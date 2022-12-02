// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.ItemBaseInfoModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

namespace BlackDesert.TradeMarket.Lib.Models.Trade
{
    public class ItemBaseInfoModel
    {
        public int keyType { get; set; }

        public int mainKey { get; set; }

        public int subKey { get; set; }

        public long count { get; set; }

        public string name { get; set; }

        public int grade { get; set; }

        public int mainCategory { get; set; }

        public int subCategory { get; set; }

        public int chooseKey { get; set; }

        public ItemBaseInfoModel()
        {
            this.keyType = 0;
            this.mainKey = 0;
            this.subKey = 0;
            this.count = 0L;
            this.name = string.Empty;
            this.grade = 0;
            this.mainCategory = 0;
            this.subCategory = 0;
            this.chooseKey = 0;
        }
    }
}
