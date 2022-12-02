// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Util.CacheService
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using System;
using System.Runtime.Caching;

namespace GB.BlackDesert.Trade.Web.Lib.Util
{
    public class CacheService
    {
        public T Get<T>(string cacheKey, int durationInSec, Func<T> getItemCached) where T : class
        {
            if (!(MemoryCache.Default.Get(cacheKey, (string)null) is T obj))
            {
                obj = getItemCached();
                if ((object)obj != null)
                    MemoryCache.Default.Add(cacheKey, (object)obj, (DateTimeOffset)CommonModule.GetCustomTime().AddSeconds((double)durationInSec));
            }
            return obj;
        }
    }
}
