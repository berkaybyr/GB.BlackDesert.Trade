﻿// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.MarketSearchResultModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Models;
using System.Collections.Generic;

namespace GB.BlackDesert.Trade.Web.Models
{
    public class MarketSearchResultModel : CommonResult
    {
        public List<MarketSearchInfoModel> list { get; set; }

        public MarketSearchResultModel() => this.list = new List<MarketSearchInfoModel>();
    }
}
