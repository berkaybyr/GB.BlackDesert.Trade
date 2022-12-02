// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Util.CacheService
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace BlackDesert.TradeMarket.Lib.Util
{
    public static class CacheService
    {
        private static readonly IMemoryCache _cache = new MemoryCache(new MemoryCacheOptions());
        public static T Get<T>(string cacheKey, int durationInSec, Func<T> getItemCached) where T : class
        {
            var obj = getItemCached();
            if (_cache.Get(cacheKey) is not null)
            {
                if ((object)obj != null)
                    _cache.Set(cacheKey, (object)obj, (DateTimeOffset)CommonModule.GetCustomTime().AddSeconds((double)durationInSec));
            }
            return obj;
        }
    }
}
