// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.MyWalletListModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Models;

namespace BlackDesert.TradeMarket.Lib.Models.Trade
{
    public class MyWalletListModel : CommonResult
    {
        public List<MyWalletInfoModel> myWalletList { get; set; }

        public long totalWeight { get; set; }

        public long maxWeight { get; set; }

        public bool useValuePackage { get; set; }

        public double feeRate { get; set; }

        public long addWeight { get; set; }

        public bool useAddWeightBuff { get; set; }

        public int ringBuffCount { get; set; }

        public int lastOtpConfirmTime { get; set; }
    }
}
