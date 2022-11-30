// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.waitItemModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.DB;

namespace GB.BlackDesert.Trade.Web.Lib.Models
{
    public class waitItemModel
    {
        public long waitNo { set; get; }

        public int nationCode { set; get; }

        public int worldNo { set; get; }

        public long userNo { set; get; }

        public int sellKeyType { set; get; }

        public int sellMainKey { set; get; }

        public int sellSubKey { set; get; }

        public long sellPrice { set; get; }

        public long sellCount { set; get; }

        public int sellChooseKey { set; get; }

        public bool isSealed { set; get; }

        public bool isRingBuff { set; get; }

        public waitItemModel()
        {
            this.waitNo = 0L;
            this.nationCode = 0;
            this.worldNo = 0;
            this.userNo = 0L;
            this.sellKeyType = 0;
            this.sellMainKey = 0;
            this.sellSubKey = 0;
            this.sellPrice = 0L;
            this.sellCount = 0L;
            this.sellChooseKey = 0;
            this.isSealed = false;
            this.isRingBuff = false;
        }

        public waitItemModel(uspListWaitBiddingSell_Result info)
        {
            this.waitNo = info.C_waitNo;
            this.nationCode = info.C_nationCode;
            this.worldNo = info.C_serverNo;
            this.userNo = info.C_userNo;
            this.sellKeyType = info.C_keyType;
            this.sellMainKey = info.C_mainKey;
            this.sellSubKey = info.C_subKey;
            this.sellPrice = info.C_pricePerOne;
            this.sellCount = info.C_leftCount;
            this.sellChooseKey = info.C_chooseSubKey;
            this.isSealed = info.C_isSealed;
            this.isRingBuff = info.C_isRingBuff;
        }

        public string toString() => string.Format("waitNo:{0}, ", (object)this.waitNo) + string.Format("sellKeyType:{0},", (object)this.sellKeyType) + string.Format("sellMainKey:{0},", (object)this.sellMainKey) + string.Format("sellSubKey:{0},", (object)this.sellSubKey) + string.Format("isSealed:{0},", (object)this.isSealed) + string.Format("sellChooseKey:{0},", (object)this.sellChooseKey) + string.Format("sellCount:{0},", (object)this.sellCount) + string.Format("sellPrice:{0},", (object)this.sellPrice) + string.Format("isRingBuff:{0},", (object)this.isRingBuff) + string.Format("nationCode:{0},", (object)this.nationCode) + string.Format("worldNo:{0},", (object)this.worldNo) + string.Format("userNo:{0}", (object)this.userNo);
    }
}
