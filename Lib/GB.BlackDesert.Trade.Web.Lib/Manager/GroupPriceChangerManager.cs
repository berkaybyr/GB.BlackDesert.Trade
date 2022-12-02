// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.GroupPriceChangerManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackDesert.TradeMarket.Lib.Manager
{
    public class GroupPriceChangerManager
    {
        private static object _locker = new object();
        private static volatile GroupPriceChangerManager _singleton;
        private Dictionary<long, List<GroupPriceChanger>> _priceData;

        public IEnumerable<GroupPriceChanger> changerList => this._priceData.SelectMany<KeyValuePair<long, List<GroupPriceChanger>>, GroupPriceChanger>((Func<KeyValuePair<long, List<GroupPriceChanger>>, IEnumerable<GroupPriceChanger>>)(price => (IEnumerable<GroupPriceChanger>)price.Value));

        public static GroupPriceChangerManager This()
        {
            if (GroupPriceChangerManager._singleton == null)
            {
                lock (GroupPriceChangerManager._locker)
                {
                    if (GroupPriceChangerManager._singleton == null)
                        GroupPriceChangerManager._singleton = new GroupPriceChangerManager();
                }
            }
            return GroupPriceChangerManager._singleton;
        }

        private GroupPriceChangerManager() => this.clear();

        public void clear() => this._priceData = new Dictionary<long, List<GroupPriceChanger>>();

        public void add(
          uspListWorldMarketAccumulateTrade_Result record,
          long nextPrice,
          long nextGraphPrice)
        {
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(record.C_mainKey, record.C_subKey);
            if (!this._priceData.ContainsKey(info._marketPriceGroup))
                this._priceData.Add(info._marketPriceGroup, new List<GroupPriceChanger>());
            this._priceData[info._marketPriceGroup].Add(new GroupPriceChanger(record, nextPrice, nextGraphPrice));
        }

        public void update() => this._priceData.Keys.ToList<long>().ForEach((Action<long>)(group =>
        {
            List<GroupPriceChanger> source1 = this._priceData[group];
            double num = source1.Max<GroupPriceChanger>((Func<GroupPriceChanger, double>)(groupPriceChanger => groupPriceChanger.priceRatio));
            bool flag = false;
            foreach (GroupPriceChanger groupPriceChanger in source1)
            {
                if (0.05 < Math.Abs(num - groupPriceChanger.priceRatio))
                {
                    groupPriceChanger.nextPriceRatio = num;
                    flag = true;
                }
            }
            if (flag)
                return;
            IEnumerable<double> source2 = source1.Select<GroupPriceChanger, double>((Func<GroupPriceChanger, double>)(groupPriceChanger => groupPriceChanger.nextPriceRatio - groupPriceChanger.priceRatio)).Where<double>((Func<double, bool>)(ratioDiff => 0.0 != ratioDiff));
            if (!source2.Any<double>())
                return;
            double validDiffRatioAverage = source2.Average();
            source1.ForEach((Action<GroupPriceChanger>)(groupPriceChanger => groupPriceChanger.nextPriceRatio = groupPriceChanger.priceRatio + validDiffRatioAverage));
        }));
    }
}
