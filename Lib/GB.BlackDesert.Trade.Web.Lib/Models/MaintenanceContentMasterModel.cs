// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.MaintenanceContentMasterModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;

namespace BlackDesert.TradeMarket.Lib.Models
{
    public class MaintenanceContentMasterModel
    {
        public int _groupContentsNo { get; set; }

        public long _shutdownKey { get; set; }

        public byte _isDisplay { get; set; }

        public byte _isDelete { get; set; }

        public string _name { get; set; }

        public DateTime _maintenanceStartDate { get; set; }

        public DateTime _maintenanceExpireDate { get; set; }
    }
}
