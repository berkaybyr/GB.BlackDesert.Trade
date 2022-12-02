// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Controllers.HomeController
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.App_Start;
using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.DB;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Manager.Auth;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using GB.BlackDesert.Trade.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.Controllers
{
    [WebFilter]
    public class HomeController : BaseController
    {
        private const int CACHE_SECOND = 1;

        [Route("")]
        [Route("home/wallet")]
        [Route("home/item/{id}")]
        [Route("home/list/{id}")]
        [Route("home/list/hot")]
        [Route("home/search/{keyword}")]
        public ActionResult Index(string id, string lang = "")
        {
            MainViewModel mainViewModel = new MainViewModel();
            string empty = string.Empty;
            try
            {
                if (AuthenticateManager.IsAutheticated.Equals(false))
                    return (ActionResult)this.Redirect(ConstantMgr._authRedirectUri);
                if ((ConstantMgr._serviceType.Equals("DEV") || ConstantMgr._serviceType.Equals("CS") || ConstantMgr._serviceType.Equals("TR") || ConstantMgr._serviceType.Equals("ID")) && lang.IsNotNullOrEmpty())
                    CommonModule.SetUserCulture(lang);
                CommonResult commonResult = new CommonResult();
                UserInfomationModel userInfo = (UserInfomationModel)null;
                TradeModule.CheckAuthKey(ref userInfo, this._userinfo.accountNo, this._userinfo.certifiedKey);
                mainViewModel.categoryList = CategoryInfoManager.This().CategoryList;
                mainViewModel.userNickName = this.AuthUserInfo._userNickName;
                mainViewModel._secondPwdPass = this.AuthUserInfo._secondPwdPass;
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Error]HomeController Index() Exception Error={0}", (object)ex.ToString()), "ERROR");
            }
            return (ActionResult)this.View((object)mainViewModel);
        }

        [HttpPost]
        public JsonResult GetMyWalletList()
        {
            MyWalletListModel myWalletListModel = new MyWalletListModel();
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            long num = 0;
            string empty = string.Empty;
            try
            {
                CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, this._userinfo.accountNo, this._userinfo.certifiedKey);
                if (commonResult2.resultCode != 0)
                {
                    myWalletListModel.resultCode = commonResult2.resultCode;
                    myWalletListModel.resultMsg = commonResult2.resultMsg;
                    LogUtil.WriteLog(string.Format("[Auth Error]GetMyWalletList() errorCode({0}) // errorMessage={1}", (object)commonResult2.resultCode, (object)commonResult2.resultMsg), "WARN");
                    return this.Json((object)myWalletListModel);
                }
                CommonDBResult<uspListWorldMarketMyWallet_Result> commonDbResult = WebDBManager.ListWorldMarketMyWallet(new int?(userInfo._nationCode), new int?(userInfo._worldNo), new long?(userInfo._userNo));
                if (commonDbResult.resultCode != 0)
                {
                    myWalletListModel.resultCode = commonDbResult.resultCode;
                    myWalletListModel.resultMsg = CommonModule.GetResourceValue(commonDbResult.resultMsg);
                    return this.Json((object)myWalletListModel);
                }
                myWalletListModel.myWalletList = new List<MyWalletInfoModel>();
                foreach (uspListWorldMarketMyWallet_Result marketMyWalletResult in commonDbResult.list)
                {
                    TradeMarketItemInfo info = ItemInfoManager.This().getInfo(marketMyWalletResult.C_mainKey, marketMyWalletResult.C_subKey);
                    string itemName = StringManager.This().ItemName(marketMyWalletResult.C_mainKey);
                    if (!string.IsNullOrEmpty(itemName) && !itemName.Equals("-"))
                    {
                        if (marketMyWalletResult.C_mainKey.Equals(719898))
                            itemName = CommonModule.GetItemString(itemName, marketMyWalletResult.C_subKey);
                        MyWalletInfoModel myWalletInfoModel1 = new MyWalletInfoModel();
                        myWalletInfoModel1.nationCode = marketMyWalletResult.C_nationCode;
                        myWalletInfoModel1.serverNo = marketMyWalletResult.C_serverNo;
                        myWalletInfoModel1.userNo = marketMyWalletResult.C_userNo;
                        myWalletInfoModel1.keyType = marketMyWalletResult.C_keyType;
                        myWalletInfoModel1.mainKey = marketMyWalletResult.C_mainKey;
                        myWalletInfoModel1.subKey = info._enchantGroup;
                        myWalletInfoModel1.chooseKey = marketMyWalletResult.C_subKey;
                        myWalletInfoModel1.isSealed = marketMyWalletResult.C_isSealed;
                        myWalletInfoModel1.count = marketMyWalletResult.C_count;
                        myWalletInfoModel1.name = itemName;
                        myWalletInfoModel1.grade = info._grade;
                        myWalletInfoModel1.mainCategory = info._mainGroupNo;
                        MyWalletInfoModel myWalletInfoModel2 = myWalletInfoModel1;
                        myWalletListModel.myWalletList.Add(myWalletInfoModel2);
                    }
                }
                foreach (MyWalletInfoModel myWallet in myWalletListModel.myWalletList)
                {
                    TradeMarketItemInfo info = ItemInfoManager.This().getInfo(myWallet.mainKey, myWallet.subKey);
                    if (!info.isValid() && Convert.ToInt32((object)SpecialKey.eSpecialKey_SilverKey) != myWallet.mainKey)
                    {
                        LogUtil.WriteLog(string.Format("[Normal Error] GetMyWalletList({0}, {1}, {2}) itemInfo({3}, {4})", (object)userInfo._nationCode, (object)userInfo._worldNo, (object)userInfo._userNo, (object)myWallet.mainKey, (object)myWallet.subKey), "WARN");
                    }
                    else
                    {
                        num = 0L;
                        long weight = info._weight;
                        myWalletListModel.totalWeight += weight * myWallet.count;
                    }
                }
                CommonResult commonResult3 = WebDBManager.UpdateMyWalletWeight(new int?(userInfo._nationCode), new int?(userInfo._worldNo), new long?(userInfo._userNo), myWalletListModel.totalWeight);
                if (commonResult3.resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("[DB Error]GetMyWalletList - uspUpdateMyWalletWeight({0}/{1}/{2}/{3}), rv({4})", (object)userInfo._nationCode, (object)userInfo._worldNo, (object)userInfo._userNo, (object)myWalletListModel.totalWeight, (object)commonResult3.resultCode), "WARN");
                    myWalletListModel.resultCode = commonResult3.resultCode;
                    myWalletListModel.resultMsg = CommonModule.GetResourceValue(commonResult3.resultMsg);
                    return this.Json((object)myWalletListModel);
                }
                myWalletListModel.maxWeight = WorldMarketOptionManager.This().getMaxWeight();
                myWalletListModel.useValuePackage = !(this._userinfo.userInfoModel._valuePackageExpiration < CommonModule.GetCustomTime());
                myWalletListModel.feeRate = (double)WebDBManager.getAddTaxDiscountRate(userInfo._nationCode, userInfo._worldNo, userInfo._userNo);
                myWalletListModel.feeRate /= 10000.0;
                if (myWalletListModel.useValuePackage)
                    myWalletListModel.feeRate += 30.0;
                WorldMarketOptionManager.This().getPearlItemLimitedMaxCount();
                int addPearlItemLimitedCount = 0;
                int currentPearlItemLimitedCount = 0;
                long addWeight = 0;
                int ringBuffCount = 0;
                WebDBManager.getPearlItemTradeCount(new int?(userInfo._nationCode), new int?(userInfo._worldNo), new long?(userInfo._userNo), out addPearlItemLimitedCount, out currentPearlItemLimitedCount, out addWeight, out ringBuffCount);
                myWalletListModel.addWeight = addWeight;
                myWalletListModel.ringBuffCount = ringBuffCount;
                myWalletListModel.useAddWeightBuff = !(this._userinfo.userInfoModel._addWeightBuffExpiration < CommonModule.GetCustomTime());
                if (myWalletListModel.useAddWeightBuff)
                    myWalletListModel.addWeight += (long)WorldMarketOptionManager.This().getIncreaseWeightByBuff(this._userinfo.userInfoModel._addWeightBuffExpiration);
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Exception Error]GetMyWalletList() Exception Error={0}", (object)ex.ToString()), "ERROR");
                myWalletListModel.resultCode = -9999;
                myWalletListModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_EXCEPTION");
            }
            return this.Json((object)myWalletListModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetMyWallet(
          int? keyType,
          int? mainKey,
          int? subKey,
          bool? isSealed)
        {
            MyWalletModel myWalletModel = new MyWalletModel();
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string empty = string.Empty;
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, this._userinfo.accountNo, this._userinfo.certifiedKey);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error]GetMyBiddingList() errorCode({0}) // errorMessage={1}", (object)commonResult2.resultCode, (object)commonResult2.resultMsg), "WARN");
                return this.Json((object)commonResult2);
            }
            CommonResult commonResult3 = WebDBManager.WorldMarketMyWallet(new int?(userInfo._nationCode), new int?(userInfo._worldNo), new long?(userInfo._userNo), keyType, mainKey, subKey, isSealed, ref empty);
            if (commonResult3.resultCode != 0)
            {
                commonResult3.resultMsg = CommonModule.GetResourceValue(commonResult3.resultMsg);
                LogUtil.WriteLog(string.Format("[Error]WorldMarketMyWallet() errorCode({0}) // errorMessage={1}", (object)commonResult3.resultCode, (object)commonResult3.resultMsg), "WARN");
                return this.Json((object)commonResult3);
            }
            myWalletModel.count = empty;
            return this.Json((object)myWalletModel);
        }

        [OutputCache(Duration = 1, VaryByParam = "mainCategory;subCategory")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetWorldMarketList(int? mainCategory, int? subCategory)
        {
            WorldMarketListModel worldMarketListModel = new WorldMarketListModel();
            string empty = string.Empty;
            UserInfomationModel userInfomationModel = new UserInfomationModel();
            try
            {
                AuthenticationInfo authInfo = AuthenticateManager.GetAuthInfo();
                if (authInfo != null)
                {
                    UserInfomationModel userInfoModel = authInfo.userInfoModel;
                    if (authInfo.userInfoModel._secondPwdPass.Equals(false))
                    {
                        worldMarketListModel.resultCode = -8745;
                        worldMarketListModel.resultMsg = "/Error";
                        return this.Json((object)worldMarketListModel);
                    }
                }
                CommonDBResult<uspListWorldMarket_Result> commonDbResult = WebDBManager.ListWorldMarket(KeyType.eItem, mainCategory.Value, subCategory.Value);
                if (commonDbResult.resultCode != 0)
                {
                    worldMarketListModel.resultCode = commonDbResult.resultCode;
                    worldMarketListModel.resultMsg = CommonModule.GetResourceValue(commonDbResult.resultMsg);
                    return this.Json((object)worldMarketListModel);
                }
                worldMarketListModel.marketList = new List<WorldMarketInfoModel>();
                foreach (uspListWorldMarket_Result worldMarketResult in commonDbResult.list)
                {
                    string str = StringManager.This().ItemName(worldMarketResult.C_mainKey);
                    if (!string.IsNullOrEmpty(str) && !str.Equals("-"))
                        worldMarketListModel.marketList.Add(new WorldMarketInfoModel()
                        {
                            mainKey = worldMarketResult.C_mainKey,
                            sumCount = Convert.ToInt64((object)worldMarketResult.C_sumCount),
                            name = str,
                            grade = ItemInfoManager.This().getInfo(worldMarketResult.C_mainKey, 0)._grade,
                            minPrice = Convert.ToInt64((object)worldMarketResult.C_minPrice)
                        });
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Exception Error]GetWorldMarketList() Exception Error={0}", (object)ex.ToString()), "ERROR");
                worldMarketListModel.resultCode = -9999;
                worldMarketListModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_EXCEPTION");
            }
            return this.Json((object)worldMarketListModel);
        }

        [OutputCache(Duration = 1, VaryByParam = "mainKey")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetWorldMarketSubList(int? mainKey)
        {
            WorldMarketDetailListModel marketDetailListModel = new WorldMarketDetailListModel();
            string empty = string.Empty;
            try
            {
                if (mainKey.IsNull<int?>())
                {
                    LogUtil.WriteLog("[Item Error] GetWorldMarketSubList() mainKey is null", "WARN");
                    marketDetailListModel.resultCode = 8;
                    marketDetailListModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_INVALID_ITEM");
                }
                CommonDBResult<uspListWorldMarketDetail_Result> commonDbResult = WebDBManager.ListWorldMarketDetail(KeyType.eItem, mainKey.Value, true);
                if (commonDbResult.resultCode != 0)
                {
                    marketDetailListModel.resultCode = commonDbResult.resultCode;
                    marketDetailListModel.resultMsg = CommonModule.GetResourceValue(commonDbResult.resultMsg);
                    return this.Json((object)marketDetailListModel);
                }
                marketDetailListModel.detailList = new List<WorldMarketDetailInfoModel>();
                foreach (uspListWorldMarketDetail_Result marketDetailResult in commonDbResult.list)
                {
                    TradeMarketItemInfo info = ItemInfoManager.This().getInfo(marketDetailResult.C_mainKey, marketDetailResult.C_subKey);
                    string itemName = StringManager.This().ItemName(marketDetailResult.C_mainKey);
                    if (!string.IsNullOrEmpty(itemName) && !itemName.Equals("-"))
                    {
                        if (marketDetailResult.C_mainKey.Equals(719898))
                            itemName = CommonModule.GetItemString(itemName, marketDetailResult.C_subKey);
                        List<WorldMarketDetailInfoModel> detailList = marketDetailListModel.detailList;
                        WorldMarketDetailInfoModel marketDetailInfoModel = new WorldMarketDetailInfoModel();
                        marketDetailInfoModel.keyType = marketDetailResult.C_keyType;
                        marketDetailInfoModel.mainKey = marketDetailResult.C_mainKey;
                        marketDetailInfoModel.subKey = info._enchantGroup;
                        marketDetailInfoModel.chooseKey = marketDetailResult.C_subKey;
                        marketDetailInfoModel.pricePerOne = marketDetailResult.C_pricePerOne.Value;
                        marketDetailInfoModel.count = marketDetailResult.C_count.Value;
                        marketDetailInfoModel.totalTradeCount = marketDetailResult.C_totalTradeCount.Value;
                        marketDetailInfoModel.name = itemName;
                        marketDetailInfoModel.grade = info._grade;
                        marketDetailInfoModel.mainCategory = info._mainGroupNo;
                        marketDetailInfoModel.subCategory = info._subGroupNo;
                        detailList.Add(marketDetailInfoModel);
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Exception Error]GetWorldMarketSubList() Exception Error={0}", (object)ex.ToString()), "ERROR");
                marketDetailListModel.resultCode = -9999;
                marketDetailListModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_EXCEPTION");
            }
            return this.Json((object)marketDetailListModel);
        }

        [OutputCache(Duration = 1)]
        [HttpPost]
        public JsonResult GetWorldMarketHotList()
        {
            WorldMarketHotListModel marketHotListModel = new WorldMarketHotListModel();
            string empty = string.Empty;
            try
            {
                CommonDBResult<uspListWorldMarketHot_Result> commonDbResult = WebDBManager.ListWorldMarketHot();
                if (commonDbResult.resultCode != 0)
                {
                    marketHotListModel.resultCode = commonDbResult.resultCode;
                    marketHotListModel.resultMsg = CommonModule.GetResourceValue(commonDbResult.resultMsg);
                    return this.Json((object)marketHotListModel);
                }
                marketHotListModel.hotList = new List<WorldMarketHotListInfoModel>();
                foreach (uspListWorldMarketHot_Result worldMarketHotResult in commonDbResult.list)
                {
                    TradeMarketItemInfo info = ItemInfoManager.This().getInfo(worldMarketHotResult.C_mainKey, worldMarketHotResult.C_subKey);
                    string itemName = StringManager.This().ItemName(worldMarketHotResult.C_mainKey);
                    if (!string.IsNullOrEmpty(itemName) && !itemName.Equals("-"))
                    {
                        if (worldMarketHotResult.C_mainKey.Equals(719898))
                            itemName = CommonModule.GetItemString(itemName, worldMarketHotResult.C_subKey);
                        List<WorldMarketHotListInfoModel> hotList = marketHotListModel.hotList;
                        WorldMarketHotListInfoModel hotListInfoModel = new WorldMarketHotListInfoModel();
                        hotListInfoModel.keyType = worldMarketHotResult.C_keyType;
                        hotListInfoModel.mainCategory = info._mainGroupNo;
                        hotListInfoModel.mainKey = worldMarketHotResult.C_mainKey;
                        hotListInfoModel.subKey = info._enchantGroup;
                        hotListInfoModel.subtype = info._enchantGroup;
                        hotListInfoModel.chooseKey = worldMarketHotResult.C_subKey;
                        hotListInfoModel.pricePerOne = worldMarketHotResult.C_pricePerOne.Value;
                        long? nullable = worldMarketHotResult.C_count;
                        hotListInfoModel.count = nullable.Value;
                        nullable = worldMarketHotResult.C_totalTradeCount;
                        hotListInfoModel.totalTradeCount = nullable.Value;
                        hotListInfoModel.fluctuationType = worldMarketHotResult.C_fluctuationType;
                        hotListInfoModel.fluctuationPrice = worldMarketHotResult.C_fluctuationPrice;
                        hotListInfoModel.name = itemName;
                        hotListInfoModel.grade = info._grade;
                        hotList.Add(hotListInfoModel);
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Exception Error]GetWorldMarketHotList() Exception Error={0}", (object)ex.ToString()), "ERROR");
                marketHotListModel.resultCode = -9999;
                marketHotListModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_EXCEPTION");
            }
            return this.Json((object)marketHotListModel);
        }

        [OutputCache(Duration = 1)]
        [HttpPost]
        public JsonResult GetWorldMarketWaitList()
        {
            WorldMarketWaitListModel marketWaitListModel = new WorldMarketWaitListModel();
            string empty = string.Empty;
            try
            {
                CommonDBResult<uspListWorldMarketWait_Result> commonDbResult = WebDBManager.ListWorldMarketWait();
                if (commonDbResult.resultCode != 0)
                {
                    marketWaitListModel.resultCode = commonDbResult.resultCode;
                    marketWaitListModel.resultMsg = CommonModule.GetResourceValue(commonDbResult.resultMsg);
                    return this.Json((object)marketWaitListModel);
                }
                foreach (uspListWorldMarketWait_Result marketWaitResult in commonDbResult.list)
                {
                    TradeMarketItemInfo info = ItemInfoManager.This().getInfo(marketWaitResult.C_mainKey, marketWaitResult.C_chooseSubKey);
                    string itemName = StringManager.This().ItemName(marketWaitResult.C_mainKey);
                    if (!string.IsNullOrEmpty(itemName) && !itemName.Equals("-"))
                    {
                        if (marketWaitResult.C_mainKey.Equals(719898))
                            itemName = CommonModule.GetItemString(itemName, marketWaitResult.C_chooseSubKey);
                        long num = CommonModule.ConvertUnixTimeMs(marketWaitResult.C_waitEndTime.Value.ToUniversalTime());
                        if (num <= 0L)
                            num = 0L;
                        List<WorldMarketWaitInfoModel> waitList = marketWaitListModel._waitList;
                        WorldMarketWaitInfoModel marketWaitInfoModel = new WorldMarketWaitInfoModel();
                        marketWaitInfoModel.keyType = marketWaitResult.C_keyType;
                        marketWaitInfoModel.mainCategory = info._mainGroupNo;
                        marketWaitInfoModel.mainKey = marketWaitResult.C_mainKey;
                        marketWaitInfoModel.chooseKey = marketWaitResult.C_chooseSubKey;
                        marketWaitInfoModel._pricePerOne = marketWaitResult.C_pricePerOne;
                        marketWaitInfoModel._waitEndTime = num;
                        marketWaitInfoModel.name = itemName;
                        marketWaitInfoModel.grade = info._grade;
                        waitList.Add(marketWaitInfoModel);
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Exception Error]GetWorldMarketWaitList() Exception Error={0}", (object)ex.ToString()), "ERROR");
                marketWaitListModel.resultCode = -9999;
                marketWaitListModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_EXCEPTION");
            }
            return this.Json((object)marketWaitListModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetWorldMarketSubOne(int? sellMainKey, int? sellSubKey)
        {
            WorldMarketSubOneModel marketSubOneModel = new WorldMarketSubOneModel();
            CommonResult commonResult1 = new CommonResult();
            long pricePerOne = 0;
            long count = 0;
            long minPrice = 0;
            long maxPrice = 0;
            long totalTradeCount = 0;
            long lastTradePrice = 0;
            long lastTradeTime = 0;
            int num = !sellMainKey.HasValue ? 0 : Convert.ToInt32(sellMainKey.Value);
            int enchantLevel = !sellSubKey.HasValue ? 0 : Convert.ToInt32(sellSubKey.Value);
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(sellMainKey.Value, sellSubKey.Value);
            if (!info.isValid() || num == 0)
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetWorldMarketSubOne({0}, {1}) Not Exist ItemInfo", (object)num, (object)enchantLevel), "WARN");
                marketSubOneModel.resultCode = 8;
                marketSubOneModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_INVALID_ITEM");
                return this.Json((object)marketSubOneModel);
            }
            CommonResult commonResult2 = WebDBManager.WorldMarketDetailOne(new int?(num), info._enchantGroup, ref pricePerOne, ref count, ref minPrice, ref maxPrice, ref totalTradeCount, ref lastTradePrice, ref lastTradeTime);
            if (commonResult2.resultCode != 0)
            {
                commonResult2.resultMsg = CommonModule.GetResourceValue(commonResult2.resultMsg);
                return this.Json((object)commonResult2);
            }
            marketSubOneModel.enchantGroup = info._enchantGroup;
            marketSubOneModel.enchantMaxGroup = ItemInfoManager.This().getEnchantMaxGroup(num, info._enchantGroup);
            marketSubOneModel.pricePerOneValue = pricePerOne;
            marketSubOneModel.countValue = count;
            marketSubOneModel.name = StringManager.This().ItemName(num);
            marketSubOneModel.grade = ItemInfoManager.This().getInfo(num, enchantLevel)._grade;
            marketSubOneModel.minPrice = minPrice;
            marketSubOneModel.maxPrice = maxPrice;
            return this.Json((object)marketSubOneModel);
        }

        [OutputCache(Duration = 1, VaryByParam = "keyType;mainKey;subKey")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetBiddingInfoList(int? keyType, int? mainKey, int? subKey)
        {
            BiddingInfoListModel biddingInfoListModel = new BiddingInfoListModel();
            try
            {
                TradeMarketItemInfo info = ItemInfoManager.This().getInfo(mainKey.Value, subKey.Value);
                if (!info.isValid())
                {
                    LogUtil.WriteLog(string.Format("[Item Error] GetBiddingInfoList({0}, {1}) Not Exist ItemInfo", (object)mainKey, (object)subKey), "WARN");
                    biddingInfoListModel.resultCode = 8;
                    biddingInfoListModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_INVALID_ITEM");
                    return this.Json((object)biddingInfoListModel);
                }
                biddingInfoListModel.biddingInfoList = new List<BiddingInfoModel>();
                CommonDBResult<uspListBiddingInfo_Result> commonDbResult = WebDBManager.ListBiddingInfo(keyType, mainKey, subKey, info._enchantMaterialKey, WorldMarketOptionManager.This().BiddingRatio);
                if (commonDbResult.resultCode != 0)
                {
                    biddingInfoListModel.resultCode = commonDbResult.resultCode;
                    biddingInfoListModel.resultMsg = CommonModule.GetResourceValue(commonDbResult.resultMsg);
                    return this.Json((object)biddingInfoListModel);
                }
                foreach (uspListBiddingInfo_Result biddingInfoResult in commonDbResult.list)
                    biddingInfoListModel.biddingInfoList.Add(new BiddingInfoModel()
                    {
                        sellCount = biddingInfoResult.C_sellCount,
                        buyCount = biddingInfoResult.C_buyCount,
                        pricePerOne = biddingInfoResult.C_pricePerOne
                    });
            }
            catch (Exception ex)
            {
                biddingInfoListModel.resultCode = 8;
                biddingInfoListModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_EXCEPTION");
                LogUtil.WriteLog(string.Format("[Item Exception] GetBiddingInfoList({0}/{1}/{2}) Exception : {3}", (object)keyType, (object)mainKey, (object)subKey, (object)ex.ToString()), "ERROR");
            }
            return this.Json((object)biddingInfoListModel);
        }

        [OutputCache(Duration = 1, VaryByParam = "keyType;mainKey;subKey")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetAddEnchantLevelPrice(int? keyType, int? mainKey, int? subKey)
        {
            EnchantInfoModel enchantInfoModel = new EnchantInfoModel();
            TradeMarketItemInfo _itemStaticStatus = new TradeMarketItemInfo();
            CommonDBResult<uspListWorldMarketDetail_Result> commonDbResult1 = new CommonDBResult<uspListWorldMarketDetail_Result>();
            try
            {
                if (mainKey.Value <= 0)
                {
                    LogUtil.WriteLog(string.Format("[Item Error] GetAddEnchantLevelPrice({0}, {1}, {2}) [mainKey <= 0]", (object)keyType, (object)mainKey, (object)subKey), "WARN");
                    enchantInfoModel.resultCode = 8;
                    enchantInfoModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_INVALID_ITEM");
                    return this.Json((object)enchantInfoModel);
                }
                _itemStaticStatus = ItemInfoManager.This().getInfo(mainKey.Value, subKey.Value);
                if (!_itemStaticStatus.isValid())
                {
                    LogUtil.WriteLog(string.Format("[Item Error] GetAddEnchantLevelPrice({0}, {1}, {2}) ItemInfo({3}, {4}) Not Exist ItemInfo ", (object)keyType, (object)mainKey, (object)subKey, (object)mainKey, (object)subKey), "WARN");
                    enchantInfoModel.resultCode = 8;
                    enchantInfoModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_INVALID_ITEM");
                    return this.Json((object)enchantInfoModel);
                }
                if (_itemStaticStatus._enchantMaterialKey <= 0)
                    return this.Json((object)enchantInfoModel);
                CommonDBResult<uspListWorldMarketDetail_Result> commonDbResult2 = WebDBManager.ListWorldMarketDetail(KeyType.eItem, _itemStaticStatus._enchantMaterialKey, true);
                if (commonDbResult2.list == null || commonDbResult2.list.FirstOrDefault<uspListWorldMarketDetail_Result>() == null)
                    return this.Json((object)enchantInfoModel);
                enchantInfoModel.enchantNeedCount = _itemStaticStatus._enchantNeedCount;
                enchantInfoModel.keyType = commonDbResult2.list.FirstOrDefault<uspListWorldMarketDetail_Result>().C_keyType;
                enchantInfoModel.mainKey = commonDbResult2.list.FirstOrDefault<uspListWorldMarketDetail_Result>().C_mainKey;
                enchantInfoModel.subKey = _itemStaticStatus._enchantGroup;
                enchantInfoModel.chooseKey = commonDbResult2.list.FirstOrDefault<uspListWorldMarketDetail_Result>().C_subKey;
                enchantInfoModel.pricePerOne = commonDbResult2.list.FirstOrDefault<uspListWorldMarketDetail_Result>().C_pricePerOne.Value;
                enchantInfoModel.count = commonDbResult2.list.FirstOrDefault<uspListWorldMarketDetail_Result>().C_count.Value;
                enchantInfoModel.totalTradeCount = commonDbResult2.list.FirstOrDefault<uspListWorldMarketDetail_Result>().C_totalTradeCount.Value;
                if (commonDbResult2.list.Where<uspListWorldMarketDetail_Result>((Func<uspListWorldMarketDetail_Result, bool>)(x => x.C_mainKey == _itemStaticStatus._enchantMaterialKey)).FirstOrDefault<uspListWorldMarketDetail_Result>().C_pricePerOne.Value < 0L)
                {
                    LogUtil.WriteLog(string.Format("[Item Error] GetAddEnchantLevelPrice({0}, {1}, {2}) - enchantMaterialKey({3}) [totalPrice < 0]", (object)keyType, (object)mainKey, (object)subKey, (object)_itemStaticStatus._enchantMaterialKey), "WARN");
                    enchantInfoModel.resultCode = 14;
                    enchantInfoModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_PRICE_WORNG");
                    return this.Json((object)enchantInfoModel);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Exception] GetAddEnchantLevelPrice({0},{1},{2}) Exception : {3}", (object)keyType, (object)mainKey, (object)subKey, (object)ex.ToString()), "ERROR");
                enchantInfoModel.resultCode = -9999;
                enchantInfoModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_EXCEPTION");
                return this.Json((object)enchantInfoModel);
            }
            return this.Json((object)enchantInfoModel);
        }

        [HttpPost]
        public JsonResult GetMyBiddingList()
        {
            TradeMarketListUserBiddingModel userBiddingModel = new TradeMarketListUserBiddingModel();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string empty = string.Empty;
            try
            {
                CommonResult commonResult = TradeModule.CheckAuthKey(ref userInfo, this._userinfo.accountNo, this._userinfo.certifiedKey);
                if (commonResult.resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("[Auth Error]GetMyBiddingList() errorCode({0}) // errorMessage={1}", (object)commonResult.resultCode, (object)commonResult.resultMsg), "WARN");
                    return this.Json((object)commonResult);
                }
                CommonDBResult<uspListUserBiddingBuy_Result> commonDbResult1 = WebDBManager.ListUserBiddingBuy(new int?(userInfo._nationCode), new int?(userInfo._worldNo), new long?(userInfo._userNo));
                if (commonDbResult1.resultCode != 0)
                {
                    userBiddingModel.resultCode = commonDbResult1.resultCode;
                    userBiddingModel.resultMsg = CommonModule.GetResourceValue(commonDbResult1.resultMsg);
                    return this.Json((object)userBiddingModel);
                }
                foreach (uspListUserBiddingBuy_Result biddingBuyResult in commonDbResult1.list)
                {
                    string itemName = StringManager.This().ItemName(biddingBuyResult.C_mainKey);
                    if (!string.IsNullOrEmpty(itemName) && !itemName.Equals("-"))
                    {
                        if (biddingBuyResult.C_mainKey.Equals(719898))
                            itemName = CommonModule.GetItemString(itemName, biddingBuyResult.C_subKey);
                        List<ListUserBiddingBuyModel> buyList = userBiddingModel.buyList;
                        ListUserBiddingBuyModel userBiddingBuyModel = new ListUserBiddingBuyModel();
                        userBiddingBuyModel.name = itemName;
                        userBiddingBuyModel.buyNo = biddingBuyResult.C_buyNo;
                        userBiddingBuyModel.keyType = biddingBuyResult.C_keyType;
                        userBiddingBuyModel.mainKey = biddingBuyResult.C_mainKey;
                        userBiddingBuyModel.subKey = biddingBuyResult.C_subKey;
                        userBiddingBuyModel.chooseKey = biddingBuyResult.C_chooseSubKey;
                        userBiddingBuyModel.leftCount = biddingBuyResult.C_leftCount;
                        userBiddingBuyModel.boughtCount = biddingBuyResult.C_boughtCount;
                        userBiddingBuyModel.pricePerOne = biddingBuyResult.C_pricePerOne;
                        userBiddingBuyModel.addEnchantPrice = biddingBuyResult.C_addEnchantPrice;
                        userBiddingBuyModel.registerMoneyCount = biddingBuyResult.C_registerMoneyCount;
                        userBiddingBuyModel.grade = ItemInfoManager.This().getInfo(biddingBuyResult.C_mainKey, biddingBuyResult.C_subKey)._grade;
                        userBiddingBuyModel.mainCategory = ItemInfoManager.This().getInfo(biddingBuyResult.C_mainKey, biddingBuyResult.C_subKey)._mainGroupNo;
                        buyList.Add(userBiddingBuyModel);
                    }
                }
                CommonDBResult<uspListUserBiddingSell_Result> commonDbResult2 = WebDBManager.ListUserBiddingSell(new int?(userInfo._nationCode), new int?(userInfo._worldNo), new long?(userInfo._userNo));
                if (commonDbResult2.resultCode != 0)
                {
                    userBiddingModel.resultCode = commonDbResult2.resultCode;
                    userBiddingModel.resultMsg = CommonModule.GetResourceValue(commonDbResult2.resultMsg);
                    return this.Json((object)userBiddingModel);
                }
                foreach (uspListUserBiddingSell_Result biddingSellResult in commonDbResult2.list)
                {
                    TradeMarketItemInfo itemInfo = ItemInfoManager.This().getInfo(biddingSellResult.C_mainKey, biddingSellResult.C_chooseSubKey);
                    string itemName = StringManager.This().ItemName(biddingSellResult.C_mainKey);
                    if (!string.IsNullOrEmpty(itemName) && !itemName.Equals("-"))
                    {
                        uspListWorldMarketDetail_Result marketDetailResult1 = new uspListWorldMarketDetail_Result();
                        List<uspListWorldMarketDetail_Result> marketDetailResultList = new List<uspListWorldMarketDetail_Result>();
                        long num1 = 0;
                        long num2 = 0;
                        if (0 < itemInfo._enchantMaterialKey)
                        {
                            uspListWorldMarketDetail_Result marketDetailResult2 = WebDBManager.ListWorldMarketDetail(KeyType.eItem, itemInfo._enchantMaterialKey, true).list.Where<uspListWorldMarketDetail_Result>((Func<uspListWorldMarketDetail_Result, bool>)(x => x.C_mainKey == itemInfo._enchantMaterialKey)).FirstOrDefault<uspListWorldMarketDetail_Result>();
                            if (marketDetailResult2 != null)
                            {
                                num1 = itemInfo._enchantNeedCount;
                                num2 = marketDetailResult2.C_pricePerOne.Value;
                            }
                        }
                        if (biddingSellResult.C_mainKey.Equals(719898))
                            itemName = CommonModule.GetItemString(itemName, biddingSellResult.C_subKey);
                        List<ListUserBiddingSellModel> sellList = userBiddingModel.sellList;
                        ListUserBiddingSellModel biddingSellModel = new ListUserBiddingSellModel();
                        biddingSellModel.name = itemName;
                        biddingSellModel.sellNo = biddingSellResult.C_sellNo;
                        biddingSellModel.keyType = biddingSellResult.C_keyType;
                        biddingSellModel.mainKey = biddingSellResult.C_mainKey;
                        biddingSellModel.subKey = biddingSellResult.C_subKey;
                        biddingSellModel.chooseKey = biddingSellResult.C_chooseSubKey;
                        biddingSellModel.leftCount = biddingSellResult.C_leftCount;
                        biddingSellModel.pricePerOne = biddingSellResult.C_pricePerOne;
                        biddingSellModel.soldCount = biddingSellResult.C_soldCount;
                        biddingSellModel.isSealed = biddingSellResult.C_isSealed;
                        biddingSellModel.accumulateMoneyCount = biddingSellResult.C_accumulateMoneyCount;
                        biddingSellModel.grade = itemInfo._grade;
                        biddingSellModel.enchantNeedCount = num1;
                        biddingSellModel.enchantMaterialPrice = num2;
                        biddingSellModel.mainCategory = itemInfo._mainGroupNo;
                        biddingSellModel.ringBuff = biddingSellResult.C_isRingBuff;
                        sellList.Add(biddingSellModel);
                    }
                }
                userBiddingModel.resultCode = 0;
            }
            catch (Exception ex)
            {
                userBiddingModel.resultCode = -9999;
                userBiddingModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_EXCEPTION");
                LogUtil.WriteLog(string.Format("[Exception Error]GetMyBiddingList() Exception Error={0}", (object)ex.ToString()), "ERROR");
            }
            return this.Json((object)userBiddingModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetItemPriceUnitList(
          int? keyType,
          int? mainKey,
          int? subKey,
          bool? isUp)
        {
            ItemPriceInfoModel itemPriceInfoModel = new ItemPriceInfoModel();
            TradeMarketItemInfo _itemStaticStatus = (TradeMarketItemInfo)null;
            long num1 = 0;
            try
            {
                if (mainKey.Value <= 0)
                {
                    LogUtil.WriteLog(string.Format("[Item Error] GetItemPriceUnitList({0}, {1}, {2}) [mainKey <= 0]", (object)keyType, (object)mainKey, (object)subKey), "WARN");
                    itemPriceInfoModel.resultCode = 8;
                    itemPriceInfoModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                    return this.Json((object)itemPriceInfoModel);
                }
                _itemStaticStatus = ItemInfoManager.This().getInfo(mainKey.Value, subKey.Value);
                if (!_itemStaticStatus.isValid())
                {
                    LogUtil.WriteLog(string.Format("[Item Error] GetItemPriceUnitList({0}, {1}, {2}) ItemInfo() Not Exist ItemInfo ", (object)keyType, (object)mainKey, (object)subKey), "WARN");
                    itemPriceInfoModel.resultCode = 8;
                    itemPriceInfoModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                    return this.Json((object)itemPriceInfoModel);
                }
                CommonDBResult<uspListWorldMarketDetail_Result> commonDbResult = WebDBManager.ListWorldMarketDetail(KeyType.eItem, _itemStaticStatus._mainKey, false);
                if (commonDbResult.resultCode != 0)
                {
                    itemPriceInfoModel.resultCode = commonDbResult.resultCode;
                    itemPriceInfoModel.resultMsg = CommonModule.GetResourceValue(commonDbResult.resultMsg);
                    return this.Json((object)itemPriceInfoModel);
                }
                num1 = commonDbResult.list.Where<uspListWorldMarketDetail_Result>((Func<uspListWorldMarketDetail_Result, bool>)(x => x.C_subKey == _itemStaticStatus._subKey)).FirstOrDefault<uspListWorldMarketDetail_Result>().C_pricePerOne.Value;
                if (num1 < 0L)
                {
                    LogUtil.WriteLog(string.Format("[Item Error] GetItemPriceUnitList({0}, {1}, {2})) [basePrice < 0]", (object)keyType, (object)mainKey, (object)subKey), "WARN");
                    itemPriceInfoModel.resultCode = 14;
                    itemPriceInfoModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_PRICE_WORNG");
                    return this.Json((object)itemPriceInfoModel);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Exception] GetAddEnchantLevelPrice({0}, {1}, {2}) Exception : {3}", (object)keyType, (object)mainKey, (object)subKey, (object)ex.ToString()), "ERROR");
            }
            int index1;
            int num2;
            if (isUp.Value)
            {
                index1 = VariedPriceInfoManager.This().getPriceUnitList().IndexOf(num1);
                num2 = VariedPriceInfoManager.This().getPriceUnitList().IndexOf(VariedPriceInfoManager.This().calculatePrice((long)((double)num1 * (1.0 + WorldMarketOptionManager.This().BiddingRatio)), "UP")) + 1;
            }
            else
            {
                index1 = VariedPriceInfoManager.This().getPriceUnitList().IndexOf(VariedPriceInfoManager.This().calculatePrice((long)((double)num1 * (1.0 - WorldMarketOptionManager.This().BiddingRatio)), "DOWN"));
                num2 = VariedPriceInfoManager.This().getPriceUnitList().IndexOf(num1) + 1;
            }
            if (num2 - index1 < 0 || index1 < 0 || num2 < 0)
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetItemPriceUnitList({0}, {1}, {2})) [end({3}) - start({4}) < 0]", (object)keyType, (object)mainKey, (object)subKey, (object)num2, (object)index1), "WARN");
                itemPriceInfoModel.resultCode = 14;
                itemPriceInfoModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_PRICE_WORNG");
                return this.Json((object)itemPriceInfoModel);
            }
            itemPriceInfoModel.priceList = VariedPriceInfoManager.This().getPriceUnitList().GetRange(index1, num2 - index1);
            int index2 = VariedPriceInfoManager.This().getPriceUnitList().IndexOf(VariedPriceInfoManager.This().calculatePrice((long)((double)num1 * (1.0 - WorldMarketOptionManager.This().BiddingRatio)), "DOWN"));
            int num3 = VariedPriceInfoManager.This().getPriceUnitList().IndexOf(VariedPriceInfoManager.This().calculatePrice((long)((double)num1 * (1.0 + WorldMarketOptionManager.This().BiddingRatio)), "UP"));
            List<long> range = VariedPriceInfoManager.This().getPriceUnitList().GetRange(index2, num3 - index2);
            itemPriceInfoModel.marketConditionList = new List<BiddingInfoModel>();
            CommonDBResult<uspListBiddingInfo_Result> commonDbResult1 = WebDBManager.ListBiddingInfo(keyType, mainKey, subKey, _itemStaticStatus._enchantMaterialKey, WorldMarketOptionManager.This().BiddingRatio);
            if (commonDbResult1.resultCode != 0)
            {
                itemPriceInfoModel.resultCode = commonDbResult1.resultCode;
                itemPriceInfoModel.resultMsg = CommonModule.GetResourceValue(commonDbResult1.resultMsg);
                return this.Json((object)itemPriceInfoModel);
            }
            foreach (long num4 in range)
            {
                long num5 = 0;
                long num6 = 0;
                foreach (uspListBiddingInfo_Result biddingInfoResult in commonDbResult1.list)
                {
                    if (biddingInfoResult.C_pricePerOne == num4)
                    {
                        num5 = biddingInfoResult.C_sellCount;
                        num6 = biddingInfoResult.C_buyCount;
                        break;
                    }
                }
                itemPriceInfoModel.marketConditionList.Add(new BiddingInfoModel()
                {
                    sellCount = num5,
                    buyCount = num6,
                    pricePerOne = num4
                });
            }
            return this.Json((object)itemPriceInfoModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetWorldMarketSearchList(string searchText)
        {
            MarketSearchResultModel searchResultModel = new MarketSearchResultModel();
            CommonDBResult<uspSearchListWorldMarket_Result> commonDbResult = (CommonDBResult<uspSearchListWorldMarket_Result>)null;
            StringBuilder stringBuilder = new StringBuilder();
            string empty = string.Empty;
            int num = 0;
            if (string.IsNullOrEmpty(searchText) || searchText.Length < 1)
            {
                searchResultModel.resultCode = 2001;
                searchResultModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_INVALID_SEARCH_TEXT");
                return this.Json((object)searchResultModel);
            }
            foreach (KeyValuePair<string, string> itemString in StringManager.This().ItemStringList)
            {
                if (itemString.Value.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    if (999 < stringBuilder.Length + string.Format("{0},", (object)itemString.Key).Length)
                    {
                        if (0 < num)
                            commonDbResult.list.AddRange((IEnumerable<uspSearchListWorldMarket_Result>)WebDBManager.SearchListWorldMarket(stringBuilder.ToString()).list);
                        else
                            commonDbResult = WebDBManager.SearchListWorldMarket(stringBuilder.ToString());
                        ++num;
                        stringBuilder.Length = 0;
                        stringBuilder.Append(string.Format("{0},", (object)itemString.Key));
                    }
                    else
                        stringBuilder.Append(string.Format("{0},", (object)itemString.Key));
                }
            }
            if (0 < num)
                commonDbResult.list.AddRange((IEnumerable<uspSearchListWorldMarket_Result>)WebDBManager.SearchListWorldMarket(stringBuilder.ToString()).list);
            else
                commonDbResult = WebDBManager.SearchListWorldMarket(stringBuilder.ToString());
            searchResultModel.resultCode = commonDbResult.resultCode;
            searchResultModel.resultMsg = commonDbResult.resultMsg;
            if (searchResultModel.resultCode != 0)
                return this.Json((object)searchResultModel);
            if (commonDbResult.list.Count == 0)
            {
                searchResultModel.resultMsg = "0";
                return this.Json((object)searchResultModel);
            }
            foreach (uspSearchListWorldMarket_Result worldMarketResult in commonDbResult.list)
            {
                string str = StringManager.This().ItemName(worldMarketResult.C_mainKey);
                if (!string.IsNullOrEmpty(str) && !str.Equals("-"))
                    searchResultModel.list.Add(new MarketSearchInfoModel()
                    {
                        mainKey = worldMarketResult.C_mainKey,
                        sumCount = Convert.ToInt64((object)worldMarketResult.C_sumCount),
                        totalSumCount = Convert.ToInt64((object)worldMarketResult.C_pricePerOne),
                        name = str,
                        grade = ItemInfoManager.This().getInfo(worldMarketResult.C_mainKey, 0)._grade
                    });
            }
            return this.Json((object)searchResultModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetItemSellBuyInfo(
          int keyType,
          int mainKey,
          int subKey,
          bool isUp)
        {
            ItemSellBuyInfoModel sellBuyInfoModel = new ItemSellBuyInfoModel();
            TradeMarketItemInfo _itemStaticStatus = (TradeMarketItemInfo)null;
            ItemPriceInfoModel itemPriceInfoModel = new ItemPriceInfoModel();
            WorldMarketSubOneModel marketSubOneModel = new WorldMarketSubOneModel();
            List<long> longList = new List<long>();
            uspListWorldMarketDetail_Result marketDetailResult1 = new uspListWorldMarketDetail_Result();
            List<uspListWorldMarketDetail_Result> marketDetailResultList = new List<uspListWorldMarketDetail_Result>();
            try
            {
                _itemStaticStatus = ItemInfoManager.This().getInfo(mainKey, subKey);
                if (!_itemStaticStatus.isValid())
                {
                    LogUtil.WriteLog(string.Format("[Item Error] GetItemSellBuyInfo({0}, {1}, {2}) ItemInfo({3}, {4}) Not Exist ItemInfo ", (object)keyType, (object)mainKey, (object)subKey, (object)mainKey, (object)subKey), "WARN");
                    sellBuyInfoModel.resultCode = 8;
                    sellBuyInfoModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                    return this.Json((object)sellBuyInfoModel);
                }
                ItemPriceInfoModel data1 = (ItemPriceInfoModel)this.GetItemPriceUnitList(new int?(keyType), new int?(mainKey), new int?(_itemStaticStatus._enchantGroup), new bool?(isUp)).Data;
                if (data1.resultCode != 0)
                {
                    sellBuyInfoModel.resultCode = data1.resultCode;
                    sellBuyInfoModel.resultMsg = CommonModule.GetResourceValue(data1.resultMsg);
                    return this.Json((object)sellBuyInfoModel);
                }
                if (0 < data1.priceList.Count)
                    sellBuyInfoModel.priceList = data1.priceList;
                WorldMarketSubOneModel data2 = (WorldMarketSubOneModel)this.GetWorldMarketSubOne(new int?(mainKey), new int?(subKey)).Data;
                if (data2.resultCode != 0)
                {
                    sellBuyInfoModel.resultCode = data2.resultCode;
                    sellBuyInfoModel.resultMsg = CommonModule.GetResourceValue(data2.resultMsg);
                    return this.Json((object)sellBuyInfoModel);
                }
                sellBuyInfoModel.enchantGroup = data2.enchantGroup;
                sellBuyInfoModel.enchantMaxGroup = data2.enchantMaxGroup;
                sellBuyInfoModel.basePrice = data2.pricePerOneValue;
                sellBuyInfoModel.maxRegisterForWorldMarket = _itemStaticStatus._maxRegisterForWorldMarket;
                sellBuyInfoModel.sellMaxCount = data2.countValue;
                sellBuyInfoModel.buyMaxCount = data2.countValue;
                if (0 < _itemStaticStatus._enchantMaterialKey)
                {
                    uspListWorldMarketDetail_Result marketDetailResult2 = WebDBManager.ListWorldMarketDetail(KeyType.eItem, _itemStaticStatus._enchantMaterialKey, true).list.Where<uspListWorldMarketDetail_Result>((Func<uspListWorldMarketDetail_Result, bool>)(x => x.C_mainKey == _itemStaticStatus._enchantMaterialKey)).FirstOrDefault<uspListWorldMarketDetail_Result>();
                    if (marketDetailResult2 != null)
                    {
                        sellBuyInfoModel.enchantMaterialKey = _itemStaticStatus._enchantMaterialKey;
                        sellBuyInfoModel.enchantNeedCount = _itemStaticStatus._enchantNeedCount;
                        sellBuyInfoModel.enchantMaterialPrice = marketDetailResult2.C_pricePerOne.Value;
                    }
                    else
                    {
                        sellBuyInfoModel.enchantMaterialKey = 0;
                        sellBuyInfoModel.enchantNeedCount = 0L;
                        sellBuyInfoModel.enchantMaterialPrice = 0L;
                    }
                }
                List<long> biddingList = VariedPriceInfoManager.This().getBiddingList(sellBuyInfoModel.basePrice, WorldMarketOptionManager.This().BiddingRatio, _itemStaticStatus);
                CommonDBResult<uspGetMarketPriceInfo_Result> commonDbResult1 = WebDBManager.WorldMarketPriceInfo(new int?(keyType), new int?(mainKey), new int?(subKey));
                DateTime customTime = CommonModule.GetCustomTime();
                long[] numArray1 = new long[90];
                numArray1.Initialize();
                if (commonDbResult1.list.Count == 0)
                {
                    for (int index = 0; index < numArray1.Length; ++index)
                        numArray1[index] = sellBuyInfoModel.basePrice;
                }
                else
                {
                    for (int index = 0; index < commonDbResult1.list.Count; ++index)
                    {
                        TimeSpan timeSpan = customTime - commonDbResult1.list[index].C_datetime.Value;
                        if (timeSpan.Days < numArray1.Length)
                        {
                            long[] numArray2 = numArray1;
                            numArray2[numArray2.Length - 1 - timeSpan.Days] = commonDbResult1.list[index].C_price;
                        }
                    }
                    long num1 = 0;
                    long num2 = 0;
                    for (int index1 = numArray1.Length - 1; 0 <= index1; --index1)
                    {
                        if (numArray1[index1] == 0L)
                        {
                            ++num2;
                        }
                        else
                        {
                            for (int index2 = 0; (long)index2 < num2; ++index2)
                                numArray1[index1 + index2 + 1] = numArray1[index1];
                            num1 = numArray1[index1];
                            num2 = 0L;
                        }
                    }
                    for (int index = 0; (long)index < num2; ++index)
                        numArray1[index] = num1;
                }
                for (int index = 0; index < numArray1.Length; ++index)
                {
                    sellBuyInfoModel.resultMsg += Convert.ToString(numArray1[index]);
                    if (index != numArray1.Length - 1)
                        sellBuyInfoModel.resultMsg += "-";
                }
                List<PriceDataModel> priceDataModelList = new List<PriceDataModel>();
                string[] source = sellBuyInfoModel.resultMsg.Split('-');
                DateTime dateTime1 = DateTime.UtcNow;
                DateTime dateTime2 = dateTime1.AddDays(-90.0);
                for (int index = 0; index < ((IEnumerable<string>)source).Count<string>() - 1; ++index)
                {
                    PriceDataModel priceDataModel1 = new PriceDataModel();
                    PriceDataModel priceDataModel2 = priceDataModel1;
                    dateTime1 = dateTime2.AddDays((double)index);
                    string str = dateTime1.ToString("yyyy-MM-dd");
                    priceDataModel2.days = str;
                    priceDataModel1.value = Convert.ToInt64(source[index]);
                    priceDataModelList.Add(priceDataModel1);
                }
                sellBuyInfoModel.resultMsg = JsonConvert.SerializeObject((object)priceDataModelList);
                sellBuyInfoModel.marketConditionList = new List<BiddingInfoModel>();
                CommonDBResult<uspListBiddingInfo_Result> commonDbResult2 = WebDBManager.ListBiddingInfo(new int?(keyType), new int?(mainKey), new int?(subKey), _itemStaticStatus._enchantMaterialKey, WorldMarketOptionManager.This().BiddingRatio);
                if (commonDbResult2.resultCode != 0)
                {
                    sellBuyInfoModel.resultCode = commonDbResult2.resultCode;
                    sellBuyInfoModel.resultMsg = CommonModule.GetResourceValue(commonDbResult2.resultMsg);
                    return this.Json((object)sellBuyInfoModel);
                }
                foreach (long num3 in biddingList)
                {
                    long num4 = 0;
                    long num5 = 0;
                    foreach (uspListBiddingInfo_Result biddingInfoResult in commonDbResult2.list)
                    {
                        if (biddingInfoResult.C_pricePerOne == num3)
                        {
                            num4 += biddingInfoResult.C_sellCount;
                            num5 += biddingInfoResult.C_buyCount;
                        }
                    }
                    sellBuyInfoModel.marketConditionList.Add(new BiddingInfoModel()
                    {
                        sellCount = num4,
                        buyCount = num5,
                        pricePerOne = num3
                    });
                }
                bool result = false;
                if (ConstantMgr._serviceType.ToLower().Equals("dev").Equals(true))
                {
                    AuthenticationInfo authInfo = AuthenticateManager.GetAuthInfo();
                    sellBuyInfoModel.resultCode = TradeModule.isOTPCheckItem(keyType, mainKey, subKey, out result);
                    if (sellBuyInfoModel.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[Item Error]GetItemSellBuyInfo({0}, {1}, {2}) otpitem check resultCode : {3}", (object)keyType, (object)mainKey, (object)subKey, (object)sellBuyInfoModel.resultCode), "WARN");
                        sellBuyInfoModel.resultCode = 8;
                        sellBuyInfoModel.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                        return this.Json((object)sellBuyInfoModel);
                    }
                    if (result)
                        result = CommonModule.CheckLastOtpTime(new CheckOtpParamModel()
                        {
                            userNo = authInfo.userInfoModel._userNo,
                            worldNo = authInfo.userInfoModel._worldNo,
                            nationCode = authInfo.userInfoModel._nationCode
                        }) & result;
                }
                sellBuyInfoModel.isWaitItem = result;
            }
            catch (Exception ex)
            {
                sellBuyInfoModel.resultCode = -9999;
                LogUtil.WriteLog(string.Format("[Exception Error]GetItemSellBuyInfo() mainKey={0} | subKey={1} \nException Error={2}", (object)mainKey, (object)subKey, (object)ex.ToString()), "ERROR");
            }
            return this.Json((object)sellBuyInfoModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SetLanguage(string lang)
        {
            CookieLib.Delete(ConstantMgr._cookieDomain, "tradeHistory");
            CommonModule.SetUserCulture(lang);
            return (ActionResult)this.Redirect("/");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult ConfirmSecondPwd(string secondPwd)
        {
            AuthenticationInfo AuthenticationInfo = (AuthenticationInfo)null;
            CommonResult commonResult = new CommonResult();
            string empty = string.Empty;
            int num = -99;
            try
            {
                using (TradeWORLDDB tradeWorlddb = new TradeWORLDDB())
                {
                    ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
                    AuthenticationInfo = AuthenticateManager.GetAuthInfo();
                    tradeWorlddb.uspCheckSecondPwd(new long?(AuthenticationInfo.userInfoModel._userNo), secondPwd, resultCode);
                    num = Convert.ToInt32(resultCode.Value);
                }
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    ObjectParameter failCount = new ObjectParameter("failCount", typeof(int));
                    tradeWebDb.uspGetSecondPwdInfo(new int?(AuthenticationInfo.userInfoModel._worldNo), new long?(AuthenticationInfo.userInfoModel._userNo), new bool?(false), failCount);
                    if (Convert.ToInt32(failCount.Value) >= 5)
                    {
                        commonResult.resultCode = 1;
                        commonResult.resultMsg = "TRADE_MARKET_SECONDPWD_RETRY";
                        return this.Json((object)commonResult);
                    }
                    if (num.Equals(0))
                    {
                        AuthenticationInfo.userInfoModel._secondPwdPass = true;
                        AuthenticateManager.Authenticate(AuthenticationInfo);
                        commonResult.resultCode = 0;
                        commonResult.resultMsg = "Success";
                    }
                    else
                    {
                        tradeWebDb.uspGetSecondPwdInfo(new int?(AuthenticationInfo.userInfoModel._worldNo), new long?(AuthenticationInfo.userInfoModel._userNo), new bool?(true), failCount);
                        commonResult.resultCode = 1;
                        commonResult.resultMsg = "TRADE_MARKET_SECONDPWD_FAIL";
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Error]HomeController ConfirmSecondPwd() Exception Error={0}", (object)ex.ToString()), "ERROR");
                commonResult.resultCode = -99999;
                commonResult.resultMsg = "TRADE_MARKET_ERROR_MSG_EXCEPTION";
                return this.Json((object)commonResult);
            }
            return this.Json((object)commonResult);
        }

        [HttpPost]
        public JsonResult OtpUseCheck(string userId = "")
        {
            CommonResult commonResult = (CommonResult)null;
            string empty = string.Empty;
            CommonResult json;
            try
            {
                AuthenticationInfo authInfo = AuthenticateManager.GetAuthInfo();
                commonResult = new CommonResult();
                if (authInfo.IsNull<AuthenticationInfo>())
                {
                    commonResult.resultCode = -1001;
                    commonResult.resultMsg = "TRADE_MARKET_ERROR_MSG_UNAUTHORIZED";
                }
                string str = ConstantMgr._authCheckRequestUri.Replace("/TradeAuth?authToken=", "");
                OtpCheckParamModel deserializeObject = new OtpCheckParamModel()
                {
                    _accountNo = authInfo.accountNo
                };
                ProxySettingModel proxyData = new ProxySettingModel(Convert.ToBoolean(ConstantMgr._isUseProxy), ConstantMgr._webProxyUrl, ConstantMgr._webProxyPort, true);
                HttpRequestResult httpRequestResult = CommonModule.HttpRequest(new HttpRequestModel(string.Format("{0}/TradeOtpCheck", (object)str), CommonModule.SerializeObjectToJsonString<OtpCheckParamModel>(deserializeObject), "POST", "application/json"), proxyData);
                if (httpRequestResult._resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("HomeController OtpUseCheck Requset Fail  response._resultCode : {0}", (object)httpRequestResult._resultCode), "WARN");
                    commonResult.resultCode = -10003;
                    commonResult.resultMsg = string.Empty;
                    return this.Json((object)commonResult);
                }
                if (string.IsNullOrEmpty(httpRequestResult._resultData))
                {
                    LogUtil.WriteLog("HomeController OtpUseCheck Requset Fail  response._resultData Is NULL", "WARN");
                    commonResult.resultCode = -10004;
                    commonResult.resultMsg = string.Empty;
                    return this.Json((object)commonResult);
                }
                json = CommonModule.DeserializeOjectToJson<CommonResult>(httpRequestResult._resultData);
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Error]HomeController OtpUseCheck() Exception Error={0}", (object)ex.ToString()), "ERROR");
                commonResult.resultCode = -9999;
                commonResult.resultMsg = "TRADE_MARKET_ERROR_MSG_EXCEPTION";
                return this.Json((object)commonResult);
            }
            return this.Json((object)json);
        }
    }
}
