// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.Controllers.GameProcess.GameProcessController
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.DB;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using GB.BlackDesert.Trade.Web.Process.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.Process.Controllers.GameProcess
{
    public class GameProcessController : Controller
    {
        private CommandProcess _commnadProcess = new CommandProcess();
        private static int currentIndex;

        [HttpPost]
        public JsonResult SetMarketItemProcess()
        {
            string empty1 = string.Empty;
            long num = 0;
            GameTradeMarketItemInfo tradeMarketItemInfo1 = new GameTradeMarketItemInfo();
            GameTradeMarketPayload tradeMarketPayload = new GameTradeMarketPayload();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("SetMarketItemProcess Fail is Not Open"), "WARN");
                tradeMarketPayload.result.resultCode = 2;
                tradeMarketPayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)tradeMarketPayload);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog(string.Format("SetMarketItemProcess log DB Exception"), "WARN");
                tradeMarketPayload.result.resultCode = 1;
                tradeMarketPayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)tradeMarketPayload);
            }
            string empty2 = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]SetMarketItemProcess({0}) - HttpRequest errorMsg : {1}", (object)empty2, (object)ex.ToString()), "ERROR");
                tradeMarketPayload.result.resultCode = 3;
                tradeMarketPayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONException");
                return this.Json((object)tradeMarketPayload);
            }
            GameTradeMarketItemInfo tradeMarketItemInfo2 = JsonConvert.DeserializeObject<GameTradeMarketItemInfo>(end);
            if (tradeMarketItemInfo2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]SetMarketItemProcess({0}) - pushItemModel is null", (object)end), "WARN");
                tradeMarketPayload.result.resultCode = 5;
                tradeMarketPayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)tradeMarketPayload);
            }
            WorldMarketLog.OperationType operationType;
            TradeMarketItemInfo tradeMarketItemInfo3;
            switch ((KeyType)tradeMarketItemInfo2.keyType)
            {
                case KeyType.eItem:
                    operationType = WorldMarketLog.OperationType.eWorldMarket_OperationType_Item;
                    tradeMarketItemInfo3 = ItemInfoManager.This().getInfo(tradeMarketItemInfo2.mainKey, tradeMarketItemInfo2.subKey);
                    if (!tradeMarketItemInfo3.isValid() && 1 != tradeMarketItemInfo2.mainKey)
                    {
                        LogUtil.WriteLog(string.Format("[Item Error]SetMarketItemProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", (object)end, (object)tradeMarketItemInfo2.mainKey, (object)tradeMarketItemInfo2.subKey), "WARN");
                        tradeMarketPayload.result.resultCode = 8;
                        tradeMarketPayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                        return this.Json((object)tradeMarketPayload);
                    }
                    if (tradeMarketItemInfo3._maxStackCount < tradeMarketItemInfo2.count && 1 != tradeMarketItemInfo2.mainKey)
                    {
                        LogUtil.WriteLog(string.Format("[Item Error]SetMarketItemProcess({0}) itemInfo({1}, {2}) ItemStack is Invalid", (object)end, (object)tradeMarketItemInfo2.mainKey, (object)tradeMarketItemInfo2.subKey), "WARN");
                        tradeMarketPayload.result.resultCode = 16;
                        tradeMarketPayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemStack");
                        return this.Json((object)tradeMarketPayload);
                    }
                    break;
                case KeyType.eServant:
                    operationType = WorldMarketLog.OperationType.eWorldMarket_OperationType_Servant;
                    tradeMarketItemInfo3 = ItemInfoManager.This().getServantInfo(tradeMarketItemInfo2.mainKey, tradeMarketItemInfo2.subKey);
                    if (!tradeMarketItemInfo3.isValid())
                    {
                        LogUtil.WriteLog(string.Format("[Item Error]SetMarketItemProcess({0}) itemInfo({1}, {2}) Not Exist ServantInfo", (object)end, (object)tradeMarketItemInfo2.mainKey, (object)tradeMarketItemInfo2.subKey), "WARN");
                        tradeMarketPayload.result.resultCode = 8;
                        tradeMarketPayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                        return this.Json((object)tradeMarketPayload);
                    }
                    if (tradeMarketItemInfo3._maxStackCount < tradeMarketItemInfo2.count)
                    {
                        LogUtil.WriteLog(string.Format("[Item Error]SetMarketItemProcess({0}) ServantInfo({1}, {2}) ItemStack is Invalid", (object)end, (object)tradeMarketItemInfo2.mainKey, (object)tradeMarketItemInfo2.subKey), "WARN");
                        tradeMarketPayload.result.resultCode = 16;
                        tradeMarketPayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemStack");
                        return this.Json((object)tradeMarketPayload);
                    }
                    break;
                default:
                    LogUtil.WriteLog(string.Format("[Item Error]SetMarketItemProcess({0}) itemInfo({1}) Not Exist keyType", (object)end, (object)tradeMarketItemInfo2.keyType), "WARN");
                    tradeMarketPayload.result.resultCode = 8;
                    tradeMarketPayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                    return this.Json((object)tradeMarketPayload);
            }
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    ObjectParameter payload = new ObjectParameter("payload", typeof(long));
                    ObjectParameter isNotError = new ObjectParameter("isNotError", typeof(bool));
                    tradeWebDb.uspPrepareDepositToWorldMarket(new int?(tradeMarketItemInfo2.nationCode), new int?(tradeMarketItemInfo2.serverNo), new long?(tradeMarketItemInfo2.userNo), new int?(tradeMarketItemInfo2.keyType), new int?(tradeMarketItemInfo2.mainKey), new int?(tradeMarketItemInfo2.subKey), new long?(tradeMarketItemInfo2.param0), new long?(tradeMarketItemInfo2.param1), new long?(tradeMarketItemInfo2.param2), new long?(tradeMarketItemInfo2.param3), new long?(tradeMarketItemInfo2.param4), new long?(tradeMarketItemInfo2.count), new bool?(tradeMarketItemInfo2.isSealed), new long?(tradeMarketItemInfo3._weight), new long?(WorldMarketOptionManager.This().getMaxWeight()), payload, isNotError, symNo, rv);
                    int int32 = Convert.ToInt32(rv.Value);
                    string str = Convert.ToString(symNo.Value);
                    num = Convert.ToInt64(payload.Value);
                    if (int32 != 0)
                    {
                        tradeMarketPayload.result.resultCode = int32;
                        tradeMarketPayload.result.resultMsg = str;
                        if (!Convert.ToBoolean(isNotError.Value))
                            LogUtil.WriteLog(string.Format("[DB Error]SetMarketItemProcess - uspPrepareDepositToWorldMarket({0}/{1}), rv({2})", (object)end, (object)num, (object)int32), "WARN");
                        else
                            tradeMarketPayload.result.resultCode = 100;
                        return this.Json((object)tradeMarketPayload);
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception] SetMarketItemProcess({0}) - uspPrepareDepositToWorldMarket() Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                tradeMarketPayload.result.resultCode = 1;
                return this.Json((object)tradeMarketPayload);
            }
            tradeMarketPayload.payload = num;
            WorldMarketLog.logWorldMarket(operationType, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_Push, CommonModule.GetCustomTime(), new CommonModel.TradeMarketUserLogInfo()
            {
                nationCode = tradeMarketItemInfo2.nationCode,
                serverNo = tradeMarketItemInfo2.serverNo,
                userNo = tradeMarketItemInfo2.userNo
            }, new CommonModel.TradeMarketItemLogInfo()
            {
                keyType1 = tradeMarketItemInfo2.keyType,
                itemKey1 = tradeMarketItemInfo2.mainKey,
                enchantLevel1 = tradeMarketItemInfo2.subKey,
                count1 = tradeMarketItemInfo2.count
            }, num, tradeMarketItemInfo2.param0, tradeMarketItemInfo2.param1, tradeMarketItemInfo2.param2, tradeMarketItemInfo2.param3, tradeMarketItemInfo2.param4, Convert.ToInt64(tradeMarketItemInfo2.isSealed));
            return this.Json((object)tradeMarketPayload);
        }

        [HttpPost]
        public JsonResult RegisterMarketItemProcess()
        {
            string empty1 = string.Empty;
            GameTradeMarketIncludePayload marketIncludePayload1 = new GameTradeMarketIncludePayload();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("RegisterMarketItemProcess Fail is Not Open", "WARN");
                marketIncludePayload1.result.resultCode = 2;
                marketIncludePayload1.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)marketIncludePayload1);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog("RegisterMarketItemProcess log DB Exception", "WARN");
                marketIncludePayload1.result.resultCode = 1;
                marketIncludePayload1.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)marketIncludePayload1);
            }
            string empty2 = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]RegisterMarketItemProcess({0}) - HttpRequest errorMsg : {1}", (object)empty2, (object)ex.ToString()), "ERROR");
                marketIncludePayload1.result.resultCode = 3;
                marketIncludePayload1.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONException");
                return this.Json((object)marketIncludePayload1);
            }
            GameTradeMarketIncludePayload marketIncludePayload2 = JsonConvert.DeserializeObject<GameTradeMarketIncludePayload>(end);
            if (marketIncludePayload2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]RegisterMarketItemProcess({0}) - model is null", (object)end), "WARN");
                return this.Json((object)new GameTradeMarketIncludePayload()
                {
                    result = {
            resultCode = 5,
            resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull")
          }
                });
            }
            int num = 0;
            WorldMarketLog.OperationType operationType = WorldMarketLog.OperationType.eWorldMarket_OperationType_End;
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter keyType = new ObjectParameter("keyType", typeof(int));
            ObjectParameter reason = new ObjectParameter("reason", typeof(int));
            ObjectParameter mainKey = new ObjectParameter("mainKey", typeof(int));
            ObjectParameter subKey = new ObjectParameter("subKey", typeof(int));
            ObjectParameter objectParameter1 = new ObjectParameter("param0", typeof(long));
            ObjectParameter objectParameter2 = new ObjectParameter("param1", typeof(long));
            ObjectParameter objectParameter3 = new ObjectParameter("param2", typeof(long));
            ObjectParameter objectParameter4 = new ObjectParameter("param3", typeof(long));
            ObjectParameter objectParameter5 = new ObjectParameter("param4", typeof(long));
            ObjectParameter count = new ObjectParameter("count", typeof(long));
            ObjectParameter isSealed = new ObjectParameter("isSealed", typeof(bool));
            ObjectParameter beforeCount1 = new ObjectParameter("beforeCount1", typeof(long));
            ObjectParameter afterCount1 = new ObjectParameter("afterCount1", typeof(long));
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    tradeWebDb.uspProcessDepositToWorldMarket(new long?(marketIncludePayload2.payload), reason, keyType, mainKey, subKey, isSealed, objectParameter1, objectParameter2, objectParameter3, objectParameter4, objectParameter5, count, beforeCount1, afterCount1, symNo, rv);
                    int int32 = Convert.ToInt32(rv.Value);
                    string textParam1 = Convert.ToString(symNo.Value);
                    num = Convert.ToInt32(reason.Value);
                    switch ((KeyType)marketIncludePayload2.keyType)
                    {
                        case KeyType.eItem:
                            operationType = WorldMarketLog.OperationType.eWorldMarket_OperationType_Item;
                            break;
                        case KeyType.eServant:
                            operationType = WorldMarketLog.OperationType.eWorldMarket_OperationType_Servant;
                            break;
                    }
                    if (int32 != 0)
                    {
                        WorldMarketLog.logWorldMarket(operationType, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_Fail_Push, CommonModule.GetCustomTime(), new CommonModel.TradeMarketUserLogInfo()
                        {
                            nationCode = marketIncludePayload2.nationCode,
                            serverNo = marketIncludePayload2.serverNo,
                            userNo = marketIncludePayload2.userNo
                        }, new CommonModel.TradeMarketItemLogInfo()
                        {
                            keyType1 = marketIncludePayload2.keyType,
                            itemKey1 = marketIncludePayload2.mainKey,
                            enchantLevel1 = marketIncludePayload2.subKey,
                            count1 = marketIncludePayload2.count,
                            beforeCount1 = 0L,
                            afterCount1 = 0L
                        }, marketIncludePayload2.payload, (long)int32, marketIncludePayload2.param0, marketIncludePayload2.param1, marketIncludePayload2.param2, marketIncludePayload2.param3, marketIncludePayload2.param4, textParam1: textParam1);
                        LogUtil.WriteLog(string.Format("[DB Error]RegisterMarketItemProcess() - uspProcessDepositToWorldMarket({0}), rv({1})", (object)end, (object)int32), "WARN");
                        marketIncludePayload2.result.resultCode = int32;
                        marketIncludePayload2.result.resultMsg = textParam1;
                        return this.Json((object)marketIncludePayload2);
                    }
                    marketIncludePayload2.keyType = Convert.ToInt32(keyType.Value);
                    marketIncludePayload2.mainKey = Convert.ToInt32(mainKey.Value);
                    marketIncludePayload2.subKey = Convert.ToInt32(subKey.Value);
                    marketIncludePayload2.param0 = Convert.ToInt64(objectParameter1.Value);
                    marketIncludePayload2.param1 = Convert.ToInt64(objectParameter2.Value);
                    marketIncludePayload2.param2 = Convert.ToInt64(objectParameter3.Value);
                    marketIncludePayload2.param3 = Convert.ToInt64(objectParameter4.Value);
                    marketIncludePayload2.param4 = Convert.ToInt64(objectParameter5.Value);
                    marketIncludePayload2.count = Convert.ToInt64(count.Value);
                    marketIncludePayload2.isSealed = Convert.ToBoolean(isSealed.Value);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception]RegisterMarketItemProcess() - uspProcessDepositToWorldMarket({0}) Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                marketIncludePayload2.result.resultCode = 1;
                return this.Json((object)marketIncludePayload2);
            }
            CommonModel.TradeMarketUserLogInfo userInfo = new CommonModel.TradeMarketUserLogInfo();
            userInfo.nationCode = marketIncludePayload2.nationCode;
            userInfo.serverNo = marketIncludePayload2.serverNo;
            userInfo.userNo = marketIncludePayload2.userNo;
            CommonModel.TradeMarketItemLogInfo itemInfo = new CommonModel.TradeMarketItemLogInfo();
            itemInfo.keyType1 = marketIncludePayload2.keyType;
            itemInfo.itemKey1 = marketIncludePayload2.mainKey;
            itemInfo.enchantLevel1 = marketIncludePayload2.subKey;
            itemInfo.count1 = marketIncludePayload2.count;
            itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1.Value);
            itemInfo.afterCount1 = Convert.ToInt64(afterCount1.Value);
            WorldMarketLog.logWorldMarket(operationType, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_Push, CommonModule.GetCustomTime(), userInfo, itemInfo, marketIncludePayload2.payload, 1L, (long)num, marketIncludePayload2.param0, marketIncludePayload2.param1, marketIncludePayload2.param2, marketIncludePayload2.param3, Convert.ToInt64(marketIncludePayload2.isSealed));
            if (marketIncludePayload2.isRestoration)
                WorldMarketLog.logWorldMarket(operationType, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_Restoration, CommonModule.GetCustomTime(), userInfo, itemInfo, marketIncludePayload2.payload, (long)num, param4: marketIncludePayload2.param0, param5: marketIncludePayload2.param1, param6: marketIncludePayload2.param2, param7: marketIncludePayload2.param3, param8: marketIncludePayload2.param4);
            return this.Json((object)marketIncludePayload2);
        }

        [HttpPost]
        public JsonResult PreWithdrawItemProcess()
        {
            string empty1 = string.Empty;
            GameTradeMarketItemInfo tradeMarketItemInfo1 = new GameTradeMarketItemInfo();
            GameTradeMarketIncludePayload marketIncludePayload = new GameTradeMarketIncludePayload();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("PreWithdrawItemProcess Fail is Not Open"), "WARN");
                marketIncludePayload.result.resultCode = 2;
                marketIncludePayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)marketIncludePayload);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog(string.Format("PreWithdrawItemProcess log DB Exception"), "WARN");
                marketIncludePayload.result.resultCode = 1;
                marketIncludePayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)marketIncludePayload);
            }
            string empty2 = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]PreWithdrawItemProcess({0}) - HttpRequest errorMsg : {1}", (object)empty2, (object)ex.ToString()), "ERROR");
                marketIncludePayload.result.resultCode = 3;
                marketIncludePayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONException");
                return this.Json((object)marketIncludePayload);
            }
            GameTradeMarketItemInfo tradeMarketItemInfo2 = JsonConvert.DeserializeObject<GameTradeMarketItemInfo>(end);
            if (tradeMarketItemInfo2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]PreWithdrawItemProcess({0}) - popItemModel is null", (object)end), "WARN");
                marketIncludePayload.result.resultCode = 5;
                marketIncludePayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)marketIncludePayload);
            }
            WorldMarketLog.OperationType operationType;
            TradeMarketItemInfo tradeMarketItemInfo3;
            switch ((KeyType)tradeMarketItemInfo2.keyType)
            {
                case KeyType.eItem:
                    operationType = WorldMarketLog.OperationType.eWorldMarket_OperationType_Item;
                    tradeMarketItemInfo3 = ItemInfoManager.This().getInfo(tradeMarketItemInfo2.mainKey, tradeMarketItemInfo2.subKey);
                    if (!tradeMarketItemInfo3.isValid() && 1 != tradeMarketItemInfo2.mainKey)
                    {
                        LogUtil.WriteLog(string.Format("[Item Error]PreWithdrawItemProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", (object)end, (object)tradeMarketItemInfo2.mainKey, (object)tradeMarketItemInfo2.subKey), "WARN");
                        marketIncludePayload.result.resultCode = 8;
                        marketIncludePayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                        return this.Json((object)marketIncludePayload);
                    }
                    if (tradeMarketItemInfo3._maxStackCount < tradeMarketItemInfo2.count && 1 != tradeMarketItemInfo2.mainKey)
                    {
                        LogUtil.WriteLog(string.Format("[Item Error]PreWithdrawItemProcess({0}) itemInfo({1}, {2}) ItemStack is Invalid", (object)end, (object)tradeMarketItemInfo2.mainKey, (object)tradeMarketItemInfo2.subKey), "WARN");
                        marketIncludePayload.result.resultCode = 16;
                        marketIncludePayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemStack");
                        return this.Json((object)marketIncludePayload);
                    }
                    break;
                case KeyType.eServant:
                    operationType = WorldMarketLog.OperationType.eWorldMarket_OperationType_Servant;
                    tradeMarketItemInfo3 = ItemInfoManager.This().getServantInfo(tradeMarketItemInfo2.mainKey, tradeMarketItemInfo2.subKey);
                    if (!tradeMarketItemInfo3.isValid())
                    {
                        LogUtil.WriteLog(string.Format("[Item Error]PreWithdrawItemProcess({0}) itemInfo({1}, {2}) Not Exist ServantInfo", (object)end, (object)tradeMarketItemInfo2.mainKey, (object)tradeMarketItemInfo2.subKey), "WARN");
                        marketIncludePayload.result.resultCode = 8;
                        marketIncludePayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                        return this.Json((object)marketIncludePayload);
                    }
                    if (tradeMarketItemInfo3._maxStackCount < tradeMarketItemInfo2.count)
                    {
                        LogUtil.WriteLog(string.Format("[Item Error]PreWithdrawItemProcess({0}) ServantInfo({1}, {2}) ItemStack is Invalid", (object)end, (object)tradeMarketItemInfo2.mainKey, (object)tradeMarketItemInfo2.subKey), "WARN");
                        marketIncludePayload.result.resultCode = 16;
                        marketIncludePayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemStack");
                        return this.Json((object)marketIncludePayload);
                    }
                    break;
                default:
                    LogUtil.WriteLog(string.Format("[Item Error]PreWithdrawItemProcess({0}) itemInfo({1}) Not Exist keyType", (object)end, (object)tradeMarketItemInfo2.keyType), "WARN");
                    marketIncludePayload.result.resultCode = 8;
                    marketIncludePayload.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                    return this.Json((object)marketIncludePayload);
            }
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    ObjectParameter payload = new ObjectParameter("payload", typeof(long));
                    ObjectParameter objectParameter1 = new ObjectParameter("param0", typeof(long));
                    ObjectParameter objectParameter2 = new ObjectParameter("param1", typeof(long));
                    ObjectParameter objectParameter3 = new ObjectParameter("param2", typeof(long));
                    ObjectParameter objectParameter4 = new ObjectParameter("param3", typeof(long));
                    ObjectParameter objectParameter5 = new ObjectParameter("param4", typeof(long));
                    tradeWebDb.uspPrepareWithdrawFromWorldMarket(new int?(tradeMarketItemInfo2.nationCode), new int?(tradeMarketItemInfo2.serverNo), new long?(tradeMarketItemInfo2.userNo), new int?(tradeMarketItemInfo2.keyType), new int?(tradeMarketItemInfo2.mainKey), new int?(tradeMarketItemInfo2.subKey), new bool?(tradeMarketItemInfo2.isSealed), new long?(tradeMarketItemInfo2.count), new long?(tradeMarketItemInfo3._weight), payload, objectParameter1, objectParameter2, objectParameter3, objectParameter4, objectParameter5, symNo, rv);
                    int int32 = Convert.ToInt32(rv.Value);
                    string str = Convert.ToString(symNo.Value);
                    if (int32 != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]PreWithdrawItemProcess - uspPrepareWithdrawFromWorldMarket({0}), rv({1})", (object)end, (object)int32), "WARN");
                        marketIncludePayload.result.resultCode = int32;
                        marketIncludePayload.result.resultMsg = str;
                        return this.Json((object)marketIncludePayload);
                    }
                    marketIncludePayload.payload = Convert.ToInt64(payload.Value);
                    marketIncludePayload.param0 = Convert.ToInt64(objectParameter1.Value);
                    marketIncludePayload.param1 = Convert.ToInt64(objectParameter2.Value);
                    marketIncludePayload.param2 = Convert.ToInt64(objectParameter3.Value);
                    marketIncludePayload.param3 = Convert.ToInt64(objectParameter4.Value);
                    marketIncludePayload.param4 = Convert.ToInt64(objectParameter5.Value);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception]PreWithdrawItemProcess() - uspPrepareWithdrawFromWorldMarket({0}) Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                marketIncludePayload.result.resultCode = 1;
                return this.Json((object)marketIncludePayload);
            }
            WorldMarketLog.logWorldMarket(operationType, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_Pop, CommonModule.GetCustomTime(), new CommonModel.TradeMarketUserLogInfo()
            {
                nationCode = tradeMarketItemInfo2.nationCode,
                serverNo = tradeMarketItemInfo2.serverNo,
                userNo = tradeMarketItemInfo2.userNo
            }, new CommonModel.TradeMarketItemLogInfo()
            {
                keyType1 = tradeMarketItemInfo2.keyType,
                itemKey1 = tradeMarketItemInfo2.mainKey,
                enchantLevel1 = tradeMarketItemInfo2.subKey,
                count1 = tradeMarketItemInfo2.count
            }, marketIncludePayload.payload, marketIncludePayload.param0, marketIncludePayload.param1, marketIncludePayload.param2, marketIncludePayload.param3, marketIncludePayload.param4, Convert.ToInt64(tradeMarketItemInfo2.isSealed));
            return this.Json((object)marketIncludePayload);
        }

        [HttpPost]
        public JsonResult CompleteWithdrawItemProcess()
        {
            string empty1 = string.Empty;
            GameTradeMarketIncludePayload marketIncludePayload1 = new GameTradeMarketIncludePayload();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("CompleteWithdrawItemProcess Fail is Not Open", "WARN");
                marketIncludePayload1.result.resultCode = 2;
                marketIncludePayload1.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)marketIncludePayload1);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog("CompleteWithdrawItemProcess log DB Exception", "WARN");
                marketIncludePayload1.result.resultCode = 1;
                marketIncludePayload1.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)marketIncludePayload1);
            }
            string empty2 = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CompleteWithdrawItemProcess({0}) - HttpRequest errorMsg : {1}", (object)empty2, (object)ex.ToString()), "ERROR");
                marketIncludePayload1.result.resultCode = 3;
                marketIncludePayload1.result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONException");
                return this.Json((object)marketIncludePayload1);
            }
            GameTradeMarketIncludePayload marketIncludePayload2 = JsonConvert.DeserializeObject<GameTradeMarketIncludePayload>(end);
            if (marketIncludePayload2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CompleteWithdrawItemProcess({0}) - model is null", (object)end), "WARN");
                return this.Json((object)new GameTradeMarketIncludePayload()
                {
                    result = {
            resultCode = 5,
            resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull")
          }
                });
            }
            WorldMarketLog.OperationType operationType = WorldMarketLog.OperationType.eWorldMarket_OperationType_End;
            switch ((KeyType)marketIncludePayload2.keyType)
            {
                case KeyType.eItem:
                    operationType = WorldMarketLog.OperationType.eWorldMarket_OperationType_Item;
                    break;
                case KeyType.eServant:
                    operationType = WorldMarketLog.OperationType.eWorldMarket_OperationType_Servant;
                    break;
            }
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter reason = new ObjectParameter("reason", typeof(int));
            ObjectParameter beforeCount1 = new ObjectParameter("beforeCount1", typeof(long));
            ObjectParameter afterCount1 = new ObjectParameter("afterCount1", typeof(long));
            int num = 0;
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    tradeWebDb.uspProcessWithdrawFromWorldMarket(new long?(marketIncludePayload2.payload), reason, beforeCount1, afterCount1, symNo, rv);
                    int int32 = Convert.ToInt32(rv.Value);
                    string textParam1 = Convert.ToString(symNo.Value);
                    num = Convert.ToInt32(reason.Value);
                    if (int32 != 0)
                    {
                        WorldMarketLog.logWorldMarket(operationType, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_Fail_Pop, CommonModule.GetCustomTime(), new CommonModel.TradeMarketUserLogInfo()
                        {
                            nationCode = marketIncludePayload2.nationCode,
                            serverNo = marketIncludePayload2.serverNo,
                            userNo = marketIncludePayload2.userNo
                        }, new CommonModel.TradeMarketItemLogInfo()
                        {
                            keyType1 = marketIncludePayload2.keyType,
                            itemKey1 = marketIncludePayload2.mainKey,
                            enchantLevel1 = marketIncludePayload2.subKey,
                            count1 = marketIncludePayload2.count,
                            beforeCount1 = 0L,
                            afterCount1 = 0L
                        }, marketIncludePayload2.payload, (long)int32, marketIncludePayload2.param0, marketIncludePayload2.param1, marketIncludePayload2.param2, marketIncludePayload2.param3, marketIncludePayload2.param4, textParam1: textParam1);
                        LogUtil.WriteLog(string.Format("[DB Error]CompleteWithdrawItemProcess - uspProcessWithdrawFromWorldMarket({0}), rv({1})", (object)end, (object)int32), "WARN");
                        marketIncludePayload2.result.resultCode = int32;
                        marketIncludePayload2.result.resultMsg = textParam1;
                        return this.Json((object)marketIncludePayload2);
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception]CompleteWithdrawItemProcess() - uspProcessWithdrawFromWorldMarket({0}) Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                marketIncludePayload2.result.resultCode = 1;
                return this.Json((object)marketIncludePayload2);
            }
            WorldMarketLog.logWorldMarket(operationType, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_Pop, CommonModule.GetCustomTime(), new CommonModel.TradeMarketUserLogInfo()
            {
                nationCode = marketIncludePayload2.nationCode,
                serverNo = marketIncludePayload2.serverNo,
                userNo = marketIncludePayload2.userNo
            }, new CommonModel.TradeMarketItemLogInfo()
            {
                keyType1 = marketIncludePayload2.keyType,
                itemKey1 = marketIncludePayload2.mainKey,
                enchantLevel1 = marketIncludePayload2.subKey,
                count1 = marketIncludePayload2.count,
                beforeCount1 = Convert.ToInt64(beforeCount1.Value),
                afterCount1 = Convert.ToInt64(afterCount1.Value)
            }, marketIncludePayload2.payload, 1L, (long)num, marketIncludePayload2.param0, marketIncludePayload2.param1, marketIncludePayload2.param2, marketIncludePayload2.param3, Convert.ToInt64(marketIncludePayload2.isSealed));
            return this.Json((object)marketIncludePayload2);
        }

        [HttpPost]
        public JsonResult CreateMyWalletProcess()
        {
            CommonResult commonResult = new CommonResult();
            GameTradeMarketUserInfo tradeMarketUserInfo1 = new GameTradeMarketUserInfo();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("CreateMyWalletProcess Fail is Not Open"), "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog(string.Format("CreateMyWalletProcess log DB Exception"), "WARN");
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult);
            }
            string empty = string.Empty;
            bool flag = false;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CreateMyWalletProcess({0}) - HttpRequest errorMsg : {1}", (object)empty, (object)ex.ToString()), "ERROR");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            GameTradeMarketUserInfo tradeMarketUserInfo2 = JsonConvert.DeserializeObject<GameTradeMarketUserInfo>(end);
            if (tradeMarketUserInfo2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CreateMyWalletProcess({0}) - model is null", (object)end), "WARN");
                commonResult.resultCode = 5;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)tradeMarketUserInfo2);
            }
            tradeMarketUserInfo2.userNickName = Encoding.UTF8.GetString(Convert.FromBase64String(tradeMarketUserInfo2.userNickName));
            int num1 = 0;
            double num2 = 0.0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            if (ConstantMgr._serviceProject.Equals("BDO"))
            {
                num1 = VariedTradeCountManager.This().getAddTradeCountByFamilyPoint((long)tradeMarketUserInfo2.familyPoint);
                num2 = VariedTradeCountManager.This().getAddTaxDiscountRateByFamilyPoint((long)tradeMarketUserInfo2.familyPoint);
                num3 = FamilySkillManager.This().getAddTaxDiscountRateByFamilySkill(tradeMarketUserInfo2.familySkillList);
                num4 = WorldMarketOptionManager.This().getIncreaseWeightByFamilyPoint(tradeMarketUserInfo2.familyPoint);
                num5 = WorldMarketOptionManager.This().getIncreaseWeightByBuff(tradeMarketUserInfo2.addWeightBuffExpiration);
            }
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    ObjectParameter isCreateWallet = new ObjectParameter("isCreateWallet", typeof(bool));
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    tradeWebDb.uspCreateMyWallet(tradeMarketUserInfo2.userId, new int?(tradeMarketUserInfo2.nationCode), new int?(tradeMarketUserInfo2.worldNo), new long?(tradeMarketUserInfo2.userNo), tradeMarketUserInfo2.userNickName, new DateTime?(tradeMarketUserInfo2.packageExpiration), new DateTime?(tradeMarketUserInfo2.addWeightBuffExpiration), new int?(num1), new int?(tradeMarketUserInfo2.maidCount), new bool?(tradeMarketUserInfo2.isGameMaster), new double?(num2), new int?(num3), new int?(num4), new int?(num5), new int?(tradeMarketUserInfo2.ringMaxCount), isCreateWallet, symNo, rv);
                    commonResult.resultCode = Convert.ToInt32(rv.Value);
                    commonResult.resultMsg = Convert.ToString(symNo.Value);
                    flag = Convert.ToBoolean(isCreateWallet.Value);
                }
                if (commonResult.resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("[DB Error]CreateMyWalletProcess() - uspCreateMyWallet({0}/{1}/{2}/{3}), rv({4})", (object)tradeMarketUserInfo2.nationCode, (object)tradeMarketUserInfo2.worldNo, (object)tradeMarketUserInfo2.userNo, (object)tradeMarketUserInfo2.userNickName, (object)commonResult.resultCode), "WARN");
                    return this.Json((object)commonResult);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception]CreateMyWalletProcess() - uspCreateMyWallet({0}) Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult);
            }
            if (flag)
            {
                CommonModel.TradeMarketUserLogInfo userInfo = new CommonModel.TradeMarketUserLogInfo()
                {
                    nationCode = tradeMarketUserInfo2.nationCode,
                    serverNo = tradeMarketUserInfo2.worldNo,
                    userNo = tradeMarketUserInfo2.userNo
                };
                CommonModel.TradeMarketItemLogInfo itemInfo = new CommonModel.TradeMarketItemLogInfo();
                WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_User, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_CreateWallet, CommonModule.GetCustomTime(), userInfo, itemInfo);
                commonResult.resultMsg = "1";
            }
            else
                commonResult.resultMsg = "0";
            commonResult.resultMsg = commonResult.resultMsg + "-" + Convert.ToString(WorldMarketOptionManager.This().getBiddingPercent());
            return this.Json((object)commonResult);
        }

        [HttpPost]
        public JsonResult BuyItemProcess()
        {
            CommonResult commonResult1 = new CommonResult();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter realBuyCount = new ObjectParameter("realBuyCount", typeof(long));
            ObjectParameter walletMoney = new ObjectParameter("walletMoney", typeof(long));
            ObjectParameter totalMoneyCount = new ObjectParameter("totalMoneyCount", typeof(long));
            ObjectParameter biddingMoneyCount = new ObjectParameter("biddingMoneyCount", typeof(long));
            ObjectParameter sellNo = new ObjectParameter("sellNo", typeof(long));
            ObjectParameter sellUserNo = new ObjectParameter("sellUserNo", typeof(long));
            ObjectParameter sellUserId = new ObjectParameter("sellUserId", typeof(string));
            ObjectParameter sellLeftCount = new ObjectParameter("sellLeftCount", typeof(long));
            ObjectParameter buyNo = new ObjectParameter("buyNo", typeof(long));
            ObjectParameter raceCount = new ObjectParameter("raceCount", typeof(long));
            ObjectParameter stopType = new ObjectParameter("stopType", typeof(int));
            ObjectParameter beforeCount1 = new ObjectParameter("beforeCount1", typeof(long));
            ObjectParameter beforeCount2 = new ObjectParameter("beforeCount2", typeof(long));
            ObjectParameter beforeCount3 = new ObjectParameter("beforeCount3", typeof(long));
            ObjectParameter beforeCount4 = new ObjectParameter("beforeCount4", typeof(long));
            ObjectParameter afterCount1 = new ObjectParameter("afterCount1", typeof(long));
            ObjectParameter afterCount2 = new ObjectParameter("afterCount2", typeof(long));
            ObjectParameter afterCount3 = new ObjectParameter("afterCount3", typeof(long));
            ObjectParameter afterCount4 = new ObjectParameter("afterCount4", typeof(long));
            ObjectParameter leftCount = new ObjectParameter("leftCount", typeof(long));
            ObjectParameter registerMoneyCount = new ObjectParameter("registerMoneyCount", typeof(long));
            ObjectParameter boughtCount = new ObjectParameter("boughtCount", typeof(long));
            string empty1 = string.Empty;
            GameTradeMarketBuyInfo model = new GameTradeMarketBuyInfo();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("BuyItemProcess Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog("BuyItemProcess log DB Exception", "WARN");
                commonResult1.resultCode = 1;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult1);
            }
            string empty2 = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]BuyItemProcess({0}) - HttpRequest errorMsg : {1}", (object)empty2, (object)ex.ToString()), "ERROR");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            model = JsonConvert.DeserializeObject<GameTradeMarketBuyInfo>(end);
            if (model == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]BuyItemProcess({0}) - model is null", (object)end), "WARN");
                commonResult1.resultCode = 5;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)model);
            }
            if (ConstantMgr._serviceType.ToLower().Equals("dev").Equals(true))
            {
                bool result = false;
                commonResult1.resultCode = TradeModule.isOTPCheckItem(model.buyKeyType, model.buyMainKey, model.buyChooseKey, out result);
                if (commonResult1.resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}, {1}, {2}) otpitem check resultCode : {3}", (object)model.buyKeyType, (object)model.buyMainKey, (object)model.buyChooseKey, (object)commonResult1.resultCode), "WARN");
                    commonResult1.resultCode = 14;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_PRICE_WORNG");
                }
                if (result)
                    result = CommonModule.CheckLastOtpTime(new CheckOtpParamModel()
                    {
                        userNo = model.userNo,
                        worldNo = model.worldNo,
                        nationCode = model.nationCode
                    }) & result;
                if (result)
                {
                    CommonResult commonResult2 = CommonModule.Otpauth(new OtpAuthModel()
                    {
                        userNo = model.userNo,
                        worldNo = model.worldNo,
                        nationCode = model.nationCode,
                        otpKey = model.otp
                    });
                    if (commonResult2.resultCode.Equals(0).Equals(false))
                    {
                        switch (commonResult2.resultCode)
                        {
                            case -20001:
                                commonResult1.resultCode = 28;
                                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_BACKUPCODE_ALREADY_USE");
                                break;
                            case -1003:
                                commonResult1.resultCode = 27;
                                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_MAXFAIL_OTP");
                                break;
                            case -1002:
                                commonResult1.resultCode = 25;
                                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_UNUSE_OTP");
                                break;
                            default:
                                commonResult1.resultCode = 26;
                                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_NOTMATCH_OTP");
                                break;
                        }
                        return this.Json((object)commonResult1);
                    }
                }
            }
            long unitPrice = VariedPriceInfoManager.This().getUnitPrice(model.buyPrice);
            long num1 = model.buyPrice % unitPrice;
            if (num1 != 0L)
            {
                LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) buyPrice Check Fail unitPrice({1} divide Result {2}", (object)end, (object)unitPrice, (object)num1), "WARN");
                commonResult1.resultCode = 14;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_PRICE_WORNG");
                return this.Json((object)commonResult1);
            }
            TradeMarketItemInfo info1 = ItemInfoManager.This().getInfo(model.buyMainKey, model.buyChooseKey);
            if (!info1.isValid())
            {
                LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", (object)end, (object)model.buyMainKey, (object)model.buyChooseKey), "WARN");
                commonResult1.resultCode = 8;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                return this.Json((object)commonResult1);
            }
            if (info1._maxRegisterForWorldMarket < model.buyCount)
            {
                LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) buyCount({1}) Process Count Over", (object)end, (object)model.buyCount), "WARN");
                commonResult1.resultCode = 20;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ItemCountOver");
                return this.Json((object)commonResult1);
            }
            int enchantMaxGroup1 = ItemInfoManager.This().getEnchantMaxGroup(model.buyMainKey, info1._enchantGroup);
            if (info1._enchantGroup > model.buyChooseKey || model.buyChooseKey > enchantMaxGroup1)
            {
                LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) getEnchantMaxGroup({1}, {2}) Group : Out Of Range", (object)end, (object)model.buyMainKey, (object)info1._enchantGroup), "WARN");
                commonResult1.resultCode = 9;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup");
                return this.Json((object)commonResult1);
            }
            int enchantMaterialKey = info1._enchantMaterialKey;
            if (model.buyChooseKey == 0 && enchantMaxGroup1 != 0)
            {
                TradeMarketItemInfo info2 = ItemInfoManager.This().getInfo(model.buyMainKey, 1);
                if (!info2.isValid())
                {
                    LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", (object)end, (object)model.buyMainKey, (object)model.buyChooseKey), "WARN");
                    commonResult1.resultCode = 8;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                    return this.Json((object)commonResult1);
                }
                enchantMaterialKey = info2._enchantMaterialKey;
            }
            TradeMarketItemInfo tradeMarketItemInfo = new TradeMarketItemInfo();
            if (enchantMaterialKey != 0)
            {
                tradeMarketItemInfo = ItemInfoManager.This().getInfo(enchantMaterialKey, 0);
                if (!info1.isValid())
                {
                    LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) itemInfo({1}, 0) Not Exist Material ItemInfo", (object)end, (object)enchantMaterialKey), "WARN");
                    commonResult1.resultCode = 8;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                    return this.Json((object)commonResult1);
                }
            }
            if (model.buySubKey != model.buyChooseKey)
            {
                TradeMarketItemInfo info3 = ItemInfoManager.This().getInfo(model.buyMainKey, model.buySubKey);
                if (!info3.isValid())
                {
                    LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) baseitemInfo({1}, {2}) Not Exist ItemInfo", (object)end, (object)model.buyMainKey, (object)model.buySubKey), "WARN");
                    commonResult1.resultCode = 8;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                    return this.Json((object)commonResult1);
                }
                int enchantMaxGroup2 = ItemInfoManager.This().getEnchantMaxGroup(model.buyMainKey, info3._enchantGroup);
                if (info3._enchantGroup > model.buyChooseKey || model.buyChooseKey > enchantMaxGroup2)
                {
                    LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) getEnchantBaseMaxGroup({1}, {2}) Group : Out Of Range", (object)end, (object)model.buyMainKey, (object)info3._enchantGroup), "WARN");
                    commonResult1.resultCode = 9;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup");
                    return this.Json((object)commonResult1);
                }
            }
            long buyCount = model.buyCount;
            long num2 = 0;
            long num3 = 0;
            int num4 = 0;
            DateTime customTime = CommonModule.GetCustomTime();
            CommonModel.TradeMarketUserLogInfo userInfo = new CommonModel.TradeMarketUserLogInfo();
            userInfo.nationCode = model.nationCode;
            userInfo.serverNo = model.worldNo;
            userInfo.userNo = model.userNo;
            CommonModel.TradeMarketItemLogInfo itemInfo = new CommonModel.TradeMarketItemLogInfo();
            itemInfo.keyType1 = model.buyKeyType;
            itemInfo.itemKey1 = model.buyMainKey;
            itemInfo.enchantLevel1 = model.buySubKey;
            itemInfo.keyType2 = 0;
            itemInfo.itemKey2 = 1;
            itemInfo.enchantLevel2 = 0;
            List<string> sellUserIdList = new List<string>();
            using (TradeWebDB tradeWebDb = new TradeWebDB())
            {
                try
                {
                    ObjectParameter blocked = new ObjectParameter("blocked", typeof(bool));
                    tradeWebDb.uspCheckAndUpdateBlackUser(new int?(model.nationCode), new int?(model.worldNo), new long?(model.userNo), blocked, symNo, rv);
                    if (Convert.ToBoolean(blocked.Value))
                    {
                        LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspCheckAndUpdateBlackUser({0}/{1})", (object)end, (object)buyCount), "WARN");
                        commonResult1.resultCode = 24;
                        commonResult1.resultMsg = Convert.ToString(symNo.Value);
                        return this.Json((object)commonResult1);
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspCheckAndUpdateBlackUser({0}/{1}) Exception : {2}", (object)end, (object)buyCount, (object)ex.ToString()), "ERROR");
                    commonResult1.resultCode = 1;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)commonResult1);
                }
                int num5 = 0;
                bool flag1 = false;
                while (0L < buyCount)
                {
                    try
                    {
                        tradeWebDb.uspBuyBiddingFromWorldMarket(new int?(model.nationCode), new int?(model.worldNo), new long?(model.userNo), new int?(model.buyKeyType), new int?(model.buyMainKey), new int?(model.buySubKey), new long?(model.buyPrice), new long?(buyCount), new int?(model.buyChooseKey), new int?(tradeMarketItemInfo._mainKey), new long?(info1._enchantNeedCount), new double?(WorldMarketOptionManager.This().BiddingRatio), new long?(info1._weight), new long?(WorldMarketOptionManager.This().getMaxWeight() * (long)WorldMarketOptionManager.This().getMaxWeightRate()), new long?(num5 == 0 ? model.retryBiddingNo : 0L), walletMoney, realBuyCount, totalMoneyCount, sellNo, sellUserNo, sellUserId, sellLeftCount, raceCount, stopType, beforeCount1, afterCount1, beforeCount2, afterCount2, beforeCount3, afterCount3, beforeCount4, afterCount4, leftCount, registerMoneyCount, boughtCount, symNo, rv);
                        commonResult1.resultCode = Convert.ToInt32(rv.Value);
                        long int64_1 = Convert.ToInt64(sellUserNo.Value);
                        string textParam1 = Convert.ToString(sellUserId.Value);
                        StopReasonType int32 = (StopReasonType)Convert.ToInt32(stopType.Value);
                        if (commonResult1.resultCode == 0)
                        {
                            if (StopReasonType.eStopReasonType_Empty != int32)
                            {
                                if (StopReasonType.eStopReasonType_Fail == int32)
                                {
                                    if (5 == num4)
                                    {
                                        LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}/{1}) Fail BuyBidding", (object)end, (object)buyCount), "WARN");
                                        commonResult1.resultCode = 11;
                                        commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_BuyBiddingRepeatOverFail");
                                        return this.Json((object)commonResult1);
                                    }
                                    ++num4;
                                }
                                else if (int32 == StopReasonType.eStopReasonType_Normal)
                                {
                                    long int64_2 = Convert.ToInt64(realBuyCount.Value);
                                    long int64_3 = Convert.ToInt64(totalMoneyCount.Value);
                                    long int64_4 = Convert.ToInt64(sellNo.Value);
                                    Convert.ToInt64(walletMoney.Value);
                                    buyCount -= int64_2;
                                    num2 += int64_2;
                                    num3 += int64_3;
                                    if (num5 == 0 && 0L < model.retryBiddingNo)
                                    {
                                        long int64_5 = Convert.ToInt64(boughtCount.Value);
                                        long int64_6 = Convert.ToInt64(beforeCount1.Value);
                                        long int64_7 = Convert.ToInt64(afterCount1.Value);
                                        Convert.ToInt64(leftCount.Value);
                                        long int64_8 = Convert.ToInt64(registerMoneyCount.Value);
                                        long int64_9 = Convert.ToInt64(beforeCount2.Value);
                                        long int64_10 = Convert.ToInt64(afterCount2.Value);
                                        if (0L < Convert.ToInt64(boughtCount.Value))
                                        {
                                            itemInfo.count1 = int64_5;
                                            itemInfo.beforeCount1 = int64_6;
                                            itemInfo.afterCount1 = int64_7;
                                            itemInfo.count2 = 0L;
                                            itemInfo.beforeCount2 = 0L;
                                            itemInfo.afterCount2 = 0L;
                                            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingBuyCalculate, CommonModule.GetCustomTime(), userInfo, itemInfo, model.retryBiddingNo, 1L, (long)model.buyChooseKey, Convert.ToInt64(model.isWebAccess));
                                        }
                                        if (0L < int64_8)
                                        {
                                            itemInfo.count1 = Convert.ToInt64(leftCount.Value);
                                            itemInfo.beforeCount1 = 0L;
                                            itemInfo.afterCount1 = 0L;
                                            itemInfo.count2 = int64_8;
                                            itemInfo.beforeCount2 = int64_9;
                                            itemInfo.afterCount2 = int64_10;
                                            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingBuyWithdraw, CommonModule.GetCustomTime(), userInfo, itemInfo, model.retryBiddingNo, 1L, param4: Convert.ToInt64(model.isWebAccess));
                                        }
                                        flag1 = true;
                                    }
                                    itemInfo.count1 = int64_2;
                                    itemInfo.beforeCount1 = Convert.ToInt64(beforeCount4.Value);
                                    itemInfo.afterCount1 = Convert.ToInt64(afterCount4.Value);
                                    itemInfo.count2 = int64_3;
                                    itemInfo.beforeCount2 = Convert.ToInt64(beforeCount3.Value);
                                    itemInfo.afterCount2 = Convert.ToInt64(afterCount3.Value);
                                    WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BuyBidding, customTime, userInfo, itemInfo, int64_4, Convert.ToInt64(model.isWebAccess), (long)model.buyChooseKey, int64_1, Convert.ToInt64(raceCount.Value), model.retryBiddingNo, textParam1: textParam1);
                                    ++num5;
                                    if (Convert.ToInt64(sellLeftCount.Value) == 0L)
                                    {
                                        string str = sellUserId.Value.ToString();
                                        if (!sellUserIdList.Contains(str))
                                            sellUserIdList.Add(str);
                                    }
                                }
                                else
                                {
                                    LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}/{1}) StopReasonType({2}) is Invalid", (object)end, (object)buyCount, (object)(int)int32), "WARN");
                                    commonResult1.resultCode = 10;
                                    commonResult1.resultMsg = Convert.ToString(symNo.Value);
                                    return this.Json((object)commonResult1);
                                }
                            }
                            else
                                break;
                        }
                        else
                        {
                            LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}/{1}), rv({2})", (object)end, (object)buyCount, (object)commonResult1.resultCode), "WARN");
                            commonResult1.resultMsg = Convert.ToString(symNo.Value);
                            return this.Json((object)commonResult1);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspBuyBiddingFromWorldMarket({0}/{1}) Exception : {2}", (object)end, (object)buyCount, (object)ex.ToString()), "ERROR");
                        commonResult1.resultCode = 1;
                        commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                        return this.Json((object)commonResult1);
                    }
                }
                if (!flag1 && 0L < model.retryBiddingNo)
                {
                    long int64_11 = Convert.ToInt64(boughtCount.Value);
                    long int64_12 = Convert.ToInt64(beforeCount1.Value);
                    long int64_13 = Convert.ToInt64(afterCount1.Value);
                    Convert.ToInt64(leftCount.Value);
                    long int64_14 = Convert.ToInt64(registerMoneyCount.Value);
                    long int64_15 = Convert.ToInt64(beforeCount2.Value);
                    long int64_16 = Convert.ToInt64(afterCount2.Value);
                    if (0L < Convert.ToInt64(boughtCount.Value))
                    {
                        itemInfo.count1 = int64_11;
                        itemInfo.beforeCount1 = int64_12;
                        itemInfo.afterCount1 = int64_13;
                        itemInfo.count2 = 0L;
                        itemInfo.beforeCount2 = 0L;
                        itemInfo.afterCount2 = 0L;
                        WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingBuyCalculate, CommonModule.GetCustomTime(), userInfo, itemInfo, model.retryBiddingNo, 1L, (long)model.buyChooseKey, Convert.ToInt64(model.isWebAccess));
                    }
                    if (0L < int64_14)
                    {
                        itemInfo.count1 = Convert.ToInt64(leftCount.Value);
                        itemInfo.beforeCount1 = 0L;
                        itemInfo.afterCount1 = 0L;
                        itemInfo.count2 = int64_14;
                        itemInfo.beforeCount2 = int64_15;
                        itemInfo.afterCount2 = int64_16;
                        WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingBuyWithdraw, CommonModule.GetCustomTime(), userInfo, itemInfo, model.retryBiddingNo, 1L, param4: Convert.ToInt64(model.isWebAccess));
                    }
                }
                if (buyCount == 0L)
                {
                    commonResult1.resultMsg = Convert.ToString(model.buyMainKey) + "-" + Convert.ToString(model.buyChooseKey) + "-" + Convert.ToString(model.buyCount) + "-" + Convert.ToString(model.buyPrice) + "-" + Convert.ToString(num2) + "-" + Convert.ToString(num3) + "-" + Convert.ToString(0) + "-" + Convert.ToString(0) + "-" + Convert.ToString(model.retryBiddingNo);
                    Task.Run((Action)(() => TradeModule.SendPearlAppAlarm(ref sellUserIdList, model.buyMainKey, "SELL")));
                    return this.Json((object)commonResult1);
                }
                bool flag2 = false;
                if (ConstantMgr._serviceProject.Equals("BDO") && info1._mainGroupNo == WorldMarketOptionManager.This().getCashGroupNo())
                    flag2 = true;
                try
                {
                    tradeWebDb.uspBuyFromWorldMarket(new int?(model.nationCode), new int?(model.worldNo), new long?(model.userNo), new int?(model.buyKeyType), new int?(model.buyMainKey), new int?(model.buySubKey), new long?(model.buyPrice), new long?(buyCount), new int?(model.buyChooseKey), new int?(tradeMarketItemInfo._mainKey), new long?(info1._enchantNeedCount), new double?(WorldMarketOptionManager.This().BiddingRatio), new bool?(flag2), new long?(info1._weight), new long?(WorldMarketOptionManager.This().getMaxWeight() * (long)WorldMarketOptionManager.This().getMaxWeightRate()), realBuyCount, totalMoneyCount, buyNo, biddingMoneyCount, beforeCount1, afterCount1, beforeCount2, afterCount2, symNo, rv);
                    commonResult1.resultCode = Convert.ToInt32(rv.Value);
                    if (commonResult1.resultCode == 0)
                    {
                        long int64_17 = Convert.ToInt64(realBuyCount.Value);
                        long int64_18 = Convert.ToInt64(totalMoneyCount.Value);
                        long int64_19 = Convert.ToInt64(biddingMoneyCount.Value);
                        long int64_20 = Convert.ToInt64(buyNo.Value);
                        long num6 = num2 + int64_17;
                        long num7 = num3 + int64_18;
                        if (num6 == 0L && int64_20 == 0L)
                        {
                            LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) ReserveBiddingFail", (object)end), "WARN");
                            commonResult1.resultCode = 22;
                            commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ReserveBuyBiddingFail");
                            return this.Json((object)commonResult1);
                        }
                        commonResult1.resultMsg = Convert.ToString(model.buyMainKey) + "-" + Convert.ToString(model.buyChooseKey) + "-" + Convert.ToString(model.buyCount) + "-" + Convert.ToString(model.buyPrice) + "-" + Convert.ToString(num6) + "-" + Convert.ToString(num7) + "-" + Convert.ToString(int64_19) + "-" + Convert.ToString(int64_20) + "-" + Convert.ToString(model.retryBiddingNo);
                        long num8 = int64_18 - int64_19;
                        if (0L < int64_17)
                        {
                            itemInfo.count1 = int64_17;
                            itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1.Value);
                            itemInfo.afterCount1 = Convert.ToInt64(afterCount1.Value);
                            itemInfo.count2 = num8;
                            itemInfo.beforeCount2 = Convert.ToInt64(beforeCount2.Value);
                            itemInfo.afterCount2 = Convert.ToInt64(afterCount2.Value);
                            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_Buy, customTime, userInfo, itemInfo, (long)model.buyChooseKey, Convert.ToInt64(model.isWebAccess), model.retryBiddingNo);
                        }
                        if (int64_20 != 0L)
                        {
                            itemInfo.count1 = buyCount - int64_17;
                            itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1.Value);
                            itemInfo.afterCount1 = Convert.ToInt64(afterCount1.Value);
                            itemInfo.count2 = int64_19;
                            itemInfo.beforeCount2 = Convert.ToInt64(beforeCount2.Value);
                            itemInfo.afterCount2 = Convert.ToInt64(afterCount2.Value);
                            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingBuyRegister, customTime, userInfo, itemInfo, int64_20, Convert.ToInt64(model.isWebAccess), model.retryBiddingNo);
                        }
                        Task.Run((Action)(() => TradeModule.SendPearlAppAlarm(ref sellUserIdList, model.buyMainKey, "SELL")));
                        return this.Json((object)commonResult1);
                    }
                    if (0L < num2)
                    {
                        commonResult1.resultCode = 0;
                        commonResult1.resultMsg = Convert.ToString(model.buyMainKey) + "-" + Convert.ToString(model.buyChooseKey) + "-" + Convert.ToString(model.buyCount) + "-" + Convert.ToString(model.buyPrice) + "-" + Convert.ToString(num2) + "-" + Convert.ToString(num3) + "-" + Convert.ToString(0) + "-" + Convert.ToString(0) + "-" + Convert.ToString(model.retryBiddingNo);
                        Task.Run((Action)(() => TradeModule.SendPearlAppAlarm(ref sellUserIdList, model.buyMainKey, "SELL")));
                        return this.Json((object)commonResult1);
                    }
                    LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyFromWorldMarket({0}/{1}), rv({2})", (object)end, (object)buyCount, (object)commonResult1.resultCode), "WARN");
                    commonResult1.resultMsg = Convert.ToString(symNo.Value);
                    Task.Run((Action)(() => TradeModule.SendPearlAppAlarm(ref sellUserIdList, model.buyMainKey, "SELL")));
                    return this.Json((object)commonResult1);
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspBuyFromWorldMarket({0}/{1}) Exception : {2}", (object)end, (object)buyCount, (object)ex.ToString()), "ERROR");
                    commonResult1.resultCode = 1;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)commonResult1);
                }
            }
        }

        private void BuyItemSystemProcess(
          int buyKeyType,
          int buyMainKey,
          int buySubKey,
          long buyCount)
        {
            if (!ServerControlManager.This().IsLoadComplete())
                LogUtil.WriteLog(string.Format("BuyItemSystemProcess Fail is Not Open"), "WARN");
            else if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog(string.Format("BuyItemSystemProcess log DB Exception"), "WARN");
            }
            else
            {
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                ObjectParameter realBuyCount = new ObjectParameter("realBuyCount", typeof(long));
                ObjectParameter totalMoneyCount = new ObjectParameter("totalMoneyCount", typeof(long));
                ObjectParameter sellNo = new ObjectParameter("sellNo", typeof(long));
                ObjectParameter buyNo = new ObjectParameter("buyNo", typeof(long));
                ObjectParameter stopType = new ObjectParameter("stopType", typeof(int));
                CommonModel.TradeMarketUserLogInfo userInfo = new CommonModel.TradeMarketUserLogInfo();
                TradeMarketItemInfo info = ItemInfoManager.This().getInfo(buyMainKey, buySubKey);
                if (!info.isValid())
                {
                    LogUtil.WriteLog(string.Format("[Item Error]BuyItemSystemProcess() itemInfo({0}, {0}) Not Exist ItemInfo", (object)buyMainKey, (object)buySubKey), "WARN");
                }
                else
                {
                    TradeMarketItemInfo tradeMarketItemInfo = new TradeMarketItemInfo();
                    if (info._enchantMaterialKey != 0)
                    {
                        tradeMarketItemInfo = ItemInfoManager.This().getInfo(info._enchantMaterialKey, 0);
                        if (!info.isValid())
                        {
                            LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess() itemInfo({0}, {1}) Not Exist Material ItemInfo", (object)info._enchantMaterialKey, (object)0), "WARN");
                            return;
                        }
                    }
                    long num1 = buyCount;
                    long num2 = 0;
                    long num3 = 0;
                    int num4 = 0;
                    DateTime customTime = CommonModule.GetCustomTime();
                    using (TradeWebDB tradeWebDb = new TradeWebDB())
                    {
                        while (0L < num1)
                        {
                            try
                            {
                                tradeWebDb.uspBuyBiddingFromWorldMarketBySystem(new int?(buyKeyType), new int?(buyMainKey), new int?(buySubKey), new long?(num1), new int?(buySubKey), new int?(tradeMarketItemInfo._mainKey), new long?(info._enchantNeedCount), new double?(WorldMarketOptionManager.This().BiddingRatio), realBuyCount, totalMoneyCount, sellNo, stopType, symNo, rv);
                                int int32_1 = Convert.ToInt32(rv.Value);
                                StopReasonType int32_2 = (StopReasonType)Convert.ToInt32(stopType.Value);
                                if (int32_1 == 0)
                                {
                                    if (StopReasonType.eStopReasonType_Empty != int32_2)
                                    {
                                        if (StopReasonType.eStopReasonType_Fail == int32_2)
                                        {
                                            if (5 == num4)
                                            {
                                                LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}) Fail BuyBidding", (object)num1), "WARN");
                                                return;
                                            }
                                            ++num4;
                                        }
                                        else if (int32_2 == StopReasonType.eStopReasonType_Normal)
                                        {
                                            num1 -= Convert.ToInt64(realBuyCount.Value);
                                            num2 += Convert.ToInt64(realBuyCount.Value);
                                            num3 += Convert.ToInt64(totalMoneyCount.Value);
                                            long int64 = Convert.ToInt64(sellNo.Value);
                                            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BuyBiddingSystem, customTime, userInfo, new CommonModel.TradeMarketItemLogInfo()
                                            {
                                                keyType1 = buyKeyType,
                                                itemKey1 = buyMainKey,
                                                enchantLevel1 = buySubKey,
                                                count1 = Convert.ToInt64(realBuyCount.Value),
                                                keyType2 = 0,
                                                itemKey2 = 1,
                                                enchantLevel2 = 0,
                                                count2 = Convert.ToInt64(totalMoneyCount.Value)
                                            }, int64);
                                        }
                                        else
                                        {
                                            LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}) StopReasonType({1}) is Invalid", (object)num1, (object)(int)int32_2), "WARN");
                                            return;
                                        }
                                    }
                                    else
                                        break;
                                }
                                else
                                {
                                    LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}), rv({1})", (object)num1, (object)int32_1), "WARN");
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspBuyBiddingFromWorldMarket({0}) Exception : {1}", (object)num1, (object)ex.ToString()), "ERROR");
                                return;
                            }
                        }
                        if (num1 == 0L)
                            return;
                        try
                        {
                            tradeWebDb.uspBuyFromWorldMarketBySystem(new int?(buyKeyType), new int?(buyMainKey), new int?(buySubKey), new long?(num1), new int?(buySubKey), new int?(tradeMarketItemInfo._mainKey), new long?(info._enchantNeedCount), new double?(WorldMarketOptionManager.This().BiddingRatio), realBuyCount, totalMoneyCount, buyNo, symNo, rv);
                            int int32 = Convert.ToInt32(rv.Value);
                            if (int32 == 0)
                            {
                                if (0L >= num2 + Convert.ToInt64(realBuyCount.Value))
                                    return;
                                WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BuySystem, customTime, userInfo, new CommonModel.TradeMarketItemLogInfo()
                                {
                                    keyType1 = buyKeyType,
                                    itemKey1 = buyMainKey,
                                    enchantLevel1 = buySubKey,
                                    count1 = Convert.ToInt64(realBuyCount.Value),
                                    keyType2 = 0,
                                    itemKey2 = 1,
                                    enchantLevel2 = 0,
                                    count2 = 0L
                                }, (long)buySubKey);
                            }
                            else
                            {
                                if (0L < num2)
                                    return;
                                LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyFromWorldMarket({0}), rv({1})", (object)num1, (object)int32), "WARN");
                            }
                        }
                        catch (Exception ex)
                        {
                            LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspBuyFromWorldMarket({0}) Exception : {1}", (object)num1, (object)ex.ToString()), "ERROR");
                        }
                    }
                }
            }
        }

        [HttpPost]
        public JsonResult SellItemProcess()
        {
            CommonResult commonResult1 = new CommonResult();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter walletMoney = new ObjectParameter("walletMoney", typeof(long));
            ObjectParameter realSellCount = new ObjectParameter("realSellCount", typeof(long));
            ObjectParameter totalMoneyCount = new ObjectParameter("totalMoneyCount", typeof(long));
            ObjectParameter originalTotalMoneyCount = new ObjectParameter("originalTotalMoneyCount", typeof(long));
            ObjectParameter sellPricePerOne = new ObjectParameter("sellPricePerOne", typeof(long));
            ObjectParameter packageExpiration = new ObjectParameter("packageExpiration", typeof(DateTime));
            ObjectParameter sellNo = new ObjectParameter("sellNo", typeof(long));
            ObjectParameter buyUserNo = new ObjectParameter("buyUserNo", typeof(long));
            ObjectParameter buyUserId = new ObjectParameter("buyUserId", typeof(string));
            ObjectParameter buyLeftCount = new ObjectParameter("buyLeftCount", typeof(long));
            ObjectParameter buyNo = new ObjectParameter("buyNo", typeof(long));
            ObjectParameter stopType = new ObjectParameter("stopType", typeof(int));
            ObjectParameter isNextApplyRingBuff = new ObjectParameter("isNextApplyRingBuff", typeof(bool));
            ObjectParameter resultWaitNo = new ObjectParameter("resultWaitNo", typeof(long));
            ObjectParameter raceCount = new ObjectParameter("raceCount", typeof(long));
            ObjectParameter beforeCount1 = new ObjectParameter("beforeCount1", typeof(long));
            ObjectParameter beforeCount2 = new ObjectParameter("beforeCount2", typeof(long));
            ObjectParameter beforeCount3 = new ObjectParameter("beforeCount3", typeof(long));
            ObjectParameter beforeCount4 = new ObjectParameter("beforeCount4", typeof(long));
            ObjectParameter afterCount1 = new ObjectParameter("afterCount1", typeof(long));
            ObjectParameter afterCount2 = new ObjectParameter("afterCount2", typeof(long));
            ObjectParameter afterCount3 = new ObjectParameter("afterCount3", typeof(long));
            ObjectParameter afterCount4 = new ObjectParameter("afterCount4", typeof(long));
            ObjectParameter soldCount = new ObjectParameter("soldCount", typeof(long));
            ObjectParameter leftCount = new ObjectParameter("leftCount", typeof(long));
            ObjectParameter moneyCount = new ObjectParameter("moneyCount", typeof(long));
            ObjectParameter calculateMoney = new ObjectParameter("calculateMoney", typeof(long));
            ObjectParameter isCalculateRingBuff = new ObjectParameter("isCalculateRingBuff", typeof(bool));
            byte num1 = 2;
            long num2 = 0;
            GameTradeMarketSellInfo model = new GameTradeMarketSellInfo();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("SellItemProcess Fail is Not Open", "WARN");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog("SellItemProcess log DB Exception", "WARN");
                commonResult1.resultCode = 1;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult1);
            }
            string empty = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]SellItemProcess({0}) - HttpRequest errorMsg : {1}", (object)empty, (object)ex.ToString()), "ERROR");
                commonResult1.resultCode = 2;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult1);
            }
            model = JsonConvert.DeserializeObject<GameTradeMarketSellInfo>(end);
            if (model == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]SellItemProcess({0}) - model is null", (object)end), "WARN");
                commonResult1.resultCode = 5;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)model);
            }
            if (ConstantMgr._serviceType.ToLower().Equals("dev").Equals(true))
            {
                bool result = false;
                commonResult1.resultCode = TradeModule.isOTPCheckItem(model.sellKeyType, model.sellMainKey, model.sellChooseKey, out result);
                if (commonResult1.resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}, {1}, {2}) otpitem check resultCode : {3}", (object)model.sellKeyType, (object)model.sellMainKey, (object)model.sellChooseKey, (object)commonResult1.resultCode), "WARN");
                    commonResult1.resultCode = 14;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_PRICE_WORNG");
                }
                if (result)
                    result = CommonModule.CheckLastOtpTime(new CheckOtpParamModel()
                    {
                        userNo = model.userNo,
                        worldNo = model.worldNo,
                        nationCode = model.nationCode
                    }) & result;
                if (result)
                {
                    CommonResult commonResult2 = CommonModule.Otpauth(new OtpAuthModel()
                    {
                        userNo = model.userNo,
                        worldNo = model.worldNo,
                        nationCode = model.nationCode,
                        otpKey = model.otp
                    });
                    if (commonResult2.resultCode.Equals(0).Equals(false))
                    {
                        switch (commonResult2.resultCode)
                        {
                            case -20001:
                                commonResult1.resultCode = 28;
                                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_BACKUPCODE_ALREADY_USE");
                                break;
                            case -1003:
                                commonResult1.resultCode = 27;
                                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_MAXFAIL_OTP");
                                break;
                            case -1002:
                                commonResult1.resultCode = 25;
                                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_UNUSE_OTP");
                                break;
                            default:
                                commonResult1.resultCode = 26;
                                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_NOTMATCH_OTP");
                                break;
                        }
                        return this.Json((object)commonResult1);
                    }
                }
            }
            long unitPrice = VariedPriceInfoManager.This().getUnitPrice(model.sellPrice);
            long num3 = model.sellPrice % unitPrice;
            if (num3 != 0L)
            {
                LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) sellPrice Check Fail unitPrice({1} divide Result {2}", (object)end, (object)unitPrice, (object)num3), "WARN");
                commonResult1.resultCode = 14;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_PRICE_WORNG");
                return this.Json((object)commonResult1);
            }
            TradeMarketItemInfo info1 = ItemInfoManager.This().getInfo(model.sellMainKey, model.sellChooseKey);
            if (!info1.isValid())
            {
                LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", (object)end, (object)model.sellMainKey, (object)model.sellChooseKey), "WARN");
                commonResult1.resultCode = 8;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                return this.Json((object)commonResult1);
            }
            long num4 = info1._maxRegisterForWorldMarket * 10L;
            if (ConstantMgr._serviceProject.Equals("BDO") && info1._mainGroupNo == WorldMarketOptionManager.This().getCashGroupNo())
                num4 = 100L;
            if (num4 < model.sellCount)
            {
                LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) sellCount({1}) Process Count Over", (object)end, (object)model.sellCount), "WARN");
                commonResult1.resultCode = 20;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ItemCountOver");
                return this.Json((object)commonResult1);
            }
            TradeMarketItemInfo tradeMarketItemInfo = new TradeMarketItemInfo();
            if (info1._enchantMaterialKey != 0)
            {
                tradeMarketItemInfo = ItemInfoManager.This().getInfo(info1._enchantMaterialKey, 0);
                if (!info1.isValid())
                {
                    LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) itemInfo({1}, 0) Not Exist Material ItemInfo", (object)end, (object)info1._enchantMaterialKey), "WARN");
                    commonResult1.resultCode = 8;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                    return this.Json((object)commonResult1);
                }
            }
            int enchantMaxGroup1 = ItemInfoManager.This().getEnchantMaxGroup(model.sellMainKey, info1._enchantGroup);
            if (info1._enchantGroup > model.sellChooseKey || model.sellChooseKey > enchantMaxGroup1)
            {
                LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) getEnchantMaxGroup({1}, {2}) Group : Out Of Range", (object)end, (object)model.sellMainKey, (object)info1._enchantGroup), "WARN");
                commonResult1.resultCode = 9;
                commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup");
                return this.Json((object)commonResult1);
            }
            if (model.sellSubKey != model.sellChooseKey)
            {
                TradeMarketItemInfo info2 = ItemInfoManager.This().getInfo(model.sellMainKey, model.sellSubKey);
                if (!info2.isValid())
                {
                    LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) baseitemInfo({1}, {2}) Not Exist ItemInfo", (object)end, (object)model.sellMainKey, (object)model.sellSubKey), "WARN");
                    commonResult1.resultCode = 8;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                    return this.Json((object)commonResult1);
                }
                int enchantMaxGroup2 = ItemInfoManager.This().getEnchantMaxGroup(model.sellMainKey, info2._enchantGroup);
                if (info2._enchantGroup > model.sellChooseKey || model.sellChooseKey > enchantMaxGroup2)
                {
                    LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) getEnchantBaseMaxGroup({1}, {2}) Group : Out Of Range", (object)end, (object)model.sellMainKey, (object)info2._enchantGroup), "WARN");
                    commonResult1.resultCode = 9;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup");
                    return this.Json((object)commonResult1);
                }
            }
            CommonModel.TradeMarketUserLogInfo userInfo = new CommonModel.TradeMarketUserLogInfo();
            userInfo.nationCode = model.nationCode;
            userInfo.serverNo = model.worldNo;
            userInfo.userNo = model.userNo;
            CommonModel.TradeMarketItemLogInfo itemInfo = new CommonModel.TradeMarketItemLogInfo();
            itemInfo.keyType1 = model.sellKeyType;
            itemInfo.itemKey1 = model.sellMainKey;
            itemInfo.enchantLevel1 = model.sellSubKey;
            itemInfo.keyType2 = 0;
            itemInfo.itemKey2 = 1;
            itemInfo.enchantLevel2 = 0;
            long num5 = 0;
            List<string> buyUserIdList = new List<string>();
            using (TradeWebDB tradeWebDb = new TradeWebDB())
            {
                try
                {
                    ObjectParameter blocked = new ObjectParameter("blocked", typeof(bool));
                    tradeWebDb.uspCheckAndUpdateBlackUser(new int?(model.nationCode), new int?(model.worldNo), new long?(model.userNo), blocked, symNo, rv);
                    if (Convert.ToBoolean(blocked.Value))
                    {
                        LogUtil.WriteLog(string.Format("[DB Exception]SellItemProcess() - uspCheckAndUpdateBlackUser({0}) Exception ", (object)end), "WARN");
                        commonResult1.resultCode = 24;
                        commonResult1.resultMsg = Convert.ToString(symNo.Value);
                        return this.Json((object)commonResult1);
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception]SellItemProcess() - uspCheckAndUpdateBlackUser({0}) Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                    commonResult1.resultCode = 1;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)commonResult1);
                }
                long sellCount = model.sellCount;
                long num6 = 0;
                long num7 = 0;
                DateTime customTime = CommonModule.GetCustomTime();
                int num8 = 0;
                bool flag1 = false;
                if (ConstantMgr._serviceProject.Equals("BDO") && info1._mainGroupNo == WorldMarketOptionManager.This().getCashGroupNo())
                    flag1 = true;
                if (ConstantMgr._serviceProject.Equals("BDO") && model.isRingBuff && info1._mainGroupNo != WorldMarketOptionManager.This().getCashGroupNo())
                    num1 = (byte)0;
                int num9 = 0;
                bool flag2 = false;
                while (0L < sellCount)
                {
                    try
                    {
                        tradeWebDb.uspSellBiddingToWorldMarket(new int?(model.nationCode), new int?(model.worldNo), new long?(model.userNo), new int?(model.sellKeyType), new int?(model.sellMainKey), new int?(model.sellSubKey), new int?(info1._mainGroupNo), new bool?(model.isSealed), new long?(model.sellPrice), new long?(sellCount), new int?(model.sellChooseKey), new int?(tradeMarketItemInfo._mainKey), new long?(info1._enchantNeedCount), new double?(WorldMarketOptionManager.This().BiddingRatio), new bool?(flag1), new long?(info1._weight), new long?(WorldMarketOptionManager.This().getMaxWeight() * (long)WorldMarketOptionManager.This().getMaxWeightRate()), new long?((long)WorldMarketOptionManager.This().getPearlItemLimitedMaxCount()), new DateTime?(customTime), new byte?(num1), new long?(num2), new bool?(model.isRingBuff), new long?(num9 == 0 ? model.retryBiddingNo : 0L), walletMoney, realSellCount, totalMoneyCount, originalTotalMoneyCount, packageExpiration, buyNo, buyUserNo, buyUserId, buyLeftCount, stopType, isNextApplyRingBuff, resultWaitNo, raceCount, beforeCount1, afterCount1, beforeCount2, afterCount2, beforeCount3, afterCount3, beforeCount4, afterCount4, soldCount, leftCount, moneyCount, calculateMoney, isCalculateRingBuff, symNo, rv);
                        commonResult1.resultCode = Convert.ToInt32(rv.Value);
                        StopReasonType int32 = (StopReasonType)Convert.ToInt32(stopType.Value);
                        if (commonResult1.resultCode == 0)
                        {
                            if (StopReasonType.eStopReasonType_Empty != int32)
                            {
                                if (StopReasonType.eStopReasonType_Fail == int32)
                                {
                                    if (5 == num8)
                                    {
                                        LogUtil.WriteLog(string.Format("[DB Error]SellItemProcess - uspSellBiddingToWorldMarket({0}/{1}) Fail BuyBidding", (object)end, (object)sellCount), "WARN");
                                        commonResult1.resultCode = 13;
                                        commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_SellBiddingRepeatOverFail");
                                        return this.Json((object)commonResult1);
                                    }
                                    ++num8;
                                }
                                else if (int32 == StopReasonType.eStopReasonType_Normal)
                                {
                                    long int64_1 = Convert.ToInt64(realSellCount.Value);
                                    long int64_2 = Convert.ToInt64(totalMoneyCount.Value);
                                    long int64_3 = Convert.ToInt64(originalTotalMoneyCount.Value);
                                    long int64_4 = Convert.ToInt64(buyNo.Value);
                                    Convert.ToInt64(walletMoney.Value);
                                    if (num9 == 0 && Convert.ToBoolean(isNextApplyRingBuff.Value))
                                        num1 = (byte)1;
                                    sellCount -= int64_1;
                                    num6 += int64_1;
                                    num7 += int64_2;
                                    if (num9 == 0 && 0L < model.retryBiddingNo)
                                    {
                                        long int64_5 = Convert.ToInt64(leftCount.Value);
                                        long int64_6 = Convert.ToInt64(beforeCount2.Value);
                                        long int64_7 = Convert.ToInt64(afterCount2.Value);
                                        long int64_8 = Convert.ToInt64(soldCount.Value);
                                        num5 = Convert.ToInt64(calculateMoney.Value);
                                        long int64_9 = Convert.ToInt64(moneyCount.Value);
                                        long int64_10 = Convert.ToInt64(beforeCount1.Value);
                                        long int64_11 = Convert.ToInt64(afterCount1.Value);
                                        bool boolean = Convert.ToBoolean(isCalculateRingBuff.Value);
                                        if (0L < num5)
                                        {
                                            itemInfo.count1 = 0L;
                                            itemInfo.beforeCount1 = 0L;
                                            itemInfo.afterCount1 = 0L;
                                            itemInfo.count2 = num5;
                                            itemInfo.beforeCount2 = int64_10;
                                            itemInfo.afterCount2 = int64_11;
                                            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingSellCalculate, CommonModule.GetCustomTime(), userInfo, itemInfo, model.retryBiddingNo, 1L, num5, (long)Convert.ToInt32(model.isSealed), int64_9, Convert.ToInt64(model.isWebAccess), int64_8, Convert.ToInt64(boolean), textParam1: packageExpiration.Value.ToString());
                                        }
                                        if (0L < int64_5)
                                        {
                                            itemInfo.count1 = int64_5;
                                            itemInfo.beforeCount1 = int64_6;
                                            itemInfo.afterCount1 = int64_7;
                                            itemInfo.count2 = 0L;
                                            itemInfo.beforeCount2 = 0L;
                                            itemInfo.afterCount2 = 0L;
                                            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingSellWithdraw, customTime, userInfo, itemInfo, model.retryBiddingNo, 1L, (long)model.sellChooseKey, (long)Convert.ToInt32(model.isSealed), Convert.ToInt64(model.isWebAccess));
                                        }
                                        flag2 = true;
                                    }
                                    itemInfo.count1 = int64_1;
                                    itemInfo.beforeCount1 = Convert.ToInt64(beforeCount3.Value);
                                    itemInfo.afterCount1 = Convert.ToInt64(afterCount3.Value);
                                    itemInfo.count2 = int64_2;
                                    itemInfo.beforeCount2 = Convert.ToInt64(beforeCount4.Value);
                                    itemInfo.afterCount2 = Convert.ToInt64(afterCount4.Value);
                                    WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, 0L < Convert.ToInt64(resultWaitNo.Value) ? WorldMarketLog.ReasonType.eWorldMarket_ReasonType_SellWait : WorldMarketLog.ReasonType.eWorldMarket_ReasonType_SellBidding, customTime, userInfo, itemInfo, int64_4, (long)model.sellChooseKey, Convert.ToInt64(model.isSealed), int64_3, Convert.ToInt64(model.isWebAccess), Convert.ToInt64(num1), Convert.ToInt64(resultWaitNo.Value), Convert.ToInt64(buyUserNo.Value), Convert.ToInt64(raceCount.Value), Convert.ToInt64(model.isRingBuff), model.retryBiddingNo, textParam1: packageExpiration.Value.ToString());
                                    ++num9;
                                    if (0L < int64_4)
                                    {
                                        if (Convert.ToInt64(buyLeftCount.Value) == 0L)
                                        {
                                            string str = buyUserId.Value.ToString();
                                            if (!buyUserIdList.Contains(str))
                                                buyUserIdList.Add(str);
                                        }
                                    }
                                }
                                else
                                {
                                    LogUtil.WriteLog(string.Format("[DB Error]SellItemProcess - uspSellBiddingToWorldMarket({0}/{1}) StopReasonType({2}) is Invalid", (object)end, (object)sellCount, (object)(int)int32), "WARN");
                                    commonResult1.resultCode = 12;
                                    commonResult1.resultMsg = Convert.ToString(symNo.Value);
                                    return this.Json((object)commonResult1);
                                }
                            }
                            else
                                break;
                        }
                        else
                        {
                            LogUtil.WriteLog(string.Format("[DB Error]SellItemProcess - uspSellBiddingToWorldMarket({0}/{1}), rv({2})", (object)end, (object)sellCount, (object)commonResult1.resultCode), "WARN");
                            commonResult1.resultMsg = Convert.ToString(symNo.Value);
                            return this.Json((object)commonResult1);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog(string.Format("[DB Exception]SellItemProcess() - uspSellBiddingToWorldMarket({0}/{1}) Exception : {2}", (object)end, (object)sellCount, (object)ex.ToString()), "ERROR");
                        commonResult1.resultCode = 1;
                        commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                        return this.Json((object)commonResult1);
                    }
                }
                if (!flag2 && 0L < model.retryBiddingNo)
                {
                    long int64_12 = Convert.ToInt64(leftCount.Value);
                    long int64_13 = Convert.ToInt64(beforeCount2.Value);
                    long int64_14 = Convert.ToInt64(afterCount2.Value);
                    long int64_15 = Convert.ToInt64(soldCount.Value);
                    num5 = Convert.ToInt64(calculateMoney.Value);
                    long int64_16 = Convert.ToInt64(moneyCount.Value);
                    long int64_17 = Convert.ToInt64(beforeCount1.Value);
                    long int64_18 = Convert.ToInt64(afterCount1.Value);
                    bool boolean = Convert.ToBoolean(isCalculateRingBuff.Value);
                    if (0L < num5)
                    {
                        itemInfo.count1 = 0L;
                        itemInfo.beforeCount1 = 0L;
                        itemInfo.afterCount1 = 0L;
                        itemInfo.count2 = num5;
                        itemInfo.beforeCount2 = int64_17;
                        itemInfo.afterCount2 = int64_18;
                        WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingSellCalculate, CommonModule.GetCustomTime(), userInfo, itemInfo, model.retryBiddingNo, 1L, num5, (long)Convert.ToInt32(model.isSealed), int64_16, Convert.ToInt64(model.isWebAccess), int64_15, Convert.ToInt64(boolean), textParam1: packageExpiration.Value.ToString());
                    }
                    if (0L < int64_12)
                    {
                        itemInfo.count1 = int64_12;
                        itemInfo.beforeCount1 = int64_13;
                        itemInfo.afterCount1 = int64_14;
                        itemInfo.count2 = 0L;
                        itemInfo.beforeCount2 = 0L;
                        itemInfo.afterCount2 = 0L;
                        WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingSellWithdraw, customTime, userInfo, itemInfo, model.retryBiddingNo, 1L, (long)model.sellChooseKey, (long)Convert.ToInt32(model.isSealed), Convert.ToInt64(model.isWebAccess));
                    }
                }
                if (0L < Convert.ToInt64(resultWaitNo.Value))
                {
                    commonResult1.resultMsg = Convert.ToString(model.sellMainKey) + "-" + Convert.ToString(model.sellChooseKey) + "-" + Convert.ToString(model.sellCount) + "-" + Convert.ToString(model.sellPrice) + "-" + Convert.ToString(0) + "-" + Convert.ToString(0) + "-" + Convert.ToString(3) + "-" + Convert.ToString(model.isSealed) + "-" + Convert.ToString(num1) + "-" + Convert.ToString(model.retryBiddingNo) + "-" + Convert.ToString(num5);
                    return this.Json((object)commonResult1);
                }
                if (sellCount == 0L)
                {
                    commonResult1.resultMsg = Convert.ToString(model.sellMainKey) + "-" + Convert.ToString(model.sellChooseKey) + "-" + Convert.ToString(model.sellCount) + "-" + Convert.ToString(model.sellPrice) + "-" + Convert.ToString(num6) + "-" + Convert.ToString(num7) + "-" + Convert.ToString(0) + "-" + Convert.ToString(model.isSealed) + "-" + Convert.ToString(num1) + "-" + Convert.ToString(model.retryBiddingNo) + "-" + Convert.ToString(num5);
                    Task.Run((Action)(() => TradeModule.SendPearlAppAlarm(ref buyUserIdList, model.sellMainKey, "BUY")));
                    return this.Json((object)commonResult1);
                }
                try
                {
                    ObjectParameter isAppledRingBuff = new ObjectParameter("isAppledRingBuff", typeof(bool));
                    tradeWebDb.uspSellToWorldMarket(new int?(model.nationCode), new int?(model.worldNo), new long?(model.userNo), new int?(model.sellKeyType), new int?(model.sellMainKey), new int?(model.sellSubKey), new int?(info1._mainGroupNo), new bool?(model.isSealed), new long?(model.sellPrice), new long?(sellCount), new int?(model.sellChooseKey), new int?(tradeMarketItemInfo._mainKey), new long?(info1._enchantNeedCount), new double?(WorldMarketOptionManager.This().BiddingRatio), new bool?(flag1), new long?(info1._weight), new long?((long)WorldMarketOptionManager.This().getPearlItemLimitedMaxCount()), new DateTime?(customTime), new byte?(num1), new long?(num2), sellPricePerOne, realSellCount, totalMoneyCount, originalTotalMoneyCount, packageExpiration, sellNo, isAppledRingBuff, beforeCount1, afterCount1, beforeCount2, afterCount2, symNo, rv);
                    commonResult1.resultCode = Convert.ToInt32(rv.Value);
                    if (commonResult1.resultCode == 0)
                    {
                        long int64_19 = Convert.ToInt64(realSellCount.Value);
                        long int64_20 = Convert.ToInt64(totalMoneyCount.Value);
                        long int64_21 = Convert.ToInt64(originalTotalMoneyCount.Value);
                        long int64_22 = Convert.ToInt64(sellNo.Value);
                        long int64_23 = Convert.ToInt64(sellPricePerOne.Value);
                        long num10 = num6 + int64_19;
                        long num11 = num7 + int64_20;
                        if (num10 == 0L && int64_22 == 0L)
                        {
                            LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) ReserveBiddingFail", (object)end), "WARN");
                            commonResult1.resultCode = 23;
                            commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ReserveSellBiddingFail");
                            return this.Json((object)commonResult1);
                        }
                        commonResult1.resultMsg = Convert.ToString(model.sellMainKey) + "-" + Convert.ToString(model.sellChooseKey) + "-" + Convert.ToString(model.sellCount) + "-" + Convert.ToString(int64_23) + "-" + Convert.ToString(num10) + "-" + Convert.ToString(num11) + "-" + Convert.ToString(int64_22) + "-" + Convert.ToString(model.isSealed) + "-" + Convert.ToString(num1) + "-" + Convert.ToString(model.retryBiddingNo) + "-" + Convert.ToString(num5);
                        if (0L < int64_19)
                        {
                            itemInfo.count1 = int64_19;
                            itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1.Value);
                            itemInfo.afterCount1 = Convert.ToInt64(afterCount1.Value);
                            itemInfo.count2 = int64_20;
                            itemInfo.beforeCount2 = Convert.ToInt64(beforeCount2.Value);
                            itemInfo.afterCount2 = Convert.ToInt64(afterCount2.Value);
                            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_Sell, customTime, userInfo, itemInfo, (long)model.sellChooseKey, Convert.ToInt64(model.isSealed), int64_21, Convert.ToInt64(model.isWebAccess), Convert.ToInt64(model.isRingBuff), Convert.ToInt64(num1), model.retryBiddingNo, textParam1: packageExpiration.Value.ToString());
                        }
                        if (0L < int64_22)
                        {
                            itemInfo.count1 = sellCount - int64_19;
                            itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1.Value);
                            itemInfo.afterCount1 = Convert.ToInt64(afterCount1.Value);
                            itemInfo.keyType2 = 0;
                            itemInfo.itemKey2 = 0;
                            itemInfo.enchantLevel2 = 0;
                            itemInfo.count2 = 0L;
                            itemInfo.beforeCount2 = 0L;
                            itemInfo.afterCount2 = 0L;
                            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingSellRegister, customTime, userInfo, itemInfo, int64_22, (long)model.sellChooseKey, Convert.ToInt64(model.isSealed), model.sellPrice, Convert.ToInt64(model.isWebAccess), Convert.ToInt64(model.isRingBuff), Convert.ToInt64(num1), model.retryBiddingNo, textParam1: packageExpiration.Value.ToString());
                        }
                    }
                    else
                    {
                        if (0L < num6)
                        {
                            long int64 = Convert.ToInt64(sellPricePerOne.Value);
                            commonResult1.resultCode = 0;
                            commonResult1.resultMsg = Convert.ToString(model.sellMainKey) + "-" + Convert.ToString(model.sellChooseKey) + "-" + Convert.ToString(model.sellCount) + "-" + Convert.ToString(int64) + "-" + Convert.ToString(num6) + "-" + Convert.ToString(num7) + "-" + Convert.ToString(0) + "-" + Convert.ToString(model.isSealed) + "-" + Convert.ToString(num1) + "-" + Convert.ToString(model.retryBiddingNo) + "-" + Convert.ToString(num5);
                            Task.Run((Action)(() => TradeModule.SendPearlAppAlarm(ref buyUserIdList, model.sellMainKey, "BUY")));
                            return this.Json((object)commonResult1);
                        }
                        LogUtil.WriteLog(string.Format("[DB Error]SellItemProcess - uspSellToWorldMarket({0}/{1}), rv({2})", (object)end, (object)sellCount, (object)commonResult1.resultCode), "WARN");
                        commonResult1.resultMsg = Convert.ToString(symNo.Value);
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception]SellItemProcess() - uspSellToWorldMarket({0}/{1}) Exception : {2}", (object)end, (object)sellCount, (object)ex.ToString()), "ERROR");
                    commonResult1.resultCode = 1;
                    commonResult1.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)commonResult1);
                }
            }
            Task.Run((Action)(() => TradeModule.SendPearlAppAlarm(ref buyUserIdList, model.sellMainKey, "BUY")));
            return this.Json((object)commonResult1);
        }

        [HttpPost]
        public JsonResult WithdrawBuyBiddingProcess()
        {
            CommonResult commonResult = new CommonResult();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter differenceMoney = new ObjectParameter("differenceMoney", typeof(long));
            ObjectParameter withdrawMoneyCount = new ObjectParameter("withdrawMoneyCount", typeof(long));
            ObjectParameter isDelete = new ObjectParameter("isDelete", typeof(byte));
            ObjectParameter beforeCount1 = new ObjectParameter("beforeCount1", typeof(long));
            ObjectParameter afterCount1 = new ObjectParameter("afterCount1", typeof(long));
            GameTradeMarketBiddingInfo marketBiddingInfo1 = new GameTradeMarketBiddingInfo();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("WithdrawBuyBiddingProcess Fail is Not Open", "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog("WithdrawBuyBiddingProcess log DB Exception", "WARN");
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult);
            }
            string empty = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawBuyBiddingProcess({0}) - HttpRequest errorMsg : {1}", (object)empty, (object)ex.ToString()), "ERROR");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            GameTradeMarketBiddingInfo marketBiddingInfo2 = JsonConvert.DeserializeObject<GameTradeMarketBiddingInfo>(end);
            if (marketBiddingInfo2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawBuyBiddingProcess({0}) - model is null", (object)end), "WARN");
                commonResult.resultCode = 5;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)commonResult);
            }
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(marketBiddingInfo2.mainKey, marketBiddingInfo2.subKey);
            if (!info.isValid())
            {
                LogUtil.WriteLog(string.Format("[Item Error]WithdrawBuyBiddingProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", (object)end, (object)marketBiddingInfo2.mainKey, (object)marketBiddingInfo2.subKey), "WARN");
                commonResult.resultCode = 8;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                return this.Json((object)commonResult);
            }
            using (TradeWebDB tradeWebDb = new TradeWebDB())
            {
                try
                {
                    tradeWebDb.uspWithdrawBiddingBuy(new long?(marketBiddingInfo2.biddingNo), new int?(marketBiddingInfo2.keyType), new int?(marketBiddingInfo2.mainKey), new int?(info._enchantGroup), new long?(marketBiddingInfo2.count), new int?(marketBiddingInfo2.nationCode), new int?(marketBiddingInfo2.serverNo), new long?(marketBiddingInfo2.userNo), new int?(marketBiddingInfo2.subKey), differenceMoney, withdrawMoneyCount, isDelete, beforeCount1, afterCount1, symNo, rv);
                    commonResult.resultCode = Convert.ToInt32(rv.Value);
                    if (commonResult.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]WithdrawBuyBiddingProcess - uspWithdrawBiddingBuy({0}), rv({1})", (object)end, (object)commonResult.resultCode), "WARN");
                        commonResult.resultMsg = Convert.ToString(symNo.Value);
                        return this.Json((object)commonResult);
                    }
                    commonResult.resultMsg = Convert.ToString(marketBiddingInfo2.biddingNo) + "-" + Convert.ToString(marketBiddingInfo2.count) + "-" + Convert.ToString(differenceMoney.Value) + "-" + Convert.ToString(isDelete.Value);
                    WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingBuyWithdraw, CommonModule.GetCustomTime(), new CommonModel.TradeMarketUserLogInfo()
                    {
                        nationCode = marketBiddingInfo2.nationCode,
                        serverNo = marketBiddingInfo2.serverNo,
                        userNo = marketBiddingInfo2.userNo
                    }, new CommonModel.TradeMarketItemLogInfo()
                    {
                        keyType1 = marketBiddingInfo2.keyType,
                        itemKey1 = marketBiddingInfo2.mainKey,
                        enchantLevel1 = marketBiddingInfo2.subKey,
                        count1 = marketBiddingInfo2.count,
                        keyType2 = 0,
                        itemKey2 = 1,
                        enchantLevel2 = 0,
                        count2 = Convert.ToInt64(withdrawMoneyCount.Value),
                        beforeCount2 = Convert.ToInt64(beforeCount1.Value),
                        afterCount2 = Convert.ToInt64(afterCount1.Value)
                    }, marketBiddingInfo2.biddingNo, (long)Convert.ToInt32(isDelete.Value), Convert.ToInt64(differenceMoney.Value), Convert.ToInt64(marketBiddingInfo2.isWebAccess));
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception]WithdrawBuyBiddingProcess() - uspWithdrawBiddingBuy({0}) Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                    commonResult.resultCode = 1;
                    commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)commonResult);
                }
            }
            return this.Json((object)commonResult);
        }

        [HttpPost]
        public JsonResult CalculateBuyBiddingProcess()
        {
            CommonResult commonResult = new CommonResult();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter chooseSubKey = new ObjectParameter("chooseSubKey", typeof(int));
            ObjectParameter isDelete = new ObjectParameter("isDelete", typeof(byte));
            ObjectParameter boughtCount = new ObjectParameter("boughtCount", typeof(long));
            ObjectParameter beforeCount1 = new ObjectParameter("beforeCount1", typeof(long));
            ObjectParameter afterCount1 = new ObjectParameter("afterCount1", typeof(long));
            GameTradeMarketBiddingInfo marketBiddingInfo1 = new GameTradeMarketBiddingInfo();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("CalculateBuyBiddingProcess Fail is Not Open", "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog("CalculateBuyBiddingProcess log DB Exception", "WARN");
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult);
            }
            string empty = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CalculateBuyBiddingProcess({0}) - HttpRequest errorMsg : {1}", (object)empty, (object)ex.ToString()), "ERROR");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            GameTradeMarketBiddingInfo marketBiddingInfo2 = JsonConvert.DeserializeObject<GameTradeMarketBiddingInfo>(end);
            if (marketBiddingInfo2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CalculateBuyBiddingProcess({0}) - model is null", (object)end), "WARN");
                commonResult.resultCode = 5;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)commonResult);
            }
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(marketBiddingInfo2.mainKey, marketBiddingInfo2.subKey);
            if (!info.isValid())
            {
                LogUtil.WriteLog(string.Format("[Item Error]CalculateBuyBiddingProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", (object)end, (object)marketBiddingInfo2.mainKey, (object)marketBiddingInfo2.subKey), "WARN");
                commonResult.resultCode = 8;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                return this.Json((object)commonResult);
            }
            using (TradeWebDB tradeWebDb = new TradeWebDB())
            {
                try
                {
                    tradeWebDb.uspCalculateBiddingBuy(new long?(marketBiddingInfo2.biddingNo), new int?(marketBiddingInfo2.keyType), new int?(marketBiddingInfo2.mainKey), new int?(info._enchantGroup), new int?(marketBiddingInfo2.nationCode), new int?(marketBiddingInfo2.serverNo), new long?(marketBiddingInfo2.userNo), new long?(info._weight), new long?(WorldMarketOptionManager.This().getMaxWeight() * (long)WorldMarketOptionManager.This().getMaxWeightRate()), boughtCount, chooseSubKey, isDelete, beforeCount1, afterCount1, symNo, rv);
                    commonResult.resultCode = Convert.ToInt32(rv.Value);
                    if (commonResult.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]CalculateBuyBiddingProcess - uspCalculateBiddingBuy({0}), rv({1})", (object)end, (object)commonResult.resultCode), "WARN");
                        commonResult.resultMsg = Convert.ToString(symNo.Value);
                        return this.Json((object)commonResult);
                    }
                    commonResult.resultMsg = Convert.ToString(marketBiddingInfo2.biddingNo) + "-" + Convert.ToString(isDelete.Value) + "-" + Convert.ToString(boughtCount.Value);
                    WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingBuyCalculate, CommonModule.GetCustomTime(), new CommonModel.TradeMarketUserLogInfo()
                    {
                        nationCode = marketBiddingInfo2.nationCode,
                        serverNo = marketBiddingInfo2.serverNo,
                        userNo = marketBiddingInfo2.userNo
                    }, new CommonModel.TradeMarketItemLogInfo()
                    {
                        keyType1 = marketBiddingInfo2.keyType,
                        itemKey1 = marketBiddingInfo2.mainKey,
                        enchantLevel1 = marketBiddingInfo2.subKey,
                        count1 = Convert.ToInt64(boughtCount.Value),
                        beforeCount1 = Convert.ToInt64(beforeCount1.Value),
                        afterCount1 = Convert.ToInt64(afterCount1.Value)
                    }, marketBiddingInfo2.biddingNo, (long)Convert.ToInt32(isDelete.Value), (long)Convert.ToInt32(chooseSubKey.Value), Convert.ToInt64(marketBiddingInfo2.isWebAccess), Convert.ToInt64(boughtCount.Value));
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception]CalculateBuyBiddingProcess() - uspCalculateBiddingBuy({0}) Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                    commonResult.resultCode = 1;
                    commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)commonResult);
                }
            }
            return this.Json((object)commonResult);
        }

        [HttpPost]
        public JsonResult WithdrawSellBiddingProcess()
        {
            CommonResult commonResult = new CommonResult();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter chooseSubKey = new ObjectParameter("chooseSubKey", typeof(int));
            ObjectParameter isDelete = new ObjectParameter("isDelete", typeof(byte));
            ObjectParameter beforeCount1 = new ObjectParameter("beforeCount1", typeof(long));
            ObjectParameter afterCount1 = new ObjectParameter("afterCount1", typeof(long));
            GameTradeMarketBiddingInfo marketBiddingInfo1 = new GameTradeMarketBiddingInfo();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("WithdrawSellBiddingProcess Fail is Not Open", "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog("WithdrawSellBiddingProcess log DB Exception", "WARN");
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult);
            }
            string empty = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawSellBiddingProcess({0}) - HttpRequest errorMsg : {1}", (object)empty, (object)ex.ToString()), "ERROR");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            GameTradeMarketBiddingInfo marketBiddingInfo2 = JsonConvert.DeserializeObject<GameTradeMarketBiddingInfo>(end);
            if (marketBiddingInfo2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]WithdrawSellBiddingProcess({0}) - model is null", (object)end), "WARN");
                commonResult.resultCode = 5;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)commonResult);
            }
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(marketBiddingInfo2.mainKey, marketBiddingInfo2.subKey);
            if (!info.isValid())
            {
                LogUtil.WriteLog(string.Format("[Item Error]WithdrawSellBiddingProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", (object)end, (object)marketBiddingInfo2.mainKey, (object)marketBiddingInfo2.subKey), "WARN");
                commonResult.resultCode = 8;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                return this.Json((object)commonResult);
            }
            DateTime customTime = CommonModule.GetCustomTime();
            using (TradeWebDB tradeWebDb = new TradeWebDB())
            {
                try
                {
                    tradeWebDb.uspWithdrawBiddingSell(new long?(marketBiddingInfo2.biddingNo), new int?(marketBiddingInfo2.keyType), new int?(marketBiddingInfo2.mainKey), new int?(info._enchantGroup), new bool?(marketBiddingInfo2.isSealed), new long?(marketBiddingInfo2.count), new int?(marketBiddingInfo2.nationCode), new int?(marketBiddingInfo2.serverNo), new long?(marketBiddingInfo2.userNo), new long?(info._weight), new long?(WorldMarketOptionManager.This().getMaxWeight() * (long)WorldMarketOptionManager.This().getMaxWeightRate()), new long?((long)WorldMarketOptionManager.This().getBiddingPercent()), new DateTime?(customTime), chooseSubKey, isDelete, beforeCount1, afterCount1, symNo, rv);
                    commonResult.resultCode = Convert.ToInt32(rv.Value);
                    if (commonResult.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]WithdrawSellBiddingProcess - uspWithdrawBiddingSell({0}), rv({1})", (object)end, (object)commonResult.resultCode), "WARN");
                        commonResult.resultMsg = Convert.ToString(symNo.Value);
                        return this.Json((object)commonResult);
                    }
                    commonResult.resultMsg = Convert.ToString(marketBiddingInfo2.biddingNo) + "-" + Convert.ToString(marketBiddingInfo2.count) + "-" + Convert.ToString(isDelete.Value);
                    WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingSellWithdraw, customTime, new CommonModel.TradeMarketUserLogInfo()
                    {
                        nationCode = marketBiddingInfo2.nationCode,
                        serverNo = marketBiddingInfo2.serverNo,
                        userNo = marketBiddingInfo2.userNo
                    }, new CommonModel.TradeMarketItemLogInfo()
                    {
                        keyType1 = marketBiddingInfo2.keyType,
                        itemKey1 = marketBiddingInfo2.mainKey,
                        enchantLevel1 = marketBiddingInfo2.subKey,
                        count1 = marketBiddingInfo2.count,
                        beforeCount1 = Convert.ToInt64(beforeCount1.Value),
                        afterCount1 = Convert.ToInt64(afterCount1.Value)
                    }, marketBiddingInfo2.biddingNo, (long)Convert.ToInt32(isDelete.Value), (long)Convert.ToInt32(chooseSubKey.Value), (long)Convert.ToInt32(marketBiddingInfo2.isSealed), Convert.ToInt64(marketBiddingInfo2.isWebAccess));
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception]WithdrawSellBiddingProcess() - uspWithdrawBiddingSell({0}) Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                    commonResult.resultCode = 1;
                    commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)commonResult);
                }
            }
            return this.Json((object)commonResult);
        }

        [HttpPost]
        public JsonResult CalculateSellBiddingProcess()
        {
            CommonResult commonResult = new CommonResult();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter isDelete = new ObjectParameter("isDelete", typeof(byte));
            ObjectParameter amountMoney = new ObjectParameter("amountMoney", typeof(long));
            ObjectParameter objectParameter = new ObjectParameter("walletMoney", typeof(long));
            ObjectParameter soldCount = new ObjectParameter("soldCount", typeof(long));
            ObjectParameter originalTotalMoneyCount = new ObjectParameter("originalTotalMoneyCount", typeof(long));
            ObjectParameter packageExpiration = new ObjectParameter("packageExpiration", typeof(DateTime));
            ObjectParameter isAppledRingBuff = new ObjectParameter("isAppledRingBuff", typeof(bool));
            ObjectParameter beforeCount1 = new ObjectParameter("beforeCount1", typeof(long));
            ObjectParameter afterCount1 = new ObjectParameter("afterCount1", typeof(long));
            GameTradeMarketBiddingInfo marketBiddingInfo1 = new GameTradeMarketBiddingInfo();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog("CalculateSellBiddingProcess Fail is Not Open", "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog("CalculateSellBiddingProcess log DB Exception", "WARN");
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonResult);
            }
            string empty = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CalculateSellBiddingProcess({0}) - HttpRequest errorMsg : {1}", (object)empty, (object)ex.ToString()), "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            GameTradeMarketBiddingInfo marketBiddingInfo2 = JsonConvert.DeserializeObject<GameTradeMarketBiddingInfo>(end);
            if (marketBiddingInfo2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CalculateSellBiddingProcess({0}) - model is null", (object)end), "WARN");
                commonResult.resultCode = 5;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)commonResult);
            }
            TradeMarketItemInfo info = ItemInfoManager.This().getInfo(marketBiddingInfo2.mainKey, marketBiddingInfo2.subKey);
            if (!info.isValid())
            {
                LogUtil.WriteLog(string.Format("[Item Error]CalculateSellBiddingProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", (object)end, (object)marketBiddingInfo2.mainKey, (object)marketBiddingInfo2.subKey), "WARN");
                commonResult.resultCode = 8;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem");
                return this.Json((object)commonResult);
            }
            using (TradeWebDB tradeWebDb = new TradeWebDB())
            {
                try
                {
                    tradeWebDb.uspCalculateBiddingSell(new long?(marketBiddingInfo2.biddingNo), new int?(marketBiddingInfo2.keyType), new int?(marketBiddingInfo2.mainKey), new int?(info._enchantGroup), new int?(info._mainGroupNo), new bool?(marketBiddingInfo2.isSealed), new int?(marketBiddingInfo2.nationCode), new int?(marketBiddingInfo2.serverNo), new long?(marketBiddingInfo2.userNo), new int?(marketBiddingInfo2.subKey), soldCount, isDelete, amountMoney, originalTotalMoneyCount, packageExpiration, isAppledRingBuff, beforeCount1, afterCount1, symNo, rv);
                    commonResult.resultCode = Convert.ToInt32(rv.Value);
                    if (commonResult.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]CalculateSellBiddingProcess - uspCalculateBiddingSell({0}), rv({1})", (object)end, (object)commonResult.resultCode), "WARN");
                        commonResult.resultMsg = Convert.ToString(symNo.Value);
                        return this.Json((object)commonResult);
                    }
                    commonResult.resultMsg = Convert.ToString(marketBiddingInfo2.biddingNo) + "-" + Convert.ToString(isDelete.Value) + "-" + Convert.ToString(amountMoney.Value) + "-" + Convert.ToString(soldCount.Value);
                    WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_BiddingSellCalculate, CommonModule.GetCustomTime(), new CommonModel.TradeMarketUserLogInfo()
                    {
                        nationCode = marketBiddingInfo2.nationCode,
                        serverNo = marketBiddingInfo2.serverNo,
                        userNo = marketBiddingInfo2.userNo
                    }, new CommonModel.TradeMarketItemLogInfo()
                    {
                        keyType1 = marketBiddingInfo2.keyType,
                        itemKey1 = marketBiddingInfo2.mainKey,
                        enchantLevel1 = marketBiddingInfo2.subKey,
                        count1 = marketBiddingInfo2.count,
                        keyType2 = 0,
                        itemKey2 = 1,
                        enchantLevel2 = 0,
                        count2 = Convert.ToInt64(amountMoney.Value),
                        beforeCount2 = Convert.ToInt64(beforeCount1.Value),
                        afterCount2 = Convert.ToInt64(afterCount1.Value)
                    }, marketBiddingInfo2.biddingNo, (long)Convert.ToInt32(isDelete.Value), Convert.ToInt64(amountMoney.Value), (long)Convert.ToInt32(marketBiddingInfo2.isSealed), Convert.ToInt64(originalTotalMoneyCount.Value), Convert.ToInt64(marketBiddingInfo2.isWebAccess), Convert.ToInt64(soldCount.Value), Convert.ToInt64(isAppledRingBuff.Value), textParam1: packageExpiration.Value.ToString());
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Exception]CalculateSellBiddingProcess() - uspCalculateBiddingSell({0}) Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                    commonResult.resultCode = 1;
                    commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)commonResult);
                }
            }
            return this.Json((object)commonResult);
        }

        [HttpPost]
        public JsonResult ProcessCommand()
        {
            CommonResult commonResult = new CommonResult();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("ProcessCommand Fail is Not Open"), "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            string str = string.Empty;
            string commandString;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                str = new StreamReader(this.Request.InputStream).ReadToEnd();
                commandString = JsonConvert.DeserializeObject<string>(str);
                if (commandString == null)
                {
                    LogUtil.WriteLog(string.Format("[Http Error]ProcessCommand({0}) - command is null", (object)str), "WARN");
                    commonResult.resultCode = 2;
                    commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                    return this.Json((object)commonResult);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]ProcessCommand({0}) - HttpRequest errorMsg : {1}", (object)str, (object)ex.ToString()), "ERROR");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            commonResult.resultCode = this._commnadProcess.process(commandString);
            commonResult.resultMsg = "";
            return this.Json((object)commonResult);
        }

        [HttpPost]
        public JsonResult SyncNoticeItemListProcess()
        {
            CommonDBResult<uspListNoticeItem_Result> commonDbResult = new CommonDBResult<uspListNoticeItem_Result>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("SyncNoticeItemListProcess Fail is Not Open"), "WARN");
                commonDbResult.resultCode = 2;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonDbResult);
            }
            string str = string.Empty;
            long num;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                str = new StreamReader(this.Request.InputStream).ReadToEnd();
                num = JsonConvert.DeserializeObject<long>(str);
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]SyncNoticeItemListProcess({0}) - HttpRequest errorMsg : {1}", (object)str, (object)ex.ToString()), "ERROR");
                commonDbResult.resultCode = 2;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonDbResult);
            }
            using (TradeWebDB tradeWebDb = new TradeWebDB())
            {
                try
                {
                    commonDbResult.list = ((IEnumerable<uspListNoticeItem_Result>)tradeWebDb.uspListNoticeItem(new long?(num), rv, symNo)).ToList<uspListNoticeItem_Result>();
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[DB Error]SyncNoticeItemListProcess - uspListNoticeItem ({0})", (object)ex.ToString()), "ERROR");
                    commonDbResult.resultCode = 1;
                    commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)commonDbResult);
                }
            }
            return this.Json((object)commonDbResult);
        }

        [HttpPost]
        public JsonResult updateCurrentPriceProcess()
        {
            CommonDBResult<uspListWorldMarketCurrentPrice_Result> commonDbResult = new CommonDBResult<uspListWorldMarketCurrentPrice_Result>();
            ObjectParameter symNo = new ObjectParameter("rv", typeof(int));
            ObjectParameter rv = new ObjectParameter("symNo", typeof(string));
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("updateCurrentPriceProcess Fail is Not Open"), "WARN");
                commonDbResult.resultCode = 2;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonDbResult);
            }
            KeyValuePair<int, int> nextCategory = CategoryInfoManager.This().getNextCategory(ref GameProcessController.currentIndex);
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                    commonDbResult.list = ((IEnumerable<uspListWorldMarketCurrentPrice_Result>)tradeWebDb.uspListWorldMarketCurrentPrice(new int?(nextCategory.Key), new int?(nextCategory.Value), symNo, rv)).ToList<uspListWorldMarketCurrentPrice_Result>();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Error]SyncNoticeItemListProcess - uspListNoticeItem () errorMsg : {0}", (object)ex.ToString()), "ERROR");
                commonDbResult.resultCode = 1;
                commonDbResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)commonDbResult);
            }
            return this.Json((object)commonDbResult);
        }

        [HttpPost]
        public JsonResult SetMaintenance()
        {
            CommonResult commonResult = new CommonResult();
            MaintenanceResponseModel maintenanceResponseModel = (MaintenanceResponseModel)null;
            string str = string.Empty;
            MaintenanceRequestModel maintenanceRequestModel;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                str = new StreamReader(this.Request.InputStream).ReadToEnd();
                maintenanceRequestModel = JsonConvert.DeserializeObject<MaintenanceRequestModel>(str);
            }
            catch (Exception ex)
            {
                commonResult.resultCode = -99970;
                commonResult.resultMsg = "[Process]Maintenance Information Save Exception Error.";
                LogUtil.WriteLog(string.Format("[Exception] SetMaintenance({0}) - HttpRequest errorMsg : {1}", (object)str, (object)ex.ToString()), "ERROR");
                return this.Json((object)commonResult);
            }
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    ObjectParameter objectParameter = new ObjectParameter("groupContentNo", typeof(int));
                    ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
                    if (maintenanceRequestModel._setType == "Insert")
                    {
                        tradeWebDb.uspSetContentsInsUseWeb(new int?(maintenanceRequestModel._groupContentsNo), new DateTime?(Convert.ToDateTime(maintenanceRequestModel._maintenanceStartDate)), new DateTime?(Convert.ToDateTime(maintenanceRequestModel._maintenanceExpireDate)), new byte?(maintenanceRequestModel._isDisplay), new byte?(maintenanceRequestModel._isDelete), resultCode);
                        if (Convert.ToInt32(resultCode.Value).Equals(0).Equals(false))
                        {
                            commonResult.resultCode = Convert.ToInt32(resultCode.Value);
                            return this.Json((object)commonResult);
                        }
                        foreach (MaintensnceDetailModel maintenanceInfo in maintenanceRequestModel._maintenanceInfoList)
                            tradeWebDb.uspSetShutDownInfoInsUseWeb(new int?(maintenanceRequestModel._groupContentsNo), maintenanceInfo._culture, maintenanceInfo._mainText, maintenanceInfo._subText, string.Empty, maintenanceInfo._memo, resultCode);
                    }
                    else if (maintenanceRequestModel._setType == "Update")
                    {
                        tradeWebDb.uspSetContentsUpdUseWeb(new int?(maintenanceRequestModel._groupContentsNo), new DateTime?(Convert.ToDateTime(maintenanceRequestModel._maintenanceStartDate)), new DateTime?(Convert.ToDateTime(maintenanceRequestModel._maintenanceExpireDate)), new byte?(maintenanceRequestModel._isDisplay), new byte?(maintenanceRequestModel._isDelete), resultCode);
                        if (Convert.ToInt32(resultCode.Value).Equals(0).Equals(false))
                        {
                            commonResult.resultCode = Convert.ToInt32(resultCode.Value);
                            return this.Json((object)commonResult);
                        }
                        foreach (MaintensnceDetailModel maintenanceInfo in maintenanceRequestModel._maintenanceInfoList)
                            tradeWebDb.uspSetShutDownInfoUpdUseWeb(new int?(maintenanceRequestModel._groupContentsNo), maintenanceInfo._culture, maintenanceInfo._mainText, maintenanceInfo._subText, string.Empty, maintenanceInfo._memo, resultCode);
                    }
                    else if (maintenanceRequestModel._setType == "Update_Content")
                    {
                        tradeWebDb.uspSetContentsUpdUseWeb(new int?(maintenanceRequestModel._groupContentsNo), new DateTime?(Convert.ToDateTime(maintenanceRequestModel._maintenanceStartDate)), new DateTime?(Convert.ToDateTime(maintenanceRequestModel._maintenanceExpireDate)), new byte?(maintenanceRequestModel._isDisplay), new byte?(maintenanceRequestModel._isDelete), resultCode);
                        if (Convert.ToInt32(resultCode.Value).Equals(0).Equals(false))
                        {
                            commonResult.resultCode = Convert.ToInt32(resultCode.Value);
                            return this.Json((object)commonResult);
                        }
                    }
                    else if (maintenanceRequestModel._setType == "Update_Shutdown")
                    {
                        foreach (MaintensnceDetailModel maintenanceInfo in maintenanceRequestModel._maintenanceInfoList)
                            tradeWebDb.uspSetShutDownInfoUpdUseWeb(new int?(maintenanceRequestModel._groupContentsNo), maintenanceInfo._culture, maintenanceInfo._mainText, maintenanceInfo._subText, string.Empty, maintenanceInfo._memo, resultCode);
                    }
                    commonResult.resultCode = 0;
                    commonResult.resultMsg = JsonConvert.SerializeObject((object)maintenanceResponseModel);
                }
            }
            catch (Exception ex)
            {
                commonResult.resultCode = -99980;
                commonResult.resultMsg = "[Process]Maintenance Information Save Exception Error.";
                LogUtil.WriteLog(string.Format("[Exception] SetMaintenanceTradeMarket() : {0}", (object)ex.ToString()), "ERROR");
            }
            return this.Json((object)commonResult);
        }

        [HttpPost]
        public JsonResult CheckWithDrawPayLoadProcess()
        {
            string empty1 = string.Empty;
            CommonResult commonResult = new CommonResult();
            GameTradeMarketState tradeMarketState = new GameTradeMarketState();
            GameTradeMarketIncludePayload marketIncludePayload1 = new GameTradeMarketIncludePayload();
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("CheckWithDrawPayLoadProcess Fail is Not Open"), "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)commonResult);
            }
            string empty2 = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CheckWithDrawPayLoadProcess({0}) - HttpRequest errorMsg : {1}", (object)empty2, (object)ex.ToString()), "ERROR");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                tradeMarketState.result = commonResult;
                return this.Json((object)tradeMarketState);
            }
            GameTradeMarketIncludePayload marketIncludePayload2 = JsonConvert.DeserializeObject<GameTradeMarketIncludePayload>(end);
            if (marketIncludePayload2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CheckWithDrawPayLoadProcess({0}) - model is null", (object)end), "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                tradeMarketState.result = commonResult;
                return this.Json((object)tradeMarketState);
            }
            try
            {
                ObjectParameter state = new ObjectParameter("state", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    tradeWebDb.uspGetWithDrawPayLoadState(new long?(marketIncludePayload2.userNo), new int?(marketIncludePayload2.nationCode), new int?(marketIncludePayload2.serverNo), new long?(marketIncludePayload2.payload), new int?(marketIncludePayload2.mainKey), new int?(marketIncludePayload2.subKey), new bool?(marketIncludePayload2.isSealed), new long?(marketIncludePayload2.count), new long?(marketIncludePayload2.param0), new long?(marketIncludePayload2.param1), new long?(marketIncludePayload2.param2), new long?(marketIncludePayload2.param3), new long?(marketIncludePayload2.param4), state, symNo, rv);
                    int int32 = Convert.ToInt32(rv.Value);
                    string str = Convert.ToString(symNo.Value);
                    tradeMarketState.state = Convert.ToInt32(state.Value);
                    if (int32 != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error]CheckWithDrawPayLoadProcess - uspGetWithDrawPayLoadState({0}/{1}), rv({2})", (object)end, (object)str, (object)int32), "WARN");
                        commonResult.resultCode = int32;
                        commonResult.resultMsg = str;
                        tradeMarketState.result = commonResult;
                        return this.Json((object)tradeMarketState);
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception]CheckWithDrawPayLoadProcess() - uspGetWithDrawPayLoadState({0}) Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                tradeMarketState.result = commonResult;
                return this.Json((object)tradeMarketState);
            }
            return this.Json((object)tradeMarketState);
        }

        [HttpPost]
        public JsonResult GetMyWalletInfoProcess()
        {
            UserInfomationResultModel infomationResultModel = new UserInfomationResultModel();
            GameTradeMarketUserId tradeMarketUserId1 = new GameTradeMarketUserId();
            ObjectParameter userNo = new ObjectParameter("userNo", typeof(string));
            ObjectParameter userNickName = new ObjectParameter("userNickName", typeof(string));
            ObjectParameter serviceType = new ObjectParameter("serviceType", typeof(int));
            ObjectParameter worldNo = new ObjectParameter("worldNo", typeof(int));
            ObjectParameter valuepackage = new ObjectParameter("valuepackage", typeof(DateTime));
            ObjectParameter addWeightBuff = new ObjectParameter("addWeightBuff", typeof(DateTime));
            ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
            ObjectParameter resultMsg = new ObjectParameter("resultMsg", typeof(string));
            if (!ServerControlManager.This().IsLoadComplete())
            {
                LogUtil.WriteLog(string.Format("CalculateSellBiddingProcess Fail is Not Open"), "WARN");
                infomationResultModel._result.resultCode = 2;
                infomationResultModel._result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)infomationResultModel);
            }
            if (!WorldMarketLog.logDbCheck())
            {
                LogUtil.WriteLog(string.Format("CalculateSellBiddingProcess log DB Exception"), "WARN");
                infomationResultModel._result.resultCode = 1;
                infomationResultModel._result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)infomationResultModel);
            }
            string empty = string.Empty;
            string end;
            try
            {
                this.Request.InputStream.Seek(0L, SeekOrigin.Begin);
                end = new StreamReader(this.Request.InputStream).ReadToEnd();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CalculateSellBiddingProcess({0}) - HttpRequest errorMsg : {1}", (object)empty, (object)ex.ToString()), "WARN");
                infomationResultModel._result.resultCode = 2;
                infomationResultModel._result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return this.Json((object)infomationResultModel);
            }
            GameTradeMarketUserId tradeMarketUserId2 = JsonConvert.DeserializeObject<GameTradeMarketUserId>(end);
            if (tradeMarketUserId2 == null)
            {
                LogUtil.WriteLog(string.Format("[Http Error]CalculateSellBiddingProcess({0}) - model is null", (object)end), "WARN");
                infomationResultModel._result.resultCode = 5;
                infomationResultModel._result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull");
                return this.Json((object)infomationResultModel);
            }
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                    tradeWebDb.uspGetMyWalletInfo(tradeMarketUserId2._accountNo.ToString(), userNo, userNickName, serviceType, worldNo, valuepackage, addWeightBuff, resultCode, resultMsg);
                if (Convert.ToInt64(userNo.Value) == 0L)
                {
                    LogUtil.WriteLog(string.Format("[DB ERROR]uspGetMyWalletInfo({0}) - can't find userinfo ", (object)tradeMarketUserId2._accountNo), "WARN");
                    infomationResultModel._result.resultCode = 1;
                    infomationResultModel._result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                    return this.Json((object)infomationResultModel);
                }
                infomationResultModel._userInfo = new UserInfomationModel()
                {
                    _userNo = Convert.ToInt64(userNo.Value),
                    _nationCode = Convert.ToInt32(serviceType.Value),
                    _worldNo = Convert.ToInt32(worldNo.Value),
                    _userNickName = Convert.ToString(userNickName.Value),
                    _valuePackageExpiration = Convert.ToDateTime(valuepackage.Value).AddHours((double)ConstantMgr._serviceUtcTime),
                    _addWeightBuffExpiration = Convert.ToDateTime(addWeightBuff.Value).AddHours((double)ConstantMgr._serviceUtcTime)
                };
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception]CalculateSellBiddingProcess() - uspCalculateBiddingSell({0}) Exception : {1}", (object)end, (object)ex.ToString()), "ERROR");
                infomationResultModel._result.resultCode = 1;
                infomationResultModel._result.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException");
                return this.Json((object)infomationResultModel);
            }
            return this.Json((object)infomationResultModel);
        }
    }
}
