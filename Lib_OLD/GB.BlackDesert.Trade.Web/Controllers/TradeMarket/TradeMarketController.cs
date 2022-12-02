// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Controllers.TradeMarket.TradeMarketController
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Common.Compression;
using GB.BlackDesert.Trade.Web.Lib.DB;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using GB.BlackDesert.Trade.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.Controllers.TradeMarket
{
    public class TradeMarketController : Controller
    {
        private CommonResult CheckAuthKeyToView(
          long userNo,
          string certifiedKey,
          ViewAuthType type,
          ref ViewUserAuthResultModel userInfo)
        {
            CommonResult view = new CommonResult();
            ViewUserAuthModel viewUserAuthModel = new ViewUserAuthModel();
            string errorMsg = string.Empty;
            string relResult = string.Empty;
            viewUserAuthModel.userNo = userNo;
            viewUserAuthModel.certifiedKey = certifiedKey;
            viewUserAuthModel.type = (int)type;
            view.resultCode = CommonModule.HttpRequest(ConstantMgr._gameDomain + "/CheckAuthKeyToView", JsonConvert.SerializeObject((object)viewUserAuthModel), "POST", "text/json", out relResult, out errorMsg, isWriteLog: false);
            if (view.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CheckAuthKeyToView({0}) - HttpRequest CheckAuthKeyToView errorMsg : {1}", (object)JsonConvert.SerializeObject((object)viewUserAuthModel), (object)errorMsg), "WARN");
                view.resultCode = 2;
                view.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return view;
            }
            userInfo = JsonConvert.DeserializeObject<ViewUserAuthResultModel>(relResult);
            if (userInfo == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CheckAuthKeyToView({0}) - HttpRequest CheckAuthKeyToView result : userInfo null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)userInfo), (object)errorMsg), "WARN");
                view.resultCode = 5;
                view.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return view;
            }
            if (userInfo.result.resultCode == 0)
                return view;
            LogUtil.WriteLog(string.Format("[Http Error]CheckAuthKeyToView({0}) - HttpRequest CheckAuthKeyToView result : resultCode  {1}", (object)JsonConvert.SerializeObject((object)userInfo), (object)userInfo.result.resultCode), "WARN");
            view.resultCode = userInfo.result.resultCode;
            view.resultMsg = userInfo.result.resultMsg;
            return view;
        }

        [HttpPost]
        public ActionResult GetMyWalletList(ViewUserAuthModel authInfo)
        {
            CommonDBResult<uspListWorldMarketMyWallet_Result> commonDbResult1 = new CommonDBResult<uspListWorldMarketMyWallet_Result>();
            CommonDBResult<uspPersonalTradeList_Result> commonDbResult2 = new CommonDBResult<uspPersonalTradeList_Result>();
            CommonResult commonResult1 = new CommonResult();
            CommonResult commonResult2 = new CommonResult();
            ViewUserAuthResultModel userInfo = new ViewUserAuthResultModel();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetMyWalletList Fail is Not Open"), "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return (ActionResult)this.Json((object)commonResult1);
            }
            CommonResult view = this.CheckAuthKeyToView(authInfo.userNo, authInfo.certifiedKey, ViewAuthType.eViewAuthType_WalletList, ref userInfo);
            if (view.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]GetMyWalletList({0}) - errorCode : {1}", (object)JsonConvert.SerializeObject((object)authInfo), (object)view.resultCode), "WARN");
                return (ActionResult)this.Json((object)view);
            }
            CommonDBResult<uspListWorldMarketMyWallet_Result> commonDbResult3 = WebDBManager.ListWorldMarketMyWallet(new int?(userInfo.nationCode), new int?(userInfo.worldNo), new long?(userInfo.userNo));
            view.resultCode = commonDbResult3.resultCode;
            view.resultMsg = commonDbResult3.resultMsg;
            if (view.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Error] GetMyWalletList - ListWorldMarketMyWallet({0}/{1}/{2}) resultCode : {3}", (object)userInfo.nationCode, (object)userInfo.worldNo, (object)userInfo.userNo, (object)view.resultCode), "WARN");
                return (ActionResult)this.Json((object)view);
            }
            CommonDBResult<uspPersonalTradeList_Result> commonDbResult4 = WebDBManager.PersonalTradeList(new int?(userInfo.nationCode), new int?(userInfo.worldNo), new long?(userInfo.userNo));
            view.resultCode = commonDbResult4.resultCode;
            view.resultMsg = commonDbResult4.resultMsg;
            if (view.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Error] GetMyWalletList - PersonalTradeList({0}/{1}/{2}) resultCode : {3}", (object)userInfo.nationCode, (object)userInfo.worldNo, (object)userInfo.userNo, (object)view.resultCode), "WARN");
                return (ActionResult)this.Json((object)view);
            }
            view.resultCode = 0;
            long totalWeight = 0;
            if (commonDbResult3.list.Count == 0 && commonDbResult4.list.Count == 0)
            {
                view.resultMsg = "0+0";
            }
            else
            {
                for (int index = 0; index < commonDbResult3.list.Count; ++index)
                {
                    switch ((KeyType)commonDbResult3.list[index].C_keyType)
                    {
                        case KeyType.eItem:
                            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(commonDbResult3.list[index].C_mainKey, commonDbResult3.list[index].C_subKey);
                            if (!info.isValid() && 1 != commonDbResult3.list[index].C_mainKey)
                            {
                                LogUtil.WriteLog(string.Format("[Normal Error] GetMyWalletList - Process Work : Continue({0}, {1}, {2}) itemInfo({3}, {4})", (object)userInfo.nationCode, (object)userInfo.worldNo, (object)userInfo.userNo, (object)commonDbResult3.list[index].C_mainKey, (object)commonDbResult3.list[index].C_subKey), "WARN");
                                break;
                            }
                            long weight1 = info._weight;
                            totalWeight += weight1 * commonDbResult3.list[index].C_count;
                            view.resultMsg = view.resultMsg + Convert.ToString(commonDbResult3.list[index].C_keyType) + "_" + Convert.ToString(commonDbResult3.list[index].C_mainKey) + "_" + Convert.ToString(commonDbResult3.list[index].C_subKey) + "_" + Convert.ToString(commonDbResult3.list[index].C_isSealed) + "_" + Convert.ToString(commonDbResult3.list[index].C_count);
                            if (index < commonDbResult3.list.Count - 1)
                            {
                                view.resultMsg += "|";
                                break;
                            }
                            break;
                        case KeyType.eServant:
                            TradeMarketItemInfo servantInfo = ItemInfoManager.This().getServantInfo(commonDbResult3.list[index].C_mainKey, commonDbResult3.list[index].C_subKey);
                            if (!servantInfo.isValid())
                            {
                                LogUtil.WriteLog(string.Format("[Normal Error] GetMyWalletList - Process Work : Continue({0}, {1}, {2}) ", (object)userInfo.nationCode, (object)userInfo.worldNo, (object)userInfo.userNo) + string.Format("servantInfo({0}, {1})", (object)commonDbResult3.list[index].C_mainKey, (object)commonDbResult3.list[index].C_subKey), "WARN");
                                break;
                            }
                            long weight2 = servantInfo._weight;
                            totalWeight += weight2 * commonDbResult3.list[index].C_count;
                            view.resultMsg = view.resultMsg + Convert.ToString(commonDbResult3.list[index].C_keyType) + "_" + Convert.ToString(commonDbResult3.list[index].C_mainKey) + "_" + Convert.ToString(commonDbResult3.list[index].C_subKey) + "_" + Convert.ToString(commonDbResult3.list[index].C_isSealed) + "_" + Convert.ToString(commonDbResult3.list[index].C_count);
                            if (index < commonDbResult3.list.Count - 1)
                            {
                                view.resultMsg += "|";
                                break;
                            }
                            break;
                        default:
                            LogUtil.WriteLog(string.Format("[Normal Error] GetMyWalletList - do not have a key{0} : Continue({1}, {2}, {3}) ", (object)commonDbResult3.list[index].C_keyType, (object)userInfo.nationCode, (object)userInfo.worldNo, (object)userInfo.userNo) + string.Format("itemInfo({0}, {1})", (object)commonDbResult3.list[index].C_mainKey, (object)commonDbResult3.list[index].C_subKey), "WARN");
                            view.resultCode = 8;
                            view.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                            return (ActionResult)this.Json((object)view);
                    }
                }
                if (commonDbResult3.list.Count == 0)
                    view.resultMsg += "0";
                view.resultMsg += "+";
                for (int index = 0; index < commonDbResult4.list.Count; ++index)
                {
                    view.resultMsg = view.resultMsg + Convert.ToString(commonDbResult4.list[index].C_marketNo) + "_" + Convert.ToString(commonDbResult4.list[index].C_mainKey) + "_" + Convert.ToString(commonDbResult4.list[index].C_subKey) + "_" + Convert.ToString(commonDbResult4.list[index].C_pricePerOne) + "_" + Convert.ToString(commonDbResult4.list[index].C_count) + "_" + Convert.ToString(commonDbResult4.list[index].C_toNationCode) + "_" + Convert.ToString(commonDbResult4.list[index].C_toServerNo) + "_" + Convert.ToString(commonDbResult4.list[index].C_toUserNo) + "_" + Convert.ToString(commonDbResult4.list[index].C_userNickName);
                    if (index < commonDbResult4.list.Count - 1)
                        view.resultMsg += "|";
                }
                if (commonDbResult4.list.Count == 0)
                    view.resultMsg += "0";
            }
            CommonResult commonResult3 = WebDBManager.UpdateMyWalletWeight(new int?(userInfo.nationCode), new int?(userInfo.worldNo), new long?(userInfo.userNo), totalWeight);
            if (commonResult3.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[DB Error]GetMyWalletList - uspUpdateMyWalletWeight({0}/{1}/{2}/{3}), rv({4})", (object)userInfo.nationCode, (object)userInfo.worldNo, (object)userInfo.userNo, (object)totalWeight, (object)commonResult3.resultCode), "WARN");
                view.resultCode = commonResult3.resultCode;
                view.resultMsg = commonResult3.resultMsg;
                return (ActionResult)this.Json((object)view);
            }
            int itemLimitedMaxCount = WorldMarketOptionManager.This().getPearlItemLimitedMaxCount();
            int addPearlItemLimitedCount = 0;
            int currentPearlItemLimitedCount = 0;
            long addWeight = 0;
            int ringBuffCount = 0;
            WebDBManager.getPearlItemTradeCount(new int?(userInfo.nationCode), new int?(userInfo.worldNo), new long?(userInfo.userNo), out addPearlItemLimitedCount, out currentPearlItemLimitedCount, out addWeight, out ringBuffCount);
            int lastOtpTimeUtc = CommonModule.GetLastOtpTimeUtc(new CheckOtpParamModel()
            {
                userNo = userInfo.userNo,
                worldNo = userInfo.worldNo,
                nationCode = userInfo.nationCode
            });
            view.resultMsg += "+";
            view.resultMsg = view.resultMsg + Convert.ToString(totalWeight) + "_" + Convert.ToString(WorldMarketOptionManager.This().getMaxWeight()) + "_" + Convert.ToString(itemLimitedMaxCount) + "_" + Convert.ToString(addPearlItemLimitedCount) + "_" + Convert.ToString(currentPearlItemLimitedCount) + "_" + Convert.ToString(addWeight) + "_" + Convert.ToString(ringBuffCount) + "_" + Convert.ToString(lastOtpTimeUtc);
            return ConstantMgr._isCompression ? (ActionResult)this.File(CompressionModule.HaffmanCompression(view.resultMsg), "application/octet-stream") : (ActionResult)this.Json((object)view);
        }

        [HttpPost]
        public JsonResult GetMyWallet(
          long? userNo,
          string certifiedKey,
          int? keyType,
          int? mainKey,
          int? subKey,
          bool? isSealed)
        {
            string empty = string.Empty;
            CommonResult commonResult1 = new CommonResult();
            ViewUserAuthResultModel userInfo = new ViewUserAuthResultModel();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetMyWallet Fail is Not Open"), "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult view = this.CheckAuthKeyToView(userNo.Value, certifiedKey, ViewAuthType.eViewAuthType_WalletOne, ref userInfo);
            if (view.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]GetMyWallet({0}, {1}) - errorCode : {2}", (object)userNo.Value, (object)certifiedKey, (object)view.resultCode), "WARN");
                return this.Json((object)view);
            }
            CommonResult commonResult2 = WebDBManager.WorldMarketMyWallet(new int?(userInfo.nationCode), new int?(userInfo.worldNo), new long?(userInfo.userNo), keyType, mainKey, subKey, isSealed, ref empty);
            if (commonResult2.resultCode != 0)
                return this.Json((object)commonResult2);
            commonResult2.resultCode = 0;
            commonResult2.resultMsg = Convert.ToString((object)keyType) + "_" + Convert.ToString((object)mainKey) + "_" + Convert.ToString((object)subKey) + "_" + Convert.ToString((object)isSealed) + "_" + Convert.ToString(empty);
            return this.Json((object)commonResult2);
        }

        [HttpPost]
        public ActionResult GetWorldMarketList(GetWorldMarketListModel model)
        {
            CommonResult commonResult = new CommonResult();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetWorldMarketList Fail is Not Open"), "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return (ActionResult)this.Json((object)commonResult);
            }
            CommonResult stockListByCategory;
            switch ((KeyType)model.keyType)
            {
                case KeyType.eItem:
                    if (model.subCategory == 0)
                    {
                        commonResult.resultMsg = "0";
                        return (ActionResult)this.Json((object)commonResult);
                    }
                    stockListByCategory = WorldMarketItemInfoManager.This().GetStockListByCategory(model.mainCategory, model.subCategory);
                    break;
                case KeyType.eServant:
                    stockListByCategory = WorldMarketServantInfoManager.This().GetStockListByCategory(model.mainCategory, model.subCategory);
                    break;
                default:
                    commonResult.resultCode = 2;
                    commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                    return (ActionResult)this.Json((object)commonResult);
            }
            return ConstantMgr._isCompression ? (ActionResult)this.File(CompressionModule.HaffmanCompression(stockListByCategory.resultMsg), "application/octet-stream") : (ActionResult)this.Json((object)stockListByCategory);
        }

        [HttpPost]
        public JsonResult GetWorldMarketSearchList(string searchResult)
        {
            CommonDBResult<uspSearchListWorldMarket_Result> commonDbResult1 = new CommonDBResult<uspSearchListWorldMarket_Result>();
            TradeMarketList tradeMarketList = new TradeMarketList();
            CommonResult commonResult = new CommonResult();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetWorldMarketSearchList Fail is Not Open"), "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            if (0 >= searchResult.Length || searchResult.Length >= 1000)
            {
                LogUtil.WriteLog(string.Format("[String Error]GetWorldMarketSearchList({0})", (object)searchResult), "WARN");
                commonResult.resultCode = 21;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_StringOver");
                return this.Json((object)commonResult);
            }
            CommonDBResult<uspSearchListWorldMarket_Result> commonDbResult2 = WebDBManager.SearchListWorldMarket(searchResult);
            commonResult.resultCode = commonDbResult2.resultCode;
            commonResult.resultMsg = commonDbResult2.resultMsg;
            if (commonResult.resultCode != 0)
                return this.Json((object)commonResult);
            commonResult.resultCode = 0;
            if (commonDbResult2.list.Count == 0)
            {
                commonResult.resultMsg = "0";
            }
            else
            {
                for (int index = 0; index < commonDbResult2.list.Count; ++index)
                {
                    commonResult.resultMsg = commonResult.resultMsg + Convert.ToString(commonDbResult2.list[index].C_mainKey) + "-" + Convert.ToString((object)commonDbResult2.list[index].C_sumCount) + "-" + Convert.ToString((object)commonDbResult2.list[index].C_pricePerOne) + "-" + Convert.ToString((object)commonDbResult2.list[index].C_totalTradeCount);
                    if (index < commonDbResult2.list.Count - 1)
                        commonResult.resultMsg += "|";
                }
            }
            return this.Json((object)commonResult);
        }

        [HttpPost]
        public JsonResult GetWorldMarketSubList(GetWorldMarketSubListModel model)
        {
            CommonResult commonResult = new CommonResult();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetWorldMarketSubList Fail is Not Open"), "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            CommonResult subListBystockKey;
            switch ((KeyType)model.keyType)
            {
                case KeyType.eItem:
                    subListBystockKey = WorldMarketItemInfoManager.This().GetStockSubListBystockKey(model.mainKey);
                    break;
                case KeyType.eServant:
                    subListBystockKey = WorldMarketServantInfoManager.This().GetStockSubListBystockKey(model.mainKey);
                    break;
                default:
                    commonResult.resultCode = 2;
                    commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                    return this.Json((object)commonResult);
            }
            return this.Json((object)subListBystockKey);
        }

        [HttpPost]
        public JsonResult GetWorldMarketSubListByCategory(int? mainCategory, int? subCategory)
        {
            TradeMarketListDetailByCategory updateList = new TradeMarketListDetailByCategory();
            CommonDBResult<uspListWorldMarketDetailByCategory_Result> commonDbResult1 = new CommonDBResult<uspListWorldMarketDetailByCategory_Result>();
            CommonResult result = new CommonResult();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetWorldMarketSubListByCategory Fail is Not Open"), "WARN");
                result.resultCode = 2;
                result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)result);
            }
            if (WorldMarketItemInfoManager.This().checkUpdateTimeByDetailInfo(mainCategory.Value, subCategory.Value, CommonModule.GetCustomTime()))
            {
                CommonDBResult<uspListWorldMarketDetailByCategory_Result> commonDbResult2 = WebDBManager.ListWorldMarketDetailByCategory(mainCategory, subCategory);
                result.resultCode = commonDbResult2.resultCode;
                result.resultMsg = commonDbResult2.resultMsg;
                if (result.resultCode != 0)
                    return this.Json((object)result);
                updateList.list = commonDbResult2.list;
                if (!WorldMarketItemInfoManager.This().updateByDetailInfo(mainCategory.Value, subCategory.Value, ref updateList))
                {
                    result.resultMsg = "0";
                    return this.Json((object)result);
                }
            }
            if (WorldMarketItemInfoManager.This().getJsonStringByDetailInfo(mainCategory.Value, subCategory.Value, ref result))
                return this.Json((object)result);
            result.resultMsg = "0";
            return this.Json((object)result);
        }

        [HttpPost]
        public ActionResult GetWorldMarketHotList()
        {
            CommonDBResult<uspListWorldMarketHot_Result> commonDbResult = new CommonDBResult<uspListWorldMarketHot_Result>();
            CommonResult result = new CommonResult();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetWorldMarketHotList Fail is Not Open"), "WARN");
                result.resultCode = 2;
                result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return (ActionResult)this.Json((object)result);
            }
            if (WorldMarketItemInfoManager.This().checkUpdateTimeByHotItemInfo(CommonModule.GetCustomTime()))
            {
                CommonDBResult<uspListWorldMarketHot_Result> updateList = WebDBManager.ListWorldMarketHot();
                result.resultCode = updateList.resultCode;
                result.resultMsg = updateList.resultMsg;
                if (result.resultCode != 0)
                    return (ActionResult)this.Json((object)result);
                if (!WorldMarketItemInfoManager.This().updateByHotItemInfo(ref updateList))
                {
                    result.resultMsg = "0";
                    return (ActionResult)this.Json((object)result);
                }
            }
            if (!WorldMarketItemInfoManager.This().getJsonStringByHotItemInfo(ref result))
            {
                result.resultMsg = "0";
                return (ActionResult)this.Json((object)result);
            }
            return ConstantMgr._isCompression ? (ActionResult)this.File(CompressionModule.HaffmanCompression(result.resultMsg), "application/octet-stream") : (ActionResult)this.Json((object)result);
        }

        [HttpPost]
        public JsonResult GetWorldMarketSubOne(int? mainKey, int? subKey)
        {
            CommonResult commonResult1 = new CommonResult();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetWorldMarketSubOne Fail is Not Open"), "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(mainKey.Value, subKey.Value);
            if (!info.isValid())
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetWorldMarketSubOne({0}, {1}) Not Exist ItemInfo", (object)mainKey, (object)subKey), "WARN");
                commonResult1.resultCode = 8;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                return this.Json((object)commonResult1);
            }
            long pricePerOne = 0;
            long count = 0;
            long minPrice = 0;
            long maxPrice = 0;
            long totalTradeCount = 0;
            long lastTradePrice = 0;
            long lastTradeTime = 0;
            CommonResult commonResult2 = WebDBManager.WorldMarketDetailOne(mainKey, info._enchantGroup, ref pricePerOne, ref count, ref minPrice, ref maxPrice, ref totalTradeCount, ref lastTradePrice, ref lastTradeTime);
            if (commonResult2.resultCode != 0)
                return this.Json((object)commonResult2);
            commonResult2.resultMsg = mainKey.ToString() + "-" + (object)info._enchantGroup + "-" + Convert.ToString(ItemInfoManager.This().getEnchantMaxGroup(mainKey.Value, info._enchantGroup)) + "-" + (object)pricePerOne + "-" + (object)count + "-" + (object)subKey + "-" + (object)minPrice + "-" + (object)maxPrice + "-" + (object)totalTradeCount + "-" + (object)lastTradePrice + "-" + (object)lastTradeTime;
            return this.Json((object)commonResult2);
        }

        [HttpPost]
        public ActionResult GetBiddingInfoList(int? keyType, int? mainKey, int? subKey)
        {
            CommonDBResult<uspListBiddingInfo_Result> commonDbResult = new CommonDBResult<uspListBiddingInfo_Result>();
            KeyValuePair<int, int> keyValuePair = new KeyValuePair<int, int>(mainKey.Value, subKey.Value);
            CommonResult jsonResult = new CommonResult();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetBiddingInfoList Fail is Not Open"), "WARN");
                jsonResult.resultCode = 2;
                jsonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return (ActionResult)this.Json((object)jsonResult);
            }
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(mainKey.Value, subKey.Value);
            if (!info.isValid())
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetBiddingInfoList({0}, {1}) Not Exist ItemInfo", (object)mainKey, (object)subKey), "WARN");
                jsonResult.resultCode = 8;
                jsonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                return (ActionResult)this.Json((object)jsonResult);
            }
            if (BiddingInfoManager.This().checkBiddingUpdateTimeXXX(mainKey.Value, info._enchantGroup, CommonModule.GetCustomTime()))
            {
                CommonDBResult<uspListBiddingInfo_Result> list = WebDBManager.ListBiddingInfo(keyType, mainKey, new int?(info._enchantGroup), info._enchantMaterialKey, WorldMarketOptionManager.This().BiddingRatio);
                jsonResult.resultCode = list.resultCode;
                jsonResult.resultMsg = list.resultMsg;
                if (jsonResult.resultCode != 0)
                    return (ActionResult)this.Json((object)jsonResult);
                if (!BiddingInfoManager.This().updateBiddingInfoListXXX(mainKey.Value, info._enchantGroup, ref list))
                {
                    jsonResult.resultMsg = "0";
                    return (ActionResult)this.Json((object)jsonResult);
                }
            }
            BiddingInfoManager.This().getJsonStringByBiddingListXXX(mainKey.Value, info._enchantGroup, ref jsonResult);
            return ConstantMgr._isCompression ? (ActionResult)this.File(CompressionModule.HaffmanCompression(jsonResult.resultMsg), "application/octet-stream") : (ActionResult)this.Json((object)jsonResult);
        }

        [HttpPost]
        public JsonResult GetAddEnchantLevelPrice(int? keyType, int? mainKey, int? subKey)
        {
            CommonDBResult<uspListWorldMarketDetail_Result> commonDbResult = new CommonDBResult<uspListWorldMarketDetail_Result>();
            CommonResult commonResult = new CommonResult();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetAddEnchantLevelPrice Fail is Not Open"), "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            if (mainKey.Value <= 0)
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetAddEnchantLevelPrice({0}, {1}, {2}) [mainKey <= 0]", (object)keyType, (object)mainKey, (object)subKey), "WARN");
                commonResult.resultCode = 8;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                return this.Json((object)commonResult);
            }
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(mainKey.Value, subKey.Value);
            if (!info.isValid())
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetAddEnchantLevelPrice({0}, {1}, {2}) ItemInfo({3}, {4}) Not Exist ItemInfo ", (object)keyType, (object)mainKey, (object)subKey, (object)mainKey, (object)subKey), "WARN");
                commonResult.resultCode = 8;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                return this.Json((object)commonResult);
            }
            int enchantMaxGroup = ItemInfoManager.This().getEnchantMaxGroup(mainKey.Value, info._enchantGroup);
            if (info._enchantGroup > subKey.Value || subKey.Value > enchantMaxGroup)
            {
                LogUtil.WriteLog(string.Format("[Item Error]GetAddEnchantLevelPrice({0}) getEnchantMaxGroup({1}, {2}) Group : Out Of Range", (object)subKey.Value, (object)mainKey.Value, (object)info._enchantGroup), "WARN");
                commonResult.resultCode = 9;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup");
                return this.Json((object)commonResult);
            }
            if (enchantMaxGroup == info._enchantGroup)
            {
                commonResult.resultMsg = Convert.ToString(0) + "-" + Convert.ToString(subKey.Value);
                return this.Json((object)commonResult);
            }
            if (WorldMarketItemInfoManager.This().checkUpdateTimeByItemInof(info._enchantMaterialKey, CommonModule.GetCustomTime()))
            {
                CommonDBResult<uspListWorldMarketDetail_Result> updateList = WebDBManager.ListWorldMarketDetail(KeyType.eItem, info._enchantMaterialKey, false);
                commonResult.resultCode = updateList.resultCode;
                commonResult.resultMsg = updateList.resultMsg;
                if (commonResult.resultCode != 0)
                    return this.Json((object)commonResult);
                if (0 >= updateList.list.Count)
                {
                    LogUtil.WriteLog(string.Format("[DB Error] GetAddEnchantLevelPrice - uspListWorldMarketDetail({0}), [Count < 1] Count({1})", (object)info._enchantMaterialKey, (object)updateList.list.Count), "WARN");
                    commonResult.resultCode = 15;
                    commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ItemNotExist");
                    return this.Json((object)commonResult);
                }
                if (!WorldMarketItemInfoManager.This().updateByItemInfo(ref updateList))
                {
                    commonResult.resultMsg = "0";
                    return this.Json((object)commonResult);
                }
            }
            long num = WorldMarketItemInfoManager.This().getMaterialItemInfoXXX(info._enchantMaterialKey) * info._enchantNeedCount;
            if (num < 0L)
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetAddEnchantLevelPrice({0}, {1}, {2}) - enchantMaterialKey({3}) [totalPrice < 0]", (object)keyType, (object)mainKey, (object)subKey, (object)info._enchantMaterialKey), "WARN");
                commonResult.resultCode = 14;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_PRICE_WORNG");
                return this.Json((object)commonResult);
            }
            commonResult.resultMsg = Convert.ToString(num) + "-" + Convert.ToString(subKey.Value);
            return this.Json((object)commonResult);
        }

        [HttpPost]
        public ActionResult GetMyBiddingList(ViewUserAuthModel authInfo)
        {
            TradeMarketListUserBidding marketListUserBidding = new TradeMarketListUserBidding();
            CommonResult commonResult = new CommonResult();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetMyBiddingList Fail is Not Open"), "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return (ActionResult)this.Json((object)commonResult);
            }
            CommonDBResult<uspListUserBiddingBuy_Result> commonDbResult1 = new CommonDBResult<uspListUserBiddingBuy_Result>();
            CommonDBResult<uspListUserBiddingSell_Result> commonDbResult2 = new CommonDBResult<uspListUserBiddingSell_Result>();
            CommonDBResult<uspListWorldMarketDetail_Result> commonDbResult3 = new CommonDBResult<uspListWorldMarketDetail_Result>();
            ViewUserAuthResultModel userInfo = new ViewUserAuthResultModel();
            CommonResult view = this.CheckAuthKeyToView(authInfo.userNo, authInfo.certifiedKey, ViewAuthType.eViewAuthType_BiddingList, ref userInfo);
            if (view.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]GetMyBiddingList({0}, {1}) - errorCode : {2}", (object)authInfo.userNo, (object)authInfo.certifiedKey, (object)view.resultCode), "WARN");
                return (ActionResult)this.Json((object)view);
            }
            CommonDBResult<uspListUserBiddingBuy_Result> commonDbResult4 = WebDBManager.ListUserBiddingBuy(new int?(userInfo.nationCode), new int?(userInfo.worldNo), new long?(userInfo.userNo));
            view.resultCode = commonDbResult4.resultCode;
            view.resultMsg = commonDbResult4.resultMsg;
            if (view.resultCode != 0)
                return (ActionResult)this.Json((object)view);
            marketListUserBidding.buylist = commonDbResult4.list;
            CommonDBResult<uspListUserBiddingSell_Result> commonDbResult5 = WebDBManager.ListUserBiddingSell(new int?(userInfo.nationCode), new int?(userInfo.worldNo), new long?(userInfo.userNo));
            view.resultCode = commonDbResult5.resultCode;
            view.resultMsg = commonDbResult5.resultMsg;
            if (view.resultCode != 0)
                return (ActionResult)this.Json((object)view);
            marketListUserBidding.selllist = commonDbResult5.list;
            view.resultCode = 0;
            if (marketListUserBidding.buylist.Count == 0 && marketListUserBidding.selllist.Count == 0)
            {
                view.resultMsg = "0";
            }
            else
            {
                for (int index = 0; index < marketListUserBidding.buylist.Count; ++index)
                {
                    view.resultMsg = view.resultMsg + Convert.ToString(marketListUserBidding.buylist[index].C_buyNo) + "-" + Convert.ToString(marketListUserBidding.buylist[index].C_mainKey) + "-" + Convert.ToString(marketListUserBidding.buylist[index].C_subKey) + "-" + Convert.ToString(marketListUserBidding.buylist[index].C_chooseSubKey) + "-" + Convert.ToString(marketListUserBidding.buylist[index].C_leftCount) + "-" + Convert.ToString(marketListUserBidding.buylist[index].C_boughtCount) + "-" + Convert.ToString(marketListUserBidding.buylist[index].C_pricePerOne) + "-" + Convert.ToString(marketListUserBidding.buylist[index].C_basePrice) + "-" + Convert.ToString(marketListUserBidding.buylist[index].C_minPrice) + "-" + Convert.ToString(marketListUserBidding.buylist[index].C_addEnchantPrice) + "-" + Convert.ToString(marketListUserBidding.buylist[index].C_registerMoneyCount);
                    if (index < marketListUserBidding.buylist.Count - 1)
                        view.resultMsg += "|";
                }
                if (marketListUserBidding.buylist.Count == 0)
                    view.resultMsg += "0";
                view.resultMsg += "+";
                for (int index = 0; index < marketListUserBidding.selllist.Count; ++index)
                {
                    int cMainKey = marketListUserBidding.selllist[index].C_mainKey;
                    int cChooseSubKey = marketListUserBidding.selllist[index].C_chooseSubKey;
                    TradeMarketItemInfo info = ItemInfoManager.This().getInfo(cMainKey, cChooseSubKey);
                    if (!info.isValid())
                    {
                        LogUtil.WriteLog(string.Format("[Item Error] ItemInfo({0}, {1}) Not Exist ItemInfo ", (object)cMainKey, (object)cChooseSubKey), "WARN");
                        view.resultCode = 8;
                        view.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                        return (ActionResult)this.Json((object)view);
                    }
                    int enchantMaxGroup = ItemInfoManager.This().getEnchantMaxGroup(cMainKey, info._enchantGroup);
                    if (info._enchantGroup > cChooseSubKey || cChooseSubKey > enchantMaxGroup)
                    {
                        LogUtil.WriteLog(string.Format("[Item Error]GetTradePrice({0}) getEnchantMaxGroup({1}, {2}) Group : Out Of Range", (object)cChooseSubKey, (object)cMainKey, (object)info._enchantGroup), "WARN");
                        view.resultCode = 9;
                        view.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup");
                        return (ActionResult)this.Json((object)view);
                    }
                    long num;
                    if (enchantMaxGroup == info._enchantGroup)
                    {
                        num = 0L;
                    }
                    else
                    {
                        if (WorldMarketItemInfoManager.This().checkUpdateTimeByItemInof(info._enchantMaterialKey, CommonModule.GetCustomTime()))
                        {
                            CommonDBResult<uspListWorldMarketDetail_Result> updateList = WebDBManager.ListWorldMarketDetail(KeyType.eItem, info._enchantMaterialKey, false);
                            if (updateList.resultCode != 0)
                            {
                                view.resultCode = updateList.resultCode;
                                view.resultMsg = updateList.resultMsg;
                                return (ActionResult)this.Json((object)view);
                            }
                            if (0 >= updateList.list.Count)
                            {
                                LogUtil.WriteLog(string.Format("[DB Error] GetTradePrice - uspListWorldMarketDetail({0}), [Count < 1] Count({1})", (object)info._enchantMaterialKey, (object)updateList.list.Count), "WARN");
                                view.resultCode = 15;
                                view.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ItemNotExist");
                                return (ActionResult)this.Json((object)view);
                            }
                            if (!WorldMarketItemInfoManager.This().updateByItemInfo(ref updateList))
                            {
                                view.resultMsg = "0";
                                return (ActionResult)this.Json((object)view);
                            }
                        }
                        num = WorldMarketItemInfoManager.This().getMaterialItemInfoXXX(info._enchantMaterialKey) * info._enchantNeedCount;
                        if (num < 0L)
                        {
                            LogUtil.WriteLog(string.Format("[Item Error] GetMyBiddingList({0}, {1}) - enchantMaterialKey({2}) [totalPrice < 0]", (object)cMainKey, (object)cChooseSubKey, (object)info._enchantMaterialKey), "WARN");
                            view.resultCode = 14;
                            view.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_PRICE_WORNG");
                            return (ActionResult)this.Json((object)view);
                        }
                    }
                    view.resultMsg = view.resultMsg + Convert.ToString(marketListUserBidding.selllist[index].C_sellNo) + "-" + Convert.ToString(marketListUserBidding.selllist[index].C_mainKey) + "-" + Convert.ToString(marketListUserBidding.selllist[index].C_subKey) + "-" + Convert.ToString(marketListUserBidding.selllist[index].C_chooseSubKey) + "-" + Convert.ToString(marketListUserBidding.selllist[index].C_leftCount) + "-" + Convert.ToString(marketListUserBidding.selllist[index].C_soldCount) + "-" + Convert.ToString(marketListUserBidding.selllist[index].C_pricePerOne) + "-" + Convert.ToString(marketListUserBidding.selllist[index].C_accumulateMoneyCount) + "-" + Convert.ToString(num) + "-" + Convert.ToString(marketListUserBidding.selllist[index].C_isSealed) + "-" + Convert.ToString(marketListUserBidding.selllist[index].C_isRingBuff);
                    if (index < marketListUserBidding.selllist.Count - 1)
                        view.resultMsg += "|";
                }
                if (marketListUserBidding.selllist.Count == 0)
                    view.resultMsg += "0";
            }
            return ConstantMgr._isCompression ? (ActionResult)this.File(CompressionModule.HaffmanCompression(view.resultMsg), "application/octet-stream") : (ActionResult)this.Json((object)view);
        }

        [HttpPost]
        public JsonResult GetTradePrice(int? keyType, int? mainKey, int? subKey)
        {
            CommonDBResult<uspListWorldMarketDetail_Result> commonDbResult = new CommonDBResult<uspListWorldMarketDetail_Result>();
            CommonResult commonResult1 = new CommonResult();
            CommonResult commonResult2 = new CommonResult();
            commonResult2.resultMsg = Convert.ToString(0) + "-" + Convert.ToString(mainKey.Value) + "-" + Convert.ToString(subKey.Value);
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetTradePrice Fail is Not Open"), "WARN");
                return this.Json((object)commonResult2);
            }
            if (mainKey.Value <= 0)
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetTradePrice({0}, {1}, {2}) [mainKey <= 0]", (object)keyType, (object)mainKey, (object)subKey), "WARN");
                return this.Json((object)commonResult2);
            }
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(mainKey.Value, subKey.Value);
            if (!info.isValid())
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetTradePrice({0}, {1}, {2}) ItemInfo({3}, {4}) Not Exist ItemInfo ", (object)keyType, (object)mainKey, (object)subKey, (object)mainKey, (object)subKey), "WARN");
                return this.Json((object)commonResult2);
            }
            int enchantMaxGroup = ItemInfoManager.This().getEnchantMaxGroup(mainKey.Value, info._enchantGroup);
            if (info._enchantGroup > subKey.Value || subKey.Value > enchantMaxGroup)
            {
                LogUtil.WriteLog(string.Format("[Item Error]GetTradePrice({0}) getEnchantMaxGroup({1}, {2}) Group : Out Of Range", (object)subKey.Value, (object)mainKey.Value, (object)info._enchantGroup), "WARN");
                return this.Json((object)commonResult2);
            }
            long pricePerOne = 0;
            long count = 0;
            long minPrice = 0;
            long maxPrice = 0;
            long totalTradeCount = 0;
            long lastTradePrice = 0;
            long lastTradeTime = 0;
            CommonResult commonResult3 = WebDBManager.WorldMarketDetailOne(mainKey, info._enchantGroup, ref pricePerOne, ref count, ref minPrice, ref maxPrice, ref totalTradeCount, ref lastTradePrice, ref lastTradeTime);
            if (commonResult3.resultCode != 0)
                return this.Json((object)commonResult2);
            if (enchantMaxGroup == info._enchantGroup)
            {
                commonResult3.resultMsg = Convert.ToString(pricePerOne) + "-" + Convert.ToString(mainKey.Value) + "-" + Convert.ToString(subKey.Value);
                return this.Json((object)commonResult3);
            }
            if (WorldMarketItemInfoManager.This().checkUpdateTimeByItemInof(info._enchantMaterialKey, CommonModule.GetCustomTime()))
            {
                CommonDBResult<uspListWorldMarketDetail_Result> updateList = WebDBManager.ListWorldMarketDetail(KeyType.eItem, info._enchantMaterialKey, false);
                commonResult3.resultCode = updateList.resultCode;
                commonResult3.resultMsg = updateList.resultMsg;
                if (commonResult3.resultCode != 0)
                    return this.Json((object)commonResult2);
                if (0 >= updateList.list.Count)
                {
                    LogUtil.WriteLog(string.Format("[DB Error] GetTradePrice - uspListWorldMarketDetail({0}), [Count < 1] Count({1})", (object)info._enchantMaterialKey, (object)updateList.list.Count), "WARN");
                    return this.Json((object)commonResult2);
                }
                if (!WorldMarketItemInfoManager.This().updateByItemInfo(ref updateList))
                    return this.Json((object)commonResult2);
            }
            long num = WorldMarketItemInfoManager.This().getMaterialItemInfoXXX(info._enchantMaterialKey) * info._enchantNeedCount;
            if (num < 0L)
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetTradePrice({0}, {1}, {2}) - enchantMaterialKey({3}) [totalPrice < 0]", (object)keyType, (object)mainKey, (object)subKey, (object)info._enchantMaterialKey), "WARN");
                return this.Json((object)commonResult2);
            }
            commonResult3.resultMsg = Convert.ToString(pricePerOne + num) + "-" + Convert.ToString(mainKey.Value) + "-" + Convert.ToString(subKey.Value);
            return this.Json((object)commonResult3);
        }

        [HttpPost]
        public JsonResult GetMarketPriceInfo(int? keyType, int? mainKey, int? subKey)
        {
            CommonDBResult<uspGetMarketPriceInfo_Result> commonDbResult1 = new CommonDBResult<uspGetMarketPriceInfo_Result>();
            CommonResult commonResult1 = new CommonResult();
            CommonResult commonResult2 = new CommonResult();
            commonResult2.resultMsg = Convert.ToString(0) + "-" + Convert.ToString(mainKey.Value) + "-" + Convert.ToString(subKey.Value);
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetMarketPriceInfo Fail is Not Open"), "WARN");
                return this.Json((object)commonResult2);
            }
            if (mainKey.Value <= 0)
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetMarketPriceInfo({0}, {1}, {2}) [mainKey <= 0]", (object)keyType, (object)mainKey, (object)subKey), "WARN");
                return this.Json((object)commonResult2);
            }
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(mainKey.Value, subKey.Value);
            if (!info.isValid())
            {
                LogUtil.WriteLog(string.Format("[Item Error] GetMarketPriceInfo({0}, {1}, {2}) ItemInfo({3}, {4}) Not Exist ItemInfo ", (object)keyType, (object)mainKey, (object)subKey, (object)mainKey, (object)subKey), "WARN");
                return this.Json((object)commonResult2);
            }
            int enchantMaxGroup = ItemInfoManager.This().getEnchantMaxGroup(mainKey.Value, info._enchantGroup);
            if (info._enchantGroup > subKey.Value || subKey.Value > enchantMaxGroup)
            {
                LogUtil.WriteLog(string.Format("[Item Error]GetMarketPriceInfo({0}) getEnchantMaxGroup({1}, {2}) Group : Out Of Range", (object)subKey.Value, (object)mainKey.Value, (object)info._enchantGroup), "WARN");
                return this.Json((object)commonResult2);
            }
            long pricePerOne = 0;
            long count = 0;
            long minPrice = 0;
            long maxPrice = 0;
            long totalTradeCount = 0;
            long lastTradePrice = 0;
            long lastTradeTime = 0;
            CommonResult commonResult3 = WebDBManager.WorldMarketDetailOne(mainKey, info._enchantGroup, ref pricePerOne, ref count, ref minPrice, ref maxPrice, ref totalTradeCount, ref lastTradePrice, ref lastTradeTime);
            CommonDBResult<uspGetMarketPriceInfo_Result> commonDbResult2 = WebDBManager.WorldMarketPriceInfo(keyType, mainKey, subKey);
            if (commonResult3.resultCode != 0)
                return this.Json((object)commonResult2);
            DateTime customTime = CommonModule.GetCustomTime();
            long[] numArray1 = new long[90];
            numArray1.Initialize();
            if (commonDbResult2.list.Count == 0)
            {
                for (int index = 0; index < numArray1.Length; ++index)
                    numArray1[index] = pricePerOne;
            }
            else
            {
                for (int index = 0; index < commonDbResult2.list.Count; ++index)
                {
                    TimeSpan timeSpan = customTime - commonDbResult2.list[index].C_datetime.Value;
                    if (timeSpan.Days < numArray1.Length)
                    {
                        long[] numArray2 = numArray1;
                        numArray2[numArray2.Length - 1 - timeSpan.Days] = commonDbResult2.list[index].C_price;
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
                commonResult3.resultMsg += Convert.ToString(numArray1[index]);
                if (index != numArray1.Length - 1)
                    commonResult3.resultMsg += "-";
            }
            return this.Json((object)commonResult3);
        }

        [HttpPost]
        public JsonResult GetMyWaitNoticeList(ViewUserAuthModel authInfo)
        {
            CommonResult commonResult = new CommonResult();
            CommonDBResult<uspWorldMarketWaitNoticeList_Result> commonDbResult1 = new CommonDBResult<uspWorldMarketWaitNoticeList_Result>();
            ViewUserAuthResultModel userInfo = new ViewUserAuthResultModel();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetMyWaitNoticeList Fail is Not Open"), "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            CommonResult view = this.CheckAuthKeyToView(authInfo.userNo, authInfo.certifiedKey, ViewAuthType.eViewAuthType_WalletList, ref userInfo);
            if (view.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]GetMyWaitNoticeList({0}) - errorCode : {1}", (object)JsonConvert.SerializeObject((object)authInfo), (object)view.resultCode), "WARN");
                return this.Json((object)view);
            }
            CommonDBResult<uspWorldMarketWaitNoticeList_Result> commonDbResult2 = WebDBManager.WorldMarketMyWaitNoticeList(userInfo.nationCode, userInfo.worldNo, userInfo.userNo);
            view.resultCode = 0;
            if (commonDbResult2.list.Count == 0)
            {
                view.resultMsg = "0";
            }
            else
            {
                for (int index = 0; index < commonDbResult2.list.Count; ++index)
                {
                    int num1 = 0;
                    long num2 = 0;
                    if ((byte)1 == commonDbResult2.list[index].C_usedType)
                        num1 = 1;
                    if ((byte)2 == commonDbResult2.list[index].C_usedType)
                        num2 = 1L;
                    if ((byte)3 == commonDbResult2.list[index].C_usedType)
                        num2 = 2L;
                    view.resultMsg = Convert.ToString(commonDbResult2.list[index].C_mainKey) + "-" + Convert.ToString(commonDbResult2.list[index].C_chooseSubKey) + "-" + Convert.ToString(1) + "-" + Convert.ToString(commonDbResult2.list[index].C_pricePerOne) + "-" + Convert.ToString(num1) + "-" + Convert.ToString(commonDbResult2.list[index].C_resultMoneyCount) + "-" + Convert.ToString(num2) + "-" + Convert.ToString(false) + "-" + Convert.ToString(commonDbResult2.list[index].C_usedType) + "-" + Convert.ToString(0) + "-" + Convert.ToString(0);
                    if (index < commonDbResult2.list.Count - 1)
                        view.resultMsg += "|";
                }
            }
            return this.Json((object)view);
        }

        [HttpPost]
        public JsonResult GetWorldMarketWaitList()
        {
            CommonDBResult<uspListWorldMarketWait_Result> commonDbResult = new CommonDBResult<uspListWorldMarketWait_Result>();
            CommonResult result = new CommonResult();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("GetWorldMarketWaitList Fail is Not Open", "WARN");
                result.resultCode = 2;
                result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)result);
            }
            if (WorldMarketItemInfoManager.This().checkUpdateTimeByWaitItemInfo(CommonModule.GetCustomTime()))
            {
                CommonDBResult<uspListWorldMarketWait_Result> updateList = WebDBManager.ListWorldMarketWait();
                result.resultCode = updateList.resultCode;
                result.resultMsg = updateList.resultMsg;
                if (result.resultCode != 0)
                    return this.Json((object)result);
                if (!WorldMarketItemInfoManager.This().updateByWaitItemInfo(ref updateList))
                {
                    result.resultMsg = "0";
                    return this.Json((object)result);
                }
            }
            if (WorldMarketItemInfoManager.This().getJsonStringByWaitItemInfo(ref result))
                return this.Json((object)result);
            result.resultMsg = "0";
            return this.Json((object)result);
        }

        [HttpPost]
        public JsonResult GetServantNo(
          long? userNo,
          string certifiedKey,
          int? keyType,
          int? mainKey,
          int? subKey)
        {
            CommonDBResult<uspGetMarketPriceInfo_Result> commonDbResult = new CommonDBResult<uspGetMarketPriceInfo_Result>();
            ViewUserAuthResultModel userInfo = new ViewUserAuthResultModel();
            CommonResult commonResult1 = new CommonResult();
            long resultServantNo = 0;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("GetServantNo Fail is Not Open"), "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult view = this.CheckAuthKeyToView(userNo.Value, certifiedKey, ViewAuthType.eViewAuthType_ServantNo, ref userInfo);
            if (view.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]GetServantNo({0}, {1}) - errorCode : {2}", (object)userNo.Value, (object)certifiedKey, (object)view.resultCode), "WARN");
                return this.Json((object)view);
            }
            CommonResult commonResult2 = WebDBManager.WorldMarketServnatNo(new int?(userInfo.nationCode), new int?(userInfo.worldNo), new long?(userInfo.userNo), keyType, mainKey, subKey, ref resultServantNo);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Error] GetMyWalletList - PersonalTradeList({0}/{1}/{2}) resultCode : {3}", (object)userInfo.nationCode, (object)userInfo.worldNo, (object)userInfo.userNo, (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            commonResult2.resultMsg = Convert.ToString(resultServantNo) + "-" + Convert.ToString((object)keyType) + "-" + Convert.ToString((object)mainKey) + "-" + Convert.ToString((object)subKey);
            return this.Json((object)commonResult2);
        }
    }
}
