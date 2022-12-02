namespace BlackDesert.TradeMarket.Application
{
    public static class WebDBManager
    {
        public static CommonDBResult<uspFindUser_Result> FindUser(
          int? serverNo,
          string userNickName)
        {
            CommonDBResult<uspFindUser_Result> user = new CommonDBResult<uspFindUser_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    user.list = ((IEnumerable<uspFindUser_Result>)SA_BETA_TRADEDB_0002.uspFindUser(serverNo, userNickName, symNo, rv)).ToList();
                    user.resultCode = Convert.ToInt32(rv.Value);
                    user.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                user.resultCode = 1;
                user.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspFindUser({0}/{1}) Exception : {2}", serverNo, userNickName, ex.ToString()), "ERROR");
            }
            return user;
        }

        public static CommonDBResult<uspListWorldMarketMyWallet_Result> ListWorldMarketMyWallet(
          int? nationCode,
          int? serverNo,
          long? userNo)
        {
            CommonDBResult<uspListWorldMarketMyWallet_Result> commonDbResult = new CommonDBResult<uspListWorldMarketMyWallet_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspListWorldMarketMyWallet_Result>)SA_BETA_TRADEDB_0002.uspListWorldMarketMyWallet(nationCode, serverNo, userNo, symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarketMyWallet({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static CommonDBResult<uspPersonalTradeList_Result> PersonalTradeList(
          int? nationCode,
          int? serverNo,
          long? userNo)
        {
            CommonDBResult<uspPersonalTradeList_Result> commonDbResult = new CommonDBResult<uspPersonalTradeList_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspPersonalTradeList_Result>)SA_BETA_TRADEDB_0002.uspPersonalTradeList(nationCode, serverNo, userNo, symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspPersonalTradeList({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static CommonResult UpdateMyWalletWeight(
          int? nationCode,
          int? serverNo,
          long? userNo,
          long totalWeight)
        {
            CommonResult commonResult = new CommonResult();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    SA_BETA_TRADEDB_0002.uspUpdateMyWalletWeight(nationCode, serverNo, userNo, new long?(totalWeight), symNo, rv);
                    commonResult.resultCode = Convert.ToInt32(rv.Value);
                    commonResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Error] uspUpdateMyWalletWeight({0}/{1}/{2}/{3}), Exception : {4})", nationCode, serverNo, userNo, totalWeight, ex.ToString()), "ERROR");
            }
            return commonResult;
        }

        public static CommonResult WorldMarketMyWallet(
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          bool? isSealed,
          ref string count)
        {
            CommonResult commonResult = new CommonResult();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter count1 = new ObjectParameter(nameof(count), typeof(long));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    SA_BETA_TRADEDB_0002.uspWorldMarketMyWallet(nationCode, serverNo, userNo, keyType, mainKey, subKey, isSealed, count1, symNo, rv);
                    count = Convert.ToString(count1.Value);
                    commonResult.resultCode = Convert.ToInt32(rv.Value);
                    commonResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspWorldMarketMyWallet({0}/{1}/{2}/{3}/{4}/{5}/{6}) Exception : {7}", nationCode, serverNo, userNo, keyType, mainKey, subKey, count, ex.ToString()), "ERROR");
            }
            return commonResult;
        }

        public static CommonDBResult<uspBuyablePersonalTradeList_Result> BuyablePersonalTradeList(
          int? nationCode,
          int? serverNo,
          long? userNo)
        {
            CommonDBResult<uspBuyablePersonalTradeList_Result> commonDbResult = new CommonDBResult<uspBuyablePersonalTradeList_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspBuyablePersonalTradeList_Result>)SA_BETA_TRADEDB_0002.uspBuyablePersonalTradeList(nationCode, serverNo, userNo, symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspBuyablePersonalTradeList({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static int getAddTaxDiscountRate(int _nationCode, int _worldNo, long _userNo)
        {
            ObjectParameter addTaxDiscountRate = new ObjectParameter("addTaxDiscountRate", typeof(int));
            ObjectParameter familySkillAddTaxDiscountRate = new ObjectParameter("familySkillAddTaxDiscountRate", typeof(int));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    SA_BETA_TRADEDB_0002.uspGetAddTaxDiscountRate(new int?(_nationCode), new int?(_worldNo), new long?(_userNo), addTaxDiscountRate, familySkillAddTaxDiscountRate);
                    return Convert.ToInt32(addTaxDiscountRate.Value) + Convert.ToInt32(familySkillAddTaxDiscountRate.Value);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("[DB ERROR]getAddTaxDiscountRateError Exception=" + ex.ToString(), "ERROR");
                return 0;
            }
        }

        public static CommonDBResult<uspListWorldMarket_Result> ListWorldMarket(
          KeyType keyType,
          int mainCategory,
          int subCategory)
        {
            CommonDBResult<uspListWorldMarket_Result> commonDbResult = new CommonDBResult<uspListWorldMarket_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspListWorldMarket_Result>)SA_BETA_TRADEDB_0002.uspListWorldMarket(new int?((int)keyType), new int?(mainCategory), new int?(subCategory), new double?(WorldMarketOptionManager.This().BiddingRatio), symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarket({0}/{1}) Exception : {2}", mainCategory, subCategory, ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static CommonDBResult<uspSearchListWorldMarket_Result> SearchListWorldMarket(
          string searchResult)
        {
            CommonDBResult<uspSearchListWorldMarket_Result> commonDbResult = new CommonDBResult<uspSearchListWorldMarket_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspSearchListWorldMarket_Result>)SA_BETA_TRADEDB_0002.uspSearchListWorldMarket(searchResult, new double?(WorldMarketOptionManager.This().BiddingRatio), symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspSearchListWorldMarket({0}) Exception : {1}", searchResult, ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static CommonDBResult<uspListWorldMarketDetail_Result> ListWorldMarketDetail(
          KeyType keyType,
          int mainKey,
          bool isUsedTotalTradeCount)
        {
            CommonDBResult<uspListWorldMarketDetail_Result> commonDbResult = new CommonDBResult<uspListWorldMarketDetail_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspListWorldMarketDetail_Result>)SA_BETA_TRADEDB_0002.uspListWorldMarketDetail(new int?((int)keyType), new int?(mainKey), new bool?(isUsedTotalTradeCount), new double?(WorldMarketOptionManager.This().BiddingRatio), symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarketDetail({0}) Exception : {1}", mainKey, ex.ToString()), "ERROR");
                return commonDbResult;
            }
            return commonDbResult;
        }

        public static CommonDBResult<uspListWorldMarketDetailByCategory_Result> ListWorldMarketDetailByCategory(
          int? mainCategory,
          int? subCategory)
        {
            CommonDBResult<uspListWorldMarketDetailByCategory_Result> commonDbResult = new CommonDBResult<uspListWorldMarketDetailByCategory_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspListWorldMarketDetailByCategory_Result>)SA_BETA_TRADEDB_0002.uspListWorldMarketDetailByCategory(mainCategory, subCategory, new double?(WorldMarketOptionManager.This().BiddingRatio), symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarketDetailByCategory({0}, {1}) Exception : {2}", mainCategory, subCategory, ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static CommonDBResult<uspListWorldMarketHot_Result> ListWorldMarketHot()
        {
            CommonDBResult<uspListWorldMarketHot_Result> commonDbResult = new CommonDBResult<uspListWorldMarketHot_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspListWorldMarketHot_Result>)SA_BETA_TRADEDB_0002.uspListWorldMarketHot(new double?(WorldMarketOptionManager.This().BiddingRatio), symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarketHot() Exception : {0}", ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static CommonDBResult<uspListWorldMarketWait_Result> ListWorldMarketWait()
        {
            CommonDBResult<uspListWorldMarketWait_Result> commonDbResult = new CommonDBResult<uspListWorldMarketWait_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspListWorldMarketWait_Result>)SA_BETA_TRADEDB_0002.uspListWorldMarketWait(symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarketHot() Exception : {0}", ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static CommonResult WorldMarketDetailOne(
          int? mainKey,
          int enchantGroup,
          ref long pricePerOne,
          ref long count,
          ref long minPrice,
          ref long maxPrice,
          ref long totalTradeCount,
          ref long lastTradePrice,
          ref long lastTradeTime)
        {
            CommonResult commonResult = new CommonResult();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter pricePerOne1 = new ObjectParameter(nameof(pricePerOne), typeof(long));
            ObjectParameter count1 = new ObjectParameter(nameof(count), typeof(long));
            ObjectParameter minPrice1 = new ObjectParameter(nameof(minPrice), typeof(long));
            ObjectParameter maxPrice1 = new ObjectParameter(nameof(maxPrice), typeof(long));
            ObjectParameter totalTradeCount1 = new ObjectParameter(nameof(totalTradeCount), typeof(long));
            ObjectParameter lastTradePrice1 = new ObjectParameter(nameof(lastTradePrice), typeof(long));
            ObjectParameter lastTradeTime1 = new ObjectParameter(nameof(lastTradeTime), typeof(DateTime));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    SA_BETA_TRADEDB_0002.uspWorldMarketDetailOne(mainKey, new int?(enchantGroup), pricePerOne1, count1, minPrice1, maxPrice1, totalTradeCount1, lastTradePrice1, lastTradeTime1, symNo, rv);
                    pricePerOne = Convert.ToInt64(pricePerOne1.Value == null || string.IsNullOrEmpty(pricePerOne1.Value.ToString()) ? 0 : pricePerOne1.Value);
                    count = Convert.ToInt64(count1.Value == null || string.IsNullOrEmpty(count1.Value.ToString()) ? 0 : count1.Value);
                    minPrice = Convert.ToInt64(minPrice1.Value == null || string.IsNullOrEmpty(minPrice1.Value.ToString()) ? 0 : minPrice1.Value);
                    maxPrice = Convert.ToInt64(maxPrice1.Value == null || string.IsNullOrEmpty(maxPrice1.Value.ToString()) ? 0 : maxPrice1.Value);
                    totalTradeCount = Convert.ToInt64(totalTradeCount1.Value == null || string.IsNullOrEmpty(totalTradeCount1.Value.ToString()) ? 0 : totalTradeCount1.Value);
                    lastTradePrice = Convert.ToInt64(lastTradePrice1.Value == null || string.IsNullOrEmpty(lastTradePrice1.Value.ToString()) ? 0 : lastTradePrice1.Value);
                    long num;
                    if (lastTradeTime1.Value == null || string.IsNullOrEmpty(lastTradeTime1.Value.ToString()))
                    {
                        num = 0L;
                    }
                    else
                    {
                        num = CommonModule.ConvertUnixTime(Convert.ToDateTime(lastTradeTime1.Value).ToUniversalTime());
                        if (num <= 0L)
                            num = 0L;
                    }
                    lastTradeTime = Convert.ToInt64(num);
                    commonResult.resultCode = Convert.ToInt32(rv.Value);
                    commonResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspWorldMarketDetailOne({0}/{1}/{2}/{3}) Exception : {4}", mainKey, enchantGroup, pricePerOne, count, ex.ToString()), "ERROR");
            }
            return commonResult;
        }

        public static CommonDBResult<uspListBiddingInfo_Result> ListBiddingInfo(
          int? keyType,
          int? mainKey,
          int? subKey,
          int enchantMaterialKey,
          double biddingRate)
        {
            CommonDBResult<uspListBiddingInfo_Result> commonDbResult = new CommonDBResult<uspListBiddingInfo_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspListBiddingInfo_Result>)SA_BETA_TRADEDB_0002.uspListBiddingInfo(keyType, mainKey, subKey, new int?(enchantMaterialKey), new double?(biddingRate), symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspListBiddingInfo({0}/{1}/{2}/{3}) Exception : {4}", keyType, mainKey, subKey, enchantMaterialKey, ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static CommonDBResult<uspListUserBiddingBuy_Result> ListUserBiddingBuy(
          int? nationCode,
          int? serverNo,
          long? userNo)
        {
            CommonDBResult<uspListUserBiddingBuy_Result> commonDbResult = new CommonDBResult<uspListUserBiddingBuy_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspListUserBiddingBuy_Result>)SA_BETA_TRADEDB_0002.uspListUserBiddingBuy(nationCode, serverNo, userNo, symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspListUserBiddingBuy({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static CommonDBResult<uspListUserBiddingSell_Result> ListUserBiddingSell(
          int? nationCode,
          int? serverNo,
          long? userNo)
        {
            CommonDBResult<uspListUserBiddingSell_Result> commonDbResult = new CommonDBResult<uspListUserBiddingSell_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspListUserBiddingSell_Result>)SA_BETA_TRADEDB_0002.uspListUserBiddingSell(nationCode, serverNo, userNo, symNo, rv)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(rv.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] uspListUserBiddingSell({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static void getPearlItemTradeCount(
          int? nationCode,
          int? serverNo,
          long? userNo,
          out int addPearlItemLimitedCount,
          out int currentPearlItemLimitedCount,
          out long addWeight,
          out int ringBuffCount)
        {
            ObjectParameter addPearlItemLimitedCount1 = new ObjectParameter(nameof(addPearlItemLimitedCount), typeof(int));
            ObjectParameter currentPearlItemLimitedCount1 = new ObjectParameter(nameof(currentPearlItemLimitedCount), typeof(int));
            ObjectParameter addWeight1 = new ObjectParameter(nameof(addWeight), typeof(long));
            ObjectParameter ringBuffCount1 = new ObjectParameter(nameof(ringBuffCount), typeof(int));
            addPearlItemLimitedCount = 0;
            currentPearlItemLimitedCount = 0;
            addWeight = 0L;
            ringBuffCount = 0;
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    SA_BETA_TRADEDB_0002.uspGetPearlItemLimitedCount(userNo, serverNo, nationCode, addPearlItemLimitedCount1, currentPearlItemLimitedCount1, addWeight1, ringBuffCount1);
                    addPearlItemLimitedCount = Convert.ToInt32(addPearlItemLimitedCount1.Value);
                    currentPearlItemLimitedCount = Convert.ToInt32(currentPearlItemLimitedCount1.Value);
                    addWeight = Convert.ToInt64(addWeight1.Value);
                    ringBuffCount = Convert.ToInt32(ringBuffCount1.Value);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception] getAddPearlItemTradeCount({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex.ToString()), "ERROR");
            }
        }

        public static CommonDBResult<uspGetMarketPriceInfo_Result> WorldMarketPriceInfo(
          int? keyType,
          int? mainKey,
          int? subKey)
        {
            CommonDBResult<uspGetMarketPriceInfo_Result> commonDbResult = new CommonDBResult<uspGetMarketPriceInfo_Result>();
            ObjectParameter objectParameter = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    commonDbResult.list = ((IEnumerable<uspGetMarketPriceInfo_Result>)SA_BETA_TRADEDB_0002.uspGetMarketPriceInfo(keyType, mainKey, subKey, symNo)).ToList();
                    commonDbResult.resultCode = Convert.ToInt32(objectParameter.Value);
                    commonDbResult.resultMsg = Convert.ToString(symNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] WorldMarketPriceInfo({0}/{1}/{2}) Exception : {3}", keyType, mainKey, subKey, ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }

        public static CommonResult WorldMarketServnatNo(
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          ref long resultServantNo)
        {
            CommonResult commonResult = new CommonResult();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter servantNo = new ObjectParameter("servantNo", typeof(long));
            resultServantNo = 0L;
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    SA_BETA_TRADEDB_0002.uspGetServantNo(nationCode, serverNo, userNo, keyType, mainKey, subKey, servantNo, symNo, rv);
                    commonResult.resultCode = Convert.ToInt32(rv.Value);
                    commonResult.resultMsg = Convert.ToString(symNo.Value);
                    if (commonResult.resultCode != 0)
                        return commonResult;
                    resultServantNo = Convert.ToInt64(servantNo.Value);
                }
            }
            catch (Exception ex)
            {
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] WorldMarketServnatNo({0}/{1}/{2}) Exception : {3}", keyType, mainKey, subKey, ex.ToString()), "ERROR");
                return commonResult;
            }
            return commonResult;
        }

        public static CommonDBResult<uspWorldMarketWaitNoticeList_Result> WorldMarketMyWaitNoticeList(
          int nationCode,
          int serverNo,
          long userNo)
        {
            CommonDBResult<uspWorldMarketWaitNoticeList_Result> commonDbResult = new CommonDBResult<uspWorldMarketWaitNoticeList_Result>();
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                    commonDbResult.list = ((IEnumerable<uspWorldMarketWaitNoticeList_Result>)SA_BETA_TRADEDB_0002.uspWorldMarketWaitNoticeList(new int?(nationCode), new int?(serverNo), new long?(userNo))).ToList();
            }
            catch (Exception ex)
            {
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                LogUtil.WriteLog(string.Format("[DB Exception] WorldMarketMyWaitNoticeList userNo {0} EX {1}", userNo, ex.ToString()), "ERROR");
            }
            return commonDbResult;
        }
    }
}
