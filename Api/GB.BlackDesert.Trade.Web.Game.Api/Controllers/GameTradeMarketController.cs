
using GB.BlackDesert.Trade.Web.Game.Api.Models;
using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.DB;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data.Entity.Core.Objects;
using System.Text;

namespace GB.BlackDesert.Trade.Web.Game.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GameTradeMarketController : BaseController
    {
        public GameTradeMarketController(IHttpContextAccessor accessor)
        {
            ContextAccess.Configure(accessor);
        }
        private static DateTime DefaultTime = new DateTime(1970, 1, 1, 0, 0, 0);

        [HttpPost]
        public JsonResult CheckAuthKeyToView()
        {
            ViewUserAuthResultModel userAuthResultModel = new ViewUserAuthResultModel();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("CheckAuthKeyToView Fail is Not Open", "WARN");
                userAuthResultModel.result.resultCode = 2;
                userAuthResultModel.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)userAuthResultModel);
            }
            string empty3 = string.Empty;
            string end;
            try
            {
                this.Request.Body.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.Body).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CheckAuthKeyToView({0}) - HttpRequest errorMsg : {1}", (object)empty3, (object)ex.ToString()), "WARN");
                userAuthResultModel.result.resultCode = 3;
                userAuthResultModel.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONException");
                return this.Json((object)userAuthResultModel);
            }
            ViewUserAuthModel viewUserAuthModel = JsonConvert.DeserializeObject<ViewUserAuthModel>(end);
            if (viewUserAuthModel == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CheckAuthKeyToView({0}) - model is null", (object)end), "WARN");
                userAuthResultModel.result.resultCode = 5;
                userAuthResultModel.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)userAuthResultModel);
            }
            userAuthResultModel.result = TradeModule.CheckAuthKey(ref userInfo, viewUserAuthModel.userNo, viewUserAuthModel.certifiedKey);
            if (userAuthResultModel.result.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error] CheckAuthKeyToView({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)viewUserAuthModel), (object)userAuthResultModel.result.resultCode), "WARN");
                return this.Json((object)userAuthResultModel);
            }
            userAuthResultModel.worldNo = userInfo._worldNo;
            userAuthResultModel.nationCode = userInfo._nationCode;
            userAuthResultModel.userNo = userInfo._userNo;
            return this.Json((object)userAuthResultModel);
        }

        [HttpPost]
        public JsonResult SetMarketItem(GameTradeMarketItmeAuthModel model)
        {
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string errorMsg = string.Empty;
            string relResult = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("SetMarketItem Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, model.userNo, model.certifiedKey);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error] SetMarketItem({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)model), (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            commonResult2.resultCode = WorldMarketBase.checkValidCount<int, long>(1, model.count);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Count Error] SetMarketItem({0}) invalidCount({1})", (object)JsonConvert.SerializeObject((object)model), (object)model.count), "WARN");
                commonResult2.resultCode = 7;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketItemInfoModel marketItemInfoModel = new GameTradeMarketItemInfoModel()
            {
                userNo = userInfo._userNo,
                serverNo = userInfo._worldNo,
                nationCode = userInfo._nationCode,
                keyType = model.keyType,
                mainKey = model.mainKey,
                subKey = model.subKey,
                param0 = model.param0,
                param1 = model.param1,
                param2 = model.param2,
                param3 = model.param3,
                param4 = model.param4,
                count = model.count,
                isSealed = model.isSealed
            };
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/SetMarketItemProcess", JsonConvert.SerializeObject((object)marketItemInfoModel), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]SetMarketItem({0}) - HttpRequest SetMarketItemProcess errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketItemInfoModel), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketPayload tradeMarketPayload = JsonConvert.DeserializeObject<GameTradeMarketPayload>(relResult);
            if (tradeMarketPayload == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]SetMarketItem({0}) - HttpRequest SetMarketItemProcess result : payloadModelis null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketItemInfoModel), (object)errorMsg), "WARN");
                commonResult2.resultCode = 5;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)commonResult2);
            }
            if (tradeMarketPayload.result.resultCode != 0)
            {
                if (100 == tradeMarketPayload.result.resultCode)
                    return this.Json((object)tradeMarketPayload.result);
                LogUtil.WriteLog(string.Format("[Http Error]SetMarketItem({0}) - HttpRequest SetMarketItemProcess result : resultCode  {1}", (object)JsonConvert.SerializeObject((object)marketItemInfoModel), (object)tradeMarketPayload.result.resultCode), "WARN");
                return this.Json((object)tradeMarketPayload.result);
            }
            if (tradeMarketPayload.payload == 0L)
            {
                LogUtil.WriteLog(string.Format("[Http Error]SetMarketItem({0}) - HttpRequest SetMarketItemProcess result : payload is Zero", (object)JsonConvert.SerializeObject((object)marketItemInfoModel)), "WARN");
                commonResult2.resultCode = 17;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_PayloadIsZero");
                return this.Json((object)commonResult2);
            }
            try
            {
                using (TradeGameDB tradeGameDb = new TradeGameDB(TradeModule.MakeGameDbName(this.Request.Host.ToString(), userInfo._worldNo)))
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    tradeGameDb.uspRemoveForDepositToWorldMarket(new long?(tradeMarketPayload.payload), new int?(marketItemInfoModel.nationCode), new int?(marketItemInfoModel.serverNo), new long?(marketItemInfoModel.userNo), new int?(marketItemInfoModel.keyType), new int?(marketItemInfoModel.mainKey), new int?(marketItemInfoModel.subKey), new bool?(marketItemInfoModel.isSealed), new long?(marketItemInfoModel.param0), new long?(marketItemInfoModel.param1), new long?(marketItemInfoModel.param2), new long?(marketItemInfoModel.param3), new long?(marketItemInfoModel.param4), new long?(marketItemInfoModel.count), new short?((short)0), symNo, rv);
                    commonResult2.resultCode = Convert.ToInt32(rv.Value);
                    commonResult2.resultMsg = Convert.ToString(symNo.Value);
                    if (commonResult2.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]SetMarketItem - uspRemoveForDepositToWorldMarket({0}/{1}), rv({2})", (object)JsonConvert.SerializeObject((object)marketItemInfoModel), (object)tradeMarketPayload.payload, (object)commonResult2.resultCode), "WARN");
                        return this.Json((object)commonResult2);
                    }
                }
                commonResult2.resultMsg = Convert.ToString(tradeMarketPayload.payload);
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception] SetMarketItem({0}) - uspRemoveForDepositToWorldMarket({1}) Exception : {2}", (object)JsonConvert.SerializeObject((object)marketItemInfoModel), (object)tradeMarketPayload.payload, (object)ex.ToString()), "ERROR");
                commonResult2.resultCode = 1;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult2);
            }
            return this.Json((object)commonResult2);
        }

        [HttpPost]
        public JsonResult RegisterMarketItem(GameTradeMarketAuthPayload model)
        {
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string relResult = string.Empty;
            string errorMsg = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("RegisterMarketItem Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, model.userNo, model.certifiedKey);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error]RegisterMarketItem({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)model), (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketIncludePayload marketIncludePayload1 = new GameTradeMarketIncludePayload()
            {
                nationCode = userInfo._nationCode,
                serverNo = userInfo._worldNo,
                userNo = userInfo._userNo,
                isRestoration = model.isRestoration
            };
            try
            {
                using (TradeGameDB tradeGameDb = new TradeGameDB(TradeModule.MakeGameDbName(this.Request.Host.ToString(), userInfo._worldNo)))
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    tradeGameDb.uspCheckPayloadForRegisterItem(new int?(marketIncludePayload1.nationCode), new int?(marketIncludePayload1.serverNo), new long?(marketIncludePayload1.userNo), new int?(model.keyType), new int?(model.mainKey), new int?(model.subKey), new long?(model.count), new bool?(model.isSealed), new long?(model.payload), new long?(model.param0), new long?(model.param1), new long?(model.param2), new long?(model.param3), new long?(model.param4), symNo, rv);
                    commonResult2.resultCode = Convert.ToInt32(rv.Value);
                    commonResult2.resultMsg = Convert.ToString(symNo.Value);
                    if (commonResult2.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]RegisterMarketItem({0}) - uspCheckPayloadForRegisterItem({1}), rv({2})", (object)JsonConvert.SerializeObject((object)marketIncludePayload1), (object)model.payload, (object)commonResult2.resultCode), "WARN");
                        return this.Json((object)commonResult2);
                    }
                }
                marketIncludePayload1.payload = model.payload;
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception]RegisterMarketItem({0}) - uspCheckPayloadForRegisterItem({1}) Exception : {2}", (object)JsonConvert.SerializeObject((object)marketIncludePayload1), (object)model.payload, (object)ex.ToString()), "ERROR");
                commonResult2.resultCode = 1;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult2);
            }
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/RegisterMarketItemProcess", JsonConvert.SerializeObject((object)marketIncludePayload1), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]RegisterMarketItem({0}) - HttpRequest RegisterMarketItemProcess errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketIncludePayload1), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketIncludePayload marketIncludePayload2 = JsonConvert.DeserializeObject<GameTradeMarketIncludePayload>(relResult);
            if (marketIncludePayload2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]RegisterMarketItem({0}) - HttpRequest RegisterMarketItemProcess result : payloadResult null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketIncludePayload1), (object)errorMsg), "WARN");
                commonResult2.resultCode = 5;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)commonResult2);
            }
            if (marketIncludePayload2.result.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]RegisterMarketItem({0}) - HttpRequest RegisterMarketItemProcess result : resultCode  {1}", (object)JsonConvert.SerializeObject((object)marketIncludePayload1), (object)marketIncludePayload2.result.resultCode), "WARN");
                return this.Json((object)marketIncludePayload2.result);
            }
            if (marketIncludePayload2.payload == 0L)
            {
                LogUtil.WriteLog(string.Format("[Http Error]RegisterMarketItem({0}) - HttpRequest RegisterMarketItemProcess result : payload is Zero", (object)JsonConvert.SerializeObject((object)marketIncludePayload1)), "WARN");
                commonResult2.resultCode = 17;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_PayloadIsZero");
                return this.Json((object)commonResult2);
            }
            try
            {
                using (TradeGameDB tradeGameDb = new TradeGameDB(TradeModule.MakeGameDbName(this.Request.Host.ToString(), userInfo._worldNo)))
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    tradeGameDb.uspCompletePayloadForRegisterItem(new int?(marketIncludePayload1.nationCode), new int?(marketIncludePayload1.serverNo), new long?(marketIncludePayload1.userNo), new int?(model.keyType), new int?(model.mainKey), new int?(model.subKey), new long?(model.count), new bool?(model.isSealed), new long?(model.payload), new long?(model.param0), new long?(model.param1), new long?(model.param2), new long?(model.param3), new long?(model.param4), symNo, rv);
                    commonResult2.resultCode = Convert.ToInt32(rv.Value);
                    commonResult2.resultMsg = Convert.ToString(symNo.Value);
                    if (commonResult2.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]RegisterMarketItem({0}) - uspCompletePayloadForRegisterItem({1}), rv({2})", (object)JsonConvert.SerializeObject((object)marketIncludePayload1), (object)model.payload, (object)commonResult2.resultCode), "WARN");
                        return this.Json((object)commonResult2);
                    }
                }
                marketIncludePayload1.payload = model.payload;
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception]RegisterMarketItem({0}) - uspCompletePayloadForRegisterItem({1}) Exception : {2}", (object)JsonConvert.SerializeObject((object)marketIncludePayload1), (object)model.payload, (object)ex.ToString()), "ERROR");
                commonResult2.resultCode = 1;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult2);
            }
            commonResult2.resultMsg = Convert.ToString(marketIncludePayload2.keyType) + "-" + Convert.ToString(marketIncludePayload2.mainKey) + "-" + Convert.ToString(marketIncludePayload2.subKey) + "-" + Convert.ToString(marketIncludePayload2.isSealed) + "-" + Convert.ToString(marketIncludePayload2.count);
            return this.Json((object)commonResult2);
        }

        [HttpPost]
        public JsonResult WithdrawItem(GameTradeMarketItmeAuthModel model)
        {
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string relResult = string.Empty;
            string errorMsg = string.Empty;
            string empty = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("WithdrawItem Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, model.userNo, model.certifiedKey);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error]WithdrawItem({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)model), (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            string name = TradeModule.MakeGameDbName(this.Request.Host.ToString(), userInfo._worldNo);
            commonResult2.resultCode = WorldMarketBase.checkValidCount<int, long>(1, model.count);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Count Error] WithdrawItem({0}) invalidCount({1})", (object)JsonConvert.SerializeObject((object)model), (object)model.count), "WARN");
                commonResult2.resultCode = 7;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketItemInfoModel marketItemInfoModel = new GameTradeMarketItemInfoModel()
            {
                nationCode = userInfo._nationCode,
                serverNo = userInfo._worldNo,
                userNo = userInfo._userNo,
                keyType = model.keyType,
                mainKey = model.mainKey,
                subKey = model.subKey,
                count = model.count,
                isSealed = model.isSealed
            };
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/PreWithdrawItemProcess", JsonConvert.SerializeObject((object)marketItemInfoModel), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawItem({0}) - HttpRequest PreWithdrawItemProcess errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketItemInfoModel), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketIncludePayload marketIncludePayload1 = JsonConvert.DeserializeObject<GameTradeMarketIncludePayload>(relResult);
            if (marketIncludePayload1 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawItem({0}) - HttpRequest PreWithdrawItemProcess result : resultPayload null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketItemInfoModel), (object)errorMsg), "WARN");
                commonResult2.resultCode = 5;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)commonResult2);
            }
            if (marketIncludePayload1.result.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawItem({0}) - HttpRequest PreWithdrawItemProcess result : resultCode  {1}", (object)JsonConvert.SerializeObject((object)marketItemInfoModel), (object)marketIncludePayload1.result.resultCode), "WARN");
                return this.Json((object)marketIncludePayload1.result);
            }
            if (marketIncludePayload1.payload == 0L)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawItem({0}) - HttpRequest PreWithdrawItemProcess result : payload is Zero", (object)JsonConvert.SerializeObject((object)marketItemInfoModel)), "WARN");
                commonResult2.resultCode = 17;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_PayloadIsZero");
                return this.Json((object)commonResult2);
            }
            try
            {
                using (TradeGameDB tradeGameDb = new TradeGameDB(name))
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    tradeGameDb.uspCreateForWithdrawToWorldMarket(new long?(marketIncludePayload1.payload), new int?(marketItemInfoModel.nationCode), new int?(marketItemInfoModel.serverNo), new long?(marketItemInfoModel.userNo), new int?(marketItemInfoModel.keyType), new int?(marketItemInfoModel.mainKey), new int?(marketItemInfoModel.subKey), new bool?(marketItemInfoModel.isSealed), new long?(marketIncludePayload1.param0), new long?(marketIncludePayload1.param1), new long?(marketIncludePayload1.param2), new long?(marketIncludePayload1.param3), new long?(marketIncludePayload1.param4), new long?(marketItemInfoModel.count), new short?((short)0), symNo, rv);
                    commonResult2.resultCode = Convert.ToInt32(rv.Value);
                    commonResult2.resultMsg = Convert.ToString(symNo.Value);
                    if (commonResult2.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]WithdrawItem() - uspCreateForWithdrawToWorldMarket({0}/{1}), rv({2})", (object)JsonConvert.SerializeObject((object)marketItemInfoModel), (object)JsonConvert.SerializeObject((object)marketIncludePayload1), (object)commonResult2.resultCode), "WARN");
                        return this.Json((object)commonResult2);
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception]WithdrawItem() - uspCreateForWithdrawToWorldMarket({0}/{1}) Exception : {2}", (object)JsonConvert.SerializeObject((object)marketItemInfoModel), (object)JsonConvert.SerializeObject((object)marketIncludePayload1), (object)ex.ToString()), "ERROR");
                commonResult2.resultCode = 1;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketIncludePayload marketIncludePayload2 = new GameTradeMarketIncludePayload()
            {
                nationCode = marketItemInfoModel.nationCode,
                serverNo = marketItemInfoModel.serverNo,
                userNo = marketItemInfoModel.userNo,
                keyType = marketItemInfoModel.keyType,
                mainKey = marketItemInfoModel.mainKey,
                subKey = marketItemInfoModel.subKey,
                isSealed = marketItemInfoModel.isSealed,
                param0 = marketIncludePayload1.param0,
                param1 = marketIncludePayload1.param1,
                param2 = marketIncludePayload1.param2,
                param3 = marketIncludePayload1.param3,
                param4 = marketIncludePayload1.param4,
                count = marketItemInfoModel.count,
                payload = marketIncludePayload1.payload
            };
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/CompleteWithdrawItemProcess", JsonConvert.SerializeObject((object)marketIncludePayload2), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawItem({0}) - HttpRequest CompleteWithdrawItemProcess errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketIncludePayload2), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketPayload tradeMarketPayload = JsonConvert.DeserializeObject<GameTradeMarketPayload>(relResult);
            if (tradeMarketPayload == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawItem({0}) - HttpRequest CompleteWithdrawItemProcess result : response null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketIncludePayload2), (object)errorMsg), "WARN");
                commonResult2.resultCode = 5;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)commonResult2);
            }
            if (tradeMarketPayload.result.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawItem({0}) - HttpRequest CompleteWithdrawItemProcess result : resultCode  {1}", (object)JsonConvert.SerializeObject((object)marketIncludePayload2), (object)tradeMarketPayload.result.resultCode), "WARN");
                return this.Json((object)tradeMarketPayload.result);
            }
            if (tradeMarketPayload.payload == 0L)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawItem({0}) - HttpRequest CompleteWithdrawItemProcess result : payload is Zero", (object)JsonConvert.SerializeObject((object)marketIncludePayload2)), "WARN");
                commonResult2.resultCode = 17;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_PayloadIsZero");
                return this.Json((object)commonResult2);
            }
            try
            {
                using (TradeGameDB tradeGameDb = new TradeGameDB(name))
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    tradeGameDb.uspUpdateForWithdrawToWorldMarket(new long?(tradeMarketPayload.payload), symNo, rv);
                    commonResult2.resultCode = Convert.ToInt32(rv.Value);
                    commonResult2.resultMsg = Convert.ToString(symNo.Value);
                    if (commonResult2.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]WithdrawItem() - uspUpdateForWithdrawToWorldMarket({0}/{1}), rv({2})", (object)JsonConvert.SerializeObject((object)tradeMarketPayload), (object)tradeMarketPayload.payload, (object)commonResult2.resultCode), "WARN");
                        return this.Json((object)commonResult2);
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception]WithdrawItem() - uspUpdateForWithdrawToWorldMarket({0}) Exception : {1}", (object)JsonConvert.SerializeObject((object)tradeMarketPayload), (object)ex.ToString()), "ERROR");
                commonResult2.resultCode = 1;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult2);
            }
            commonResult2.resultMsg = Convert.ToString(tradeMarketPayload.payload) + "-" + Convert.ToString(model.mainKey) + "-" + Convert.ToString(model.subKey) + "-" + Convert.ToString(marketIncludePayload1.param0) + "-" + Convert.ToString(marketIncludePayload1.param1) + "-" + Convert.ToString(marketIncludePayload1.param2) + "-" + Convert.ToString(marketIncludePayload1.param3) + "-" + Convert.ToString(marketIncludePayload1.param4) + "-" + Convert.ToString(model.count) + "-" + Convert.ToString(model.isSealed);
            return this.Json((object)commonResult2);
        }

        [HttpPost]
        public JsonResult PopItemRestoration(PopItemRestorationInfo model)
        {
            GameTradeMarketState tradeMarketState1 = new GameTradeMarketState();
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string relResult = string.Empty;
            string errorMsg = string.Empty;
            string empty = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("PopItemRestoration Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, model.userNo, model.certifiedKey);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error]PopItemRestoration({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)model), (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            string name = TradeModule.MakeGameDbName(this.Request.Host.ToString(), userInfo._worldNo);
            commonResult2.resultCode = WorldMarketBase.checkValidCount<int, long>(1, model.itemCount);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Count Error] PopItemRestoration({0}) invalidCount({1})", (object)JsonConvert.SerializeObject((object)model), (object)model.itemCount), "WARN");
                commonResult2.resultCode = 7;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketIncludePayload marketIncludePayload = new GameTradeMarketIncludePayload()
            {
                nationCode = userInfo._nationCode,
                serverNo = userInfo._worldNo,
                userNo = userInfo._userNo,
                keyType = 0,
                mainKey = model.mainKey,
                subKey = model.subKey,
                isSealed = model.isSealed,
                param0 = model.param0,
                param1 = model.param1,
                param2 = model.param2,
                param3 = model.param3,
                param4 = model.param4,
                count = model.itemCount,
                payload = model.payload
            };
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/CheckWithDrawPayLoadProcess", JsonConvert.SerializeObject((object)marketIncludePayload), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]PopItemRestoration({0}) - HttpRequest CheckWithDrawPayLoadProcess errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketIncludePayload), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketState tradeMarketState2 = JsonConvert.DeserializeObject<GameTradeMarketState>(relResult);
            if (tradeMarketState2.result.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]PopItemRestoration({0}) - HttpRequest CheckWithDrawPayLoadProcess result Fail, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketIncludePayload), (object)tradeMarketState2.result.resultMsg), "WARN");
                commonResult2.resultCode = 5;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)commonResult2);
            }
            if (tradeMarketState2.state < 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]PopItemRestoration({0}) - HttpRequest CheckWithDrawPayLoadProcess result : state is Not, state : {1}", (object)JsonConvert.SerializeObject((object)marketIncludePayload), (object)tradeMarketState2.state), "WARN");
                commonResult2.resultCode = 5;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)commonResult2);
            }
            if (tradeMarketState2.state == 0)
            {
                try
                {
                    using (TradeGameDB tradeGameDb = new TradeGameDB(name))
                    {
                        ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                        ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                        tradeGameDb.uspWithdrawPayloadDestroy(new long?(marketIncludePayload.userNo), new int?(marketIncludePayload.nationCode), new int?(marketIncludePayload.serverNo), new long?(marketIncludePayload.payload), new int?(marketIncludePayload.mainKey), new int?(marketIncludePayload.subKey), new bool?(marketIncludePayload.isSealed), new long?(marketIncludePayload.count), new long?(marketIncludePayload.param0), new long?(marketIncludePayload.param1), new long?(marketIncludePayload.param2), new long?(marketIncludePayload.param3), new long?(marketIncludePayload.param4), symNo, rv);
                        commonResult2.resultCode = Convert.ToInt32(rv.Value);
                        commonResult2.resultMsg = Convert.ToString(symNo.Value);
                        if (commonResult2.resultCode != 0)
                        {
                            LogUtil.WriteLog(string.Format("[DB Error]PopItemRestoration() - uspWithdrawPayloadDestroy Fail({0}/{1}), rv({2})", (object)JsonConvert.SerializeObject((object)marketIncludePayload), (object)marketIncludePayload.payload, (object)commonResult2.resultCode), "WARN");
                            return this.Json((object)commonResult2);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception]PopItemRestoration() - uspWithdrawPayloadDestroy({0}) Exception : {1}", (object)JsonConvert.SerializeObject((object)model), (object)ex.ToString()), "ERROR");
                    commonResult2.resultCode = 1;
                    commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)commonResult2);
                }
                commonResult2.resultMsg = Convert.ToString(model.payload) + "-" + Convert.ToString(model.mainKey) + "-" + Convert.ToString(model.subKey) + "-" + Convert.ToString(model.itemCount) + "-" + Convert.ToString(model.isSealed) + "-" + Convert.ToString(model.param0) + "-" + Convert.ToString(model.param1) + "-" + Convert.ToString(model.param2) + "-" + Convert.ToString(model.param3) + "-" + Convert.ToString(model.param4) + "-False";
                return this.Json((object)commonResult2);
            }
            try
            {
                using (TradeGameDB tradeGameDb = new TradeGameDB(name))
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    tradeGameDb.uspUpdateForWithdrawToWorldMarket(new long?(model.payload), symNo, rv);
                    commonResult2.resultCode = Convert.ToInt32(rv.Value);
                    commonResult2.resultMsg = Convert.ToString(symNo.Value);
                    if (commonResult2.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]PopItemRestoration() - uspUpdateForWithdrawToWorldMarket({0}/{1}), rv({2})", (object)JsonConvert.SerializeObject((object)model), (object)model.payload, (object)commonResult2.resultCode), "WARN");
                        return this.Json((object)commonResult2);
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception]PopItemRestoration() - uspUpdateForWithdrawToWorldMarket({0}) Exception : {1}", (object)JsonConvert.SerializeObject((object)model), (object)ex.ToString()), "ERROR");
                commonResult2.resultCode = 1;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult2);
            }
            commonResult2.resultMsg = Convert.ToString(model.payload) + "-" + Convert.ToString(model.mainKey) + "-" + Convert.ToString(model.subKey) + "-" + Convert.ToString(model.itemCount) + "-" + Convert.ToString(model.isSealed) + "-" + Convert.ToString(model.param0) + "-" + Convert.ToString(model.param1) + "-" + Convert.ToString(model.param2) + "-" + Convert.ToString(model.param3) + "-" + Convert.ToString(model.param4) + "-True";
            return this.Json((object)commonResult2);
        }

        [HttpPost]
        public JsonResult CreateMyWallet(GameTradeMarketUserAuthModel authModel)
        {
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            DateTime dateTime1 = GameTradeMarketController.DefaultTime;
            DateTime dateTime2 = GameTradeMarketController.DefaultTime;
            int num1 = 0;
            int num2 = 0;
            bool flag = false;
            List<uspFamilySKillListFromWorldMarket_Result> worldMarketResultList = new List<uspFamilySKillListFromWorldMarket_Result>();
            int num3 = 0;
            string relResult = string.Empty;
            string errorMsg = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("CreateMyWallet Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, authModel.userNo, authModel.certifiedKey);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error]CreateMyWallet({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)authModel), (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            string empty = string.Empty;
            if (ConstantMgr._serviceProject.Equals("BDO"))
            {
                try
                {
                    using (TradeWORLDDB tradeWorlddb = new TradeWORLDDB())
                    {
                        ObjectParameter userId = new ObjectParameter("userId", typeof(string));
                        ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
                        ObjectParameter resultMsg = new ObjectParameter("resultMsg", typeof(string));
                        tradeWorlddb.uspGetUserId(new long?(userInfo._userNo), userId, resultCode, resultMsg);
                        empty = userId.Value.ToString();
                        commonResult2.resultCode = Convert.ToInt32(resultCode.Value);
                        commonResult2.resultMsg = Convert.ToString(resultMsg.Value);
                        if (commonResult2.resultCode != 0)
                        {
                            LogUtil.WriteLog(string.Format("[DB Exception] CreateMyWallet({0}) - uspGetUserId({1})", (object)JsonConvert.SerializeObject((object)authModel), (object)commonResult2.resultCode), "WARN");
                            return this.Json((object)commonResult2);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception] CreateMyWallet({0}) - uspGetUserId() Exception : {1}", (object)JsonConvert.SerializeObject((object)authModel), (object)ex.ToString()), "ERROR");
                    commonResult2.resultCode = 1;
                    commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)commonResult2);
                }
                dateTime1 = TradeModule.GetValuePackageExpiration(userInfo, this.Request.Host.ToString());
                dateTime2 = TradeModule.GetChargeBuffExpiration(userInfo, this.Request.Host.ToString(), (byte)0);
                num1 = TradeModule.getFamilyPoint(authModel.userNo, this.Request.Host.ToString(), userInfo._worldNo);
                num2 = TradeModule.getMaidCount(authModel.userNo, this.Request.Host.ToString(), userInfo._worldNo);
                flag = TradeModule.isGameMaster(authModel.userNo);
                worldMarketResultList = TradeModule.getFamilySkillList(authModel.userNo, this.Request.Host.ToString(), userInfo._worldNo);
                num3 = TradeModule.getRingBuffList(authModel.userNo, this.Request.Host.ToString(), userInfo._worldNo);
            }
            GameTradeMarketUserInfo tradeMarketUserInfo = new GameTradeMarketUserInfo()
            {
                userNickName = Convert.ToBase64String(Encoding.UTF8.GetBytes(userInfo._userNickName)),
                nationCode = userInfo._nationCode,
                worldNo = userInfo._worldNo,
                userNo = userInfo._userNo,
                packageExpiration = dateTime1,
                familyPoint = num1,
                maidCount = num2,
                isGameMaster = flag,
                familySkillList = worldMarketResultList,
                userId = empty,
                addWeightBuffExpiration = dateTime2,
                ringMaxCount = num3
            };
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/CreateMyWalletProcess", JsonConvert.SerializeObject((object)tradeMarketUserInfo), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CreateMyWallet({0}) - HttpRequest CreateMyWalletProcess errorMsg : {1}", (object)JsonConvert.SerializeObject((object)tradeMarketUserInfo), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            CommonResult commonResult3 = JsonConvert.DeserializeObject<CommonResult>(relResult);
            if (commonResult3 != null)
                return this.Json((object)commonResult3);
            LogUtil.WriteLog(string.Format("[Http Error]CreateMyWallet({0}) - HttpRequest CreateMyWalletProcess result : _result null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)tradeMarketUserInfo), (object)errorMsg), "WARN");
            return this.Json((object)new CommonResult()
            {
                resultCode = 5,
                resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull")
            });
        }

        [HttpPost]
        public JsonResult BuyItem(GameTradeMarketBuyAuth buyAuthmodel)
        {
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string errorMsg = string.Empty;
            string relResult = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("BuyItem Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, buyAuthmodel.userNo, buyAuthmodel.certifiedKey, true);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error]BuyItem({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)buyAuthmodel), (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            if (!userInfo._isWebAccess)
            {
                commonResult2 = TradeModule.CheckTicketNo(userInfo._userNo, this.Request.Host.ToString(), userInfo._worldNo, (byte)0, buyAuthmodel.ticketNo);
                if (commonResult2.resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("[Ticket Error]BuyItem({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)buyAuthmodel), (object)commonResult2.resultCode), "WARN");
                    return this.Json((object)commonResult2);
                }
            }
            commonResult2.resultCode = WorldMarketBase.checkValidCount<long, long>(buyAuthmodel.buyPrice, buyAuthmodel.buyCount);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Count Error] BuyItem({0}) invalidCount({1}, {2})", (object)JsonConvert.SerializeObject((object)buyAuthmodel), (object)buyAuthmodel.buyPrice, (object)buyAuthmodel.buyCount), "WARN");
                commonResult2.resultCode = 7;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketBuyInfo tradeMarketBuyInfo = new GameTradeMarketBuyInfo()
            {
                nationCode = userInfo._nationCode,
                worldNo = userInfo._worldNo,
                userNo = userInfo._userNo,
                buyKeyType = buyAuthmodel.buyKeyType,
                buyMainKey = buyAuthmodel.buyMainKey,
                buySubKey = buyAuthmodel.buySubKey,
                buyPrice = buyAuthmodel.buyPrice,
                buyCount = buyAuthmodel.buyCount,
                buyChooseKey = buyAuthmodel.buyChooseKey,
                isWebAccess = userInfo._isWebAccess,
                otp = buyAuthmodel.otp,
                retryBiddingNo = buyAuthmodel.retryBiddingNo
            };
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/BuyItemProcess", JsonConvert.SerializeObject((object)tradeMarketBuyInfo), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]BuyItem({0}) - HttpRequest BuyItemProcess errorMsg : {1}", (object)JsonConvert.SerializeObject((object)tradeMarketBuyInfo), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            CommonResult commonResult3 = JsonConvert.DeserializeObject<CommonResult>(relResult);
            if (commonResult3 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]BuyItem({0}) - HttpRequest BuyItemProcess result : _result null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)tradeMarketBuyInfo), (object)errorMsg), "WARN");
                return this.Json((object)new CommonResult()
                {
                    resultCode = 5,
                    resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull")
                });
            }
            if (commonResult3.resultCode == 0)
                commonResult3.resultMsg = commonResult3.resultMsg + "-" + Convert.ToString(userInfo._isReturn);
            return this.Json((object)commonResult3);
        }

        [HttpPost]
        public JsonResult SellItem(GameTradeMarketSellAuth sellAuthModel)
        {
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string errorMsg = string.Empty;
            string relResult = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("SellItem Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, sellAuthModel.userNo, sellAuthModel.certifiedKey, true);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error]SellItem({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)sellAuthModel), (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            if (!userInfo._isWebAccess)
            {
                commonResult2 = TradeModule.CheckTicketNo(userInfo._userNo, this.Request.Host.ToString(), userInfo._worldNo, (byte)1, sellAuthModel.ticketNo);
                if (commonResult2.resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("[Ticket Error]SellItem({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)sellAuthModel), (object)commonResult2.resultCode), "WARN");
                    return this.Json((object)commonResult2);
                }
            }
            commonResult2.resultCode = WorldMarketBase.checkValidCount<long, long>(sellAuthModel.sellPrice, sellAuthModel.sellCount);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Count Error] SellItem({0}) invalidCount({1}, {2})", (object)JsonConvert.SerializeObject((object)sellAuthModel), (object)sellAuthModel.sellPrice, (object)sellAuthModel.sellCount), "WARN");
                commonResult2.resultCode = 7;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount");
                return this.Json((object)commonResult2);
            }
            if (sellAuthModel.sellMainKey.Equals(0))
            {
                LogUtil.WriteLog(string.Format("[Param Error] SellItem({0}) Invalid ItemKey({1})", (object)JsonConvert.SerializeObject((object)sellAuthModel), (object)sellAuthModel.sellMainKey), "WARN");
                commonResult2.resultCode = 7;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketSellInfo tradeMarketSellInfo = new GameTradeMarketSellInfo()
            {
                nationCode = userInfo._nationCode,
                worldNo = userInfo._worldNo,
                userNo = userInfo._userNo,
                sellKeyType = sellAuthModel.sellKeyType,
                sellMainKey = sellAuthModel.sellMainKey,
                sellSubKey = sellAuthModel.sellSubKey,
                sellPrice = sellAuthModel.sellPrice,
                sellCount = sellAuthModel.sellCount,
                sellChooseKey = sellAuthModel.sellChooseKey,
                isSealed = sellAuthModel.isSealed,
                isWebAccess = userInfo._isWebAccess,
                isRingBuff = sellAuthModel.isRingBuff,
                otp = sellAuthModel.otp,
                retryBiddingNo = sellAuthModel.retryBiddingNo
            };
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/SellItemProcess", JsonConvert.SerializeObject((object)tradeMarketSellInfo), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]SellItem({0}) - HttpRequest SellItemProcess errorMsg : {1}", (object)JsonConvert.SerializeObject((object)tradeMarketSellInfo), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            CommonResult commonResult3 = JsonConvert.DeserializeObject<CommonResult>(relResult);
            if (commonResult3 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]SellItem({0}) - HttpRequest SellItemProcess result : _result null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)tradeMarketSellInfo), (object)errorMsg), "WARN");
                return this.Json((object)new CommonResult()
                {
                    resultCode = 5,
                    resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull")
                });
            }
            if (commonResult3.resultCode == 0)
                commonResult3.resultMsg = commonResult3.resultMsg + "-" + Convert.ToString(userInfo._isReturn);
            return this.Json((object)commonResult3);
        }

        [HttpPost]
        public JsonResult WithdrawBuyBidding(GameTradeMarketBuyBiddingAuth buyBiddingAuthModel)
        {
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string errorMsg = string.Empty;
            string relResult = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("WithdrawBuyBidding Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, buyBiddingAuthModel.userNo, buyBiddingAuthModel.certifiedKey);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error]WithdrawBuyBidding({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)buyBiddingAuthModel), (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            if (0L > buyBiddingAuthModel.count)
            {
                LogUtil.WriteLog(string.Format("[Count Error] WithdrawBuyBidding({0}) invalidCount({1}) ", (object)JsonConvert.SerializeObject((object)buyBiddingAuthModel), (object)buyBiddingAuthModel.count), "WARN");
                commonResult2.resultCode = 7;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketBiddingInfo marketBiddingInfo = new GameTradeMarketBiddingInfo()
            {
                nationCode = userInfo._nationCode,
                serverNo = userInfo._worldNo,
                userNo = userInfo._userNo,
                biddingNo = buyBiddingAuthModel.buyNo,
                keyType = buyBiddingAuthModel.keyType,
                mainKey = buyBiddingAuthModel.mainKey,
                subKey = buyBiddingAuthModel.subKey,
                count = buyBiddingAuthModel.count,
                isWebAccess = userInfo._isWebAccess
            };
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/WithdrawBuyBiddingProcess", JsonConvert.SerializeObject((object)marketBiddingInfo), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawBuyBidding({0}) - HttpRequest WithdrawBuyBiddingProcess errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketBiddingInfo), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            CommonResult commonResult3 = JsonConvert.DeserializeObject<CommonResult>(relResult);
            if (commonResult3 != null)
                return this.Json((object)commonResult3);
            LogUtil.WriteLog(string.Format("[Http Error]WithdrawBuyBidding({0}) - HttpRequest WithdrawBuyBiddingProcess result : _result null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketBiddingInfo), (object)errorMsg), "WARN");
            return this.Json((object)new CommonResult()
            {
                resultCode = 5,
                resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull")
            });
        }

        [HttpPost]
        public JsonResult CalculateBuyBidding(
          GameTradeMarketBuyBiddingAuth buyBiddingAuthModel)
        {
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string errorMsg = string.Empty;
            string relResult = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("CalculateBuyBidding Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, buyBiddingAuthModel.userNo, buyBiddingAuthModel.certifiedKey, true);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error]CalculateBuyBidding({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)buyBiddingAuthModel), (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketBiddingInfo marketBiddingInfo = new GameTradeMarketBiddingInfo()
            {
                nationCode = userInfo._nationCode,
                serverNo = userInfo._worldNo,
                userNo = userInfo._userNo,
                biddingNo = buyBiddingAuthModel.buyNo,
                keyType = buyBiddingAuthModel.keyType,
                mainKey = buyBiddingAuthModel.mainKey,
                subKey = buyBiddingAuthModel.subKey,
                isWebAccess = userInfo._isWebAccess
            };
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/CalculateBuyBiddingProcess", JsonConvert.SerializeObject((object)marketBiddingInfo), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CalculateBuyBidding({0}) - HttpRequest CalculateBuyBiddingProcess errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketBiddingInfo), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            CommonResult commonResult3 = JsonConvert.DeserializeObject<CommonResult>(relResult);
            if (commonResult3 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CalculateBuyBidding({0}) - HttpRequest CalculateBuyBiddingProcess result : _result null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketBiddingInfo), (object)errorMsg), "WARN");
                return this.Json((object)new CommonResult()
                {
                    resultCode = 5,
                    resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull")
                });
            }
            if (commonResult3.resultCode == 0)
                commonResult3.resultMsg = commonResult3.resultMsg + "-" + Convert.ToString(userInfo._isReturn);
            return this.Json((object)commonResult3);
        }

        [HttpPost]
        public JsonResult WithdrawSellBidding(
          GameTradeMarketSellBiddingAuth sellBiddingAuthModel)
        {
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string errorMsg = string.Empty;
            string relResult = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("WithdrawSellBidding Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, sellBiddingAuthModel.userNo, sellBiddingAuthModel.certifiedKey);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error]WithdrawSellBidding({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)sellBiddingAuthModel), (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            commonResult2.resultCode = WorldMarketBase.checkValidCount<int, long>(1, sellBiddingAuthModel.count);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Count Error] WithdrawSellBidding({0}) invalidCount({1}) ", (object)JsonConvert.SerializeObject((object)sellBiddingAuthModel), (object)sellBiddingAuthModel.count), "WARN");
                commonResult2.resultCode = 7;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketBiddingInfo marketBiddingInfo = new GameTradeMarketBiddingInfo()
            {
                nationCode = userInfo._nationCode,
                serverNo = userInfo._worldNo,
                userNo = userInfo._userNo,
                biddingNo = sellBiddingAuthModel.sellNo,
                keyType = sellBiddingAuthModel.keyType,
                mainKey = sellBiddingAuthModel.mainKey,
                subKey = sellBiddingAuthModel.subKey,
                isSealed = sellBiddingAuthModel.isSealed,
                count = sellBiddingAuthModel.count,
                isWebAccess = userInfo._isWebAccess
            };
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/WithdrawSellBiddingProcess", JsonConvert.SerializeObject((object)marketBiddingInfo), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawSellBidding({0}) - HttpRequest WithdrawSellBiddingProcess errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketBiddingInfo), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            CommonResult commonResult3 = JsonConvert.DeserializeObject<CommonResult>(relResult);
            if (commonResult3 != null)
                return this.Json((object)commonResult3);
            LogUtil.WriteLog(string.Format("[Http Error]WithdrawSellBidding({0}) - HttpRequest WithdrawSellBiddingProcess result : _result null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketBiddingInfo), (object)errorMsg), "WARN");
            return this.Json((object)new CommonResult()
            {
                resultCode = 5,
                resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull")
            });
        }

        [HttpPost]
        public JsonResult CalculateSellBidding(
          GameTradeMarketSellBiddingAuth sellBiddingAuthModel)
        {
            CommonResult commonResult1 = new CommonResult();
            UserInfomationModel userInfo = (UserInfomationModel)null;
            string errorMsg = string.Empty;
            string relResult = string.Empty;
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("CalculateSellBidding Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            CommonResult commonResult2 = TradeModule.CheckAuthKey(ref userInfo, sellBiddingAuthModel.userNo, sellBiddingAuthModel.certifiedKey, true);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Auth Error]CalculateSellBidding({0}) errorCode({1})", (object)JsonConvert.SerializeObject((object)sellBiddingAuthModel), (object)commonResult2.resultCode), "WARN");
                return this.Json((object)commonResult2);
            }
            GameTradeMarketBiddingInfo marketBiddingInfo = new GameTradeMarketBiddingInfo()
            {
                nationCode = userInfo._nationCode,
                serverNo = userInfo._worldNo,
                userNo = userInfo._userNo,
                biddingNo = sellBiddingAuthModel.sellNo,
                keyType = sellBiddingAuthModel.keyType,
                mainKey = sellBiddingAuthModel.mainKey,
                isSealed = sellBiddingAuthModel.isSealed,
                subKey = sellBiddingAuthModel.subKey,
                isWebAccess = userInfo._isWebAccess
            };
            commonResult2.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/CalculateSellBiddingProcess", JsonConvert.SerializeObject((object)marketBiddingInfo), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult2.resultCode != 0)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CalculateSellBidding({0}) - HttpRequest CalculateSellBidding errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketBiddingInfo), (object)errorMsg), "WARN");
                commonResult2.resultCode = 2;
                commonResult2.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult2);
            }
            CommonResult commonResult3 = JsonConvert.DeserializeObject<CommonResult>(relResult);
            if (commonResult3 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CalculateSellBidding({0}) - HttpRequest CalculateSellBidding result : _result null, errorMsg : {1}", (object)JsonConvert.SerializeObject((object)marketBiddingInfo), (object)errorMsg), "WARN");
                return this.Json((object)new CommonResult()
                {
                    resultCode = 5,
                    resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull")
                });
            }
            if (commonResult3.resultCode == 0)
                commonResult3.resultMsg = commonResult3.resultMsg + "-" + Convert.ToString(userInfo._isReturn);
            return this.Json((object)commonResult3);
        }

        [HttpPost]
        public JsonResult SetMaintenanceTradeMarket(MaintenanceRequestModel model)
        {
            CommonResult commonResult = new CommonResult();
            string relResult = string.Empty;
            string errorMsg = string.Empty;
            try
            {
                if (!CommonModule.CheckAllowIPAccess(CommonModule.GetRemoteIP()))
                {
                    commonResult.resultCode = -10001;
                    commonResult.resultMsg = "Not Allow IP";
                    LogUtil.WriteLog(string.Format("[ERROR] SetMaintenanceTradeMarket CheckAllowIPAccess Fail={0}", (object)CommonModule.GetRemoteIP()), "WARN");
                    return this.Json((object)commonResult);
                }
                if (model == null || string.IsNullOrEmpty(model._setType))
                {
                    commonResult.resultCode = -10002;
                    commonResult.resultMsg = "Empty Request Model";
                    return this.Json((object)commonResult);
                }
                LogUtil.WriteLog(string.Format("SetMaintenanceTradeMarket Request={0}//{1}", (object)CommonModule.GetRemoteIP(), (object)JsonConvert.SerializeObject((object)model)), "INFO");
                int num = CommonModule.HttpRequest(ConstantMgr._processDomain + "/SetMaintenance", JsonConvert.SerializeObject((object)model), "POST", "text/json", out relResult, out errorMsg);
                if (num != 0)
                {
                    commonResult.resultCode = num;
                    commonResult.resultMsg = "Porcess WebServer Request Fail.";
                    LogUtil.WriteLog(string.Format("[ERROR] Maintenance Info Process Request Fail={0}|{1}", (object)num, (object)(ConstantMgr._processDomain + "/SetMaintenance")), "WARN");
                    return this.Json((object)commonResult);
                }
                commonResult = JsonConvert.DeserializeObject<CommonResult>(relResult);
                if (commonResult != null)
                {
                    if (commonResult.resultCode == 0)
                        goto label_13;
                }
                if (commonResult == null)
                {
                    commonResult = new CommonResult();
                    commonResult.resultCode = -99998;
                }
                LogUtil.WriteLog(string.Format("[ERROR] Maintenance Info SaveFail=requestResultCode|{0}", (object)(ConstantMgr._processDomain + "/SetMaintenance")), "WARN");
            }
            catch (Exception ex)
            {
                commonResult.resultCode = -99999;
                commonResult.resultMsg = "[Game]Maintenance Information Save Exception Error.";
                LogUtil.WriteLog(string.Format("[Exception] SetMaintenanceTradeMarket() : {0}", (object)ex.ToString()), "ERROR");
            }
        label_13:
            return this.Json((object)commonResult);
        }
    }
}
