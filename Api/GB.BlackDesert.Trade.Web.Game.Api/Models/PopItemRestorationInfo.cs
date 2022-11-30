// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.PopItemRestorationInfo
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

namespace GB.BlackDesert.Trade.Web.Game.Api.Models
{
    public class PopItemRestorationInfo
    {
        public long userNo { set; get; }

        public string certifiedKey { get; set; }

        public long payload { set; get; }

        public int mainKey { set; get; }

        public int subKey { set; get; }

        public long itemCount { set; get; }

        public bool isSealed { set; get; }

        public long param0 { set; get; }

        public long param1 { set; get; }

        public long param2 { set; get; }

        public long param3 { set; get; }

        public long param4 { set; get; }

        public PopItemRestorationInfo()
        {
            this.userNo = 0L;
            this.certifiedKey = string.Empty;
            this.payload = 0L;
            this.mainKey = 0;
            this.subKey = 0;
            this.itemCount = 0L;
            this.isSealed = false;
            this.param0 = 0L;
            this.param1 = 0L;
            this.param2 = 0L;
            this.param3 = 0L;
            this.param4 = 0L;
        }
    }
}
