// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.WorldMarketWaitInfoModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

namespace GB.BlackDesert.Trade.Web.Api.Models
{
    public class WorldMarketWaitInfoModel : ItemBaseInfoModel
    {
        public long _pricePerOne { get; set; }

        public long _waitEndTime { get; set; }

        public WorldMarketWaitInfoModel()
        {
            this._pricePerOne = 0L;
            this._waitEndTime = 0L;
        }
    }
}
