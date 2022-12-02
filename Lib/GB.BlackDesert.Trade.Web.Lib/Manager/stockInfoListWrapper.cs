// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.stockInfoListWrapper
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Models;
using System.Collections;
using System.Collections.Generic;

namespace BlackDesert.TradeMarket.Lib.Manager
{
    public class stockInfoListWrapper :
    IEnumerable<KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo>>,
    IEnumerable
    {
        private readonly Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> _stockInfoList;

        public stockInfoListWrapper(
          Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> list)
        {
            this._stockInfoList = list;
        }

        public IEnumerator<KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo>> GetEnumerator() => (IEnumerator<KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo>>)this._stockInfoList.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)this._stockInfoList.GetEnumerator();

        public Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> getXXX() => this._stockInfoList;
    }
}
