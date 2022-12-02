// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.MaintenanceRequestModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.Collections.Generic;

namespace BlackDesert.TradeMarket.Lib.Models
{
    public class MaintenanceRequestModel : MaintenanceContentMasterModel
    {
        public string _setType { get; set; }

        public List<MaintensnceDetailModel> _maintenanceInfoList { get; set; }
    }
}
