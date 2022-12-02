// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.ItemCountInfo
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

namespace GB.BlackDesert.Trade.Web.Models
{
    public class ItemCountInfo
    {
        public int itemKey { get; set; }

        public long count { get; set; }

        public long totalCount { get; set; }

        public ItemCountInfo()
        {
            this.itemKey = 0;
            this.count = 0L;
            this.totalCount = 0L;
        }
    }
}
