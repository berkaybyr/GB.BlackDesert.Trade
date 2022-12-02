// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.TickCountCommon
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;

namespace GB.BlackDesert.Trade.Web.Lib.Models
{
    public class TickCountCommon
    {
        public static void enchantLevelCalc(
          long currentPrice,
          int enchantLevel,
          ref long beforeEnchantPrice)
        {
            beforeEnchantPrice = 0L;
            if (0 >= enchantLevel)
                return;
            beforeEnchantPrice = currentPrice;
        }

        public static void checkAndUpdateBeforePrice(long beforeEnchantPrice, ref long newPrice)
        {
            if (0L >= beforeEnchantPrice || beforeEnchantPrice >= newPrice)
                return;
            newPrice = beforeEnchantPrice;
        }

        public static void fluctuationCalc(
          long newPrice,
          long currentPrice,
          ref FluctuationType fluctuationType,
          ref long fluctuationPrice)
        {
            long num1 = (long)((double)currentPrice * (1.0 - WorldMarketOptionManager.This().BiddingRatio * 0.75));
            long num2 = (long)((double)currentPrice * (1.0 + WorldMarketOptionManager.This().BiddingRatio * 0.75));
            if (newPrice < num1)
            {
                fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Down;
                fluctuationPrice = currentPrice - newPrice;
            }
            else
            {
                if (num2 >= newPrice)
                    return;
                fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Up;
                fluctuationPrice = newPrice - currentPrice;
            }
        }
    }
}
