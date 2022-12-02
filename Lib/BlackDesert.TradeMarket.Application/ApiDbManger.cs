using BlackDesert.TradeMarket.Db.TradeContext;
using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application
{
    public static class ApiDbManger
    {
        public static List<TblWorldMarketTickCount> uspListTickCount()
        {
            throw new NotImplementedException();
        }
        public static CommonResult uspSetUpdateTickCount(int key, int num)
        {
            throw new NotImplementedException();
        }

        public static CommonResult uspIncreaseTickCount(int mainGroup)
        {
            throw new NotImplementedException();
            // returns isUpdatePrice
        }
        public static List<TblWorldMarket> uspListWorldMarketAccumulateTrade(int mainGroup)
        {
            throw new NotImplementedException();
            // returns item
        }
        public static CommonResult uspUpdateWorldMarketPassCount(int keytype,long mainKey, int subKey)
        {
            throw new NotImplementedException();
            // returns item
        }
        public static CommonResult uspUpdateWorldMarketPassCount(int keytype, long mainKey, int subKey,double ratio)
        {
            throw new NotImplementedException();
            // returns item
        }
        public static CommonResult uspListBiddingPrice(int keytype, long mainKey, int subKey,int enchantMaxGroup, double ratio, long pricePerOne)
        {
            throw new NotImplementedException();
            // returns item
        }
        public static CommonResult uspUpdateWorldMarketPrice(int keytype, long mainKey, int subKey ,long pricePerOne, FluctuationType fluctuationType,long fluctuationPrice)
        {
            throw new NotImplementedException();
            // returns item
        }
        public static CommonResult uspUpdateWorldMarketPrice(int keytype, long mainKey, int subKey, long nextPrice , long nextGraphPrice, FluctuationType fluctuationType, long fluctuationPrice,long maxTradeCount)
        {
            throw new NotImplementedException();
            // returns item
        }
        public static CommonResult uspUpdateWorldMarketPrice(int keytype, long mainKey, int subKey, long pricePerOne, long nextGraphPrice, FluctuationType fluctuationType, long fluctuationPrice)
        {
            throw new NotImplementedException();
            // returns item
        }
        public static long uspGetItemPrice(int keytype, long mainKey, int subKey)
        {
            throw new NotImplementedException();
            // returns item
        }
      
        
    }
}
