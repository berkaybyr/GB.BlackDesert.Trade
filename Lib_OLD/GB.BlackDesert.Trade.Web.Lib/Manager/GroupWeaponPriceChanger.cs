// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.GroupWeaponPriceChanger
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Models;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public class GroupWeaponPriceChanger
    {
        public readonly uspListWorldMarketAccumulateTrade_Result _record;
        public readonly TradeMarketItemInfo _itemInfo;

        public GroupWeaponPriceChanger(
          uspListWorldMarketAccumulateTrade_Result record,
          TradeMarketItemInfo itemInfo)
        {
            this._record = record;
            this._itemInfo = itemInfo;
        }
    }
}
