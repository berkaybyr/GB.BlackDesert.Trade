// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Util.PushUtil
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GB.BlackDesert.Trade.Web.Lib.Util
{
    public static class PushUtil
    {
        public static string EnableAppPushFlag => new CacheService().Get<string>("EnablePushFlag", 600, (Func<string>)(() =>
        {
            bool? nullable = new bool?();
            string enableAppPushFlag = "false";
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                    nullable = ((IEnumerable<bool?>)tradeWebDb.uspGetAppPushEnable()).FirstOrDefault<bool?>();
                if (nullable.Equals((object)true))
                    enableAppPushFlag = "true";
            }
            catch
            {
                enableAppPushFlag = "false";
            }
            finally
            {
                if (enableAppPushFlag == null)
                    enableAppPushFlag = "false";
            }
            return enableAppPushFlag;
        }));
    }
}
