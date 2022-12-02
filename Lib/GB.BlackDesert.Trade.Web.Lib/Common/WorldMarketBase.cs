// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Common.WorldMarketBase
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;

namespace BlackDesert.TradeMarket.Lib.Common
{
    public static class WorldMarketBase
    {
        public static int checkValidCount<T, N>(T pricePerOne, N wantedCount)
          where T : IComparable
          where N : IComparable
        {
            TypeCode typeCode = Type.GetTypeCode(typeof(N));
            switch (typeCode)
            {
                case TypeCode.Int32:
                    int num1 = 1;
                    if (wantedCount.CompareTo((object)num1) < 0)
                        return -1;
                    break;
                case TypeCode.Int64:
                    long num2 = 1;
                    if (wantedCount.CompareTo((object)num2) < 0)
                        return -1;
                    break;
                default:
                    return -1;
            }
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Int32:
                    int num3 = 1;
                    if (pricePerOne.CompareTo((object)num3) < 0)
                        return -1;
                    if (TypeCode.Int64 == typeCode)
                    {
                        long num4 = long.MaxValue / (long)((object)pricePerOne as int?).Value;
                        if (wantedCount.CompareTo((object)num4) >= 0)
                            return -1;
                        break;
                    }
                    if (TypeCode.Int32 == typeCode)
                    {
                        int num5 = int.MaxValue / ((object)pricePerOne as int?).Value;
                        if (wantedCount.CompareTo((object)num5) >= 0)
                            return -1;
                        break;
                    }
                    break;
                case TypeCode.Int64:
                    long num6 = 1;
                    if (pricePerOne.CompareTo((object)num6) < 0)
                        return -1;
                    long num7 = long.MaxValue / ((object)pricePerOne as long?).Value;
                    if (TypeCode.Int32 == typeCode)
                    {
                        long num8 = (long)((object)wantedCount as int?).Value;
                        if (wantedCount.CompareTo((object)num8) >= 0)
                            return -1;
                        break;
                    }
                    if (TypeCode.Int64 == typeCode && wantedCount.CompareTo((object)num7) >= 0)
                        return -1;
                    break;
                default:
                    return -1;
            }
            return 0;
        }
    }
}
