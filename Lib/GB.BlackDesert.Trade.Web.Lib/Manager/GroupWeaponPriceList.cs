// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.GroupWeaponPriceList
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public class GroupWeaponPriceList
    {
        public List<GroupWeaponPriceChanger> _list;
        public long _passBiddingCount;
        public long _worldMarketPricePoint;
        public bool _isChange;
        public long _currentPrice;

        public GroupWeaponPriceList()
        {
            this._list = new List<GroupWeaponPriceChanger>();
            this._passBiddingCount = 0L;
            this._worldMarketPricePoint = 0L;
            this._isChange = false;
            this._currentPrice = 0L;
        }

        public void averageCurrentPrice() => this._currentPrice = (long)this._list.Average<GroupWeaponPriceChanger>((Func<GroupWeaponPriceChanger, long>)(info => info._record.C_pricePerOne));
    }
}
