// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.WorldMarketWaitListModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Models;

namespace GB.BlackDesert.Trade.Web.Api.Models
{
    public class WorldMarketWaitListModel : CommonResult
    {
        public List<WorldMarketWaitInfoModel> _waitList { get; set; }

        public WorldMarketWaitListModel() => this._waitList = new List<WorldMarketWaitInfoModel>();
    }
}
