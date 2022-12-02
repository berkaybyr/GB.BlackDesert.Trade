// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Common.TradeModule
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.Objects;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace BlackDesert.TradeMarket.Lib.Common
{
    public static class TradeModule
    {
        public static CommonResult CheckAuthKey(
          ref UserInfomationModel userInfo,
          HttpContext context,
          long userNo = 0,
          string certifiedKey = "",
          bool isRecord = false)
        {
            CommonResult commonResult = new CommonResult();
            try
            {
                AuthenticationInfo authInfo = AuthenticateManager.GetAuthInfo(context);
                if (authInfo != null)
                {
                    userInfo = authInfo.userInfoModel;
                    userInfo._isWebAccess = true;
                    userInfo._isReturn = false;
                    //if (authInfo.userInfoModel._secondPwdPass.Equals(false))
                    //{
                    //    commonResult.resultCode = 28877;
                    //    commonResult.resultMsg = "TRADE_MARKET_ERROR_MSG_UNAUTHORIZED";
                    //    return commonResult;
                    //}
                    if (isRecord)
                    {
                        ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                        ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                        ObjectParameter serviceType = new ObjectParameter("serviceType", typeof(int));
                        ObjectParameter worldNo = new ObjectParameter("worldNo", typeof(int));
                        ObjectParameter isAdmissionToSpeedServer = new ObjectParameter("isAdmissionToSpeedServer", typeof(byte));
                        ObjectParameter isUpdatePackageBuff = new ObjectParameter("isUpdatePackageBuff", typeof(bool));
                        using (SA_BETA_WORLDDB_0002 SA_BETA_WORLDDB_0002 = new SA_BETA_WORLDDB_0002())
                        {
                            SA_BETA_WORLDDB_0002.uspAccessByTradeWeb(new long?(userInfo._userNo), serviceType, worldNo, isAdmissionToSpeedServer, isUpdatePackageBuff, symNo, rv);
                            commonResult.resultCode = Convert.ToInt32(rv.Value);
                            if (commonResult.resultCode != 0)
                            {
                                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_UNAUTHORIZED");
                                LogUtil.WriteLog(string.Format("[DB Error] uspAccessByTradeWeb({0}/{1}), rv({2})", (object)userNo, (object)certifiedKey, (object)commonResult.resultCode), "WARN");
                                return commonResult;
                            }
                        }
                        if (1 == Convert.ToInt32(isAdmissionToSpeedServer.Value) && Convert.ToBoolean(isUpdatePackageBuff.Value))
                        {
                            using (SA_BETA_GAMEDB_0002 SA_BETA_GAMEDB_0002 = new SA_BETA_GAMEDB_0002()) //TradeModule.MakeGameDbName("", Convert.ToInt32(worldNo.Value))
                            {
                                SA_BETA_GAMEDB_0002.uspUpdatePackageBuffByWeb(new long?(userInfo._userNo), new short?(Convert.ToInt16(serviceType.Value)), symNo, rv);
                                commonResult.resultCode = Convert.ToInt32(rv.Value);
                                if (commonResult.resultCode != 0)
                                {
                                    commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_UNAUTHORIZED");
                                    LogUtil.WriteLog(string.Format("[DB Error] uspUpdatePackageBuffByWeb({0}/{1}), rv({2})", (object)userNo, (object)certifiedKey, (object)commonResult.resultCode), "WARN");
                                    return commonResult;
                                }
                            }
                            userInfo._isReturn = true;
                        }
                    }
                    return commonResult;
                }
                if (userNo == 0L && certifiedKey.IsNullOrEmpty())
                {
                    LogUtil.WriteLog("[Auth Error] Request is Unauthorized. UserNo is Not Invalid", "WARN");
                    commonResult.resultCode = 2000;
                    commonResult.resultMsg = "TRADE_MARKET_ERROR_MSG_UNAUTHORIZED";
                    return commonResult;
                }
                userInfo = new UserInfomationModel();
                using (SA_BETA_WORLDDB_0002 SA_BETA_WORLDDB_0002 = new SA_BETA_WORLDDB_0002())
                {
                    DateTime customTime = CommonModule.GetCustomTime();
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    ObjectParameter serviceType = new ObjectParameter("serviceType", typeof(int));
                    ObjectParameter worldNo = new ObjectParameter("worldNo", typeof(int));
                    ObjectParameter userNickName = new ObjectParameter("userNickName", typeof(string));
                    ObjectParameter date = new ObjectParameter("requestDate", typeof(DateTime));
                    SA_BETA_WORLDDB_0002.uspCheckAuthKey(new long?(userNo), certifiedKey, date, serviceType, worldNo, userNickName, symNo, rv);
                    commonResult.resultCode = Convert.ToInt32(rv.Value);
                    commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_UNAUTHORIZED");
                    if (commonResult.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error] uspCheckAuthKey({0}/{1}), rv({2})", (object)userNo, (object)certifiedKey, (object)commonResult.resultCode), "WARN");
                        return commonResult;
                    }
                    if (serviceType.Value == null || worldNo.Value == null || userNickName.Value == null)
                    {
                        commonResult.resultCode = Convert.ToInt32((object)ErrorNo.eErrorNo_UserNotExist);
                        commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_NOT_EXSITS_USER");
                        LogUtil.WriteLog(string.Format("CheckAuthKey - Not Found UserInfo in Database({0}/{1}), rv({2})", (object)userNo, (object)certifiedKey, (object)commonResult.resultCode), "WARN");
                        return commonResult;
                    }
                    userInfo._nationCode = Convert.ToInt32(serviceType.Value);
                    userInfo._worldNo = Convert.ToInt32(worldNo.Value);
                    userInfo._userNickName = Convert.ToString(userNickName.Value);
                    userInfo._userNo = userNo;
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception] CheckAuthKey({0}/{1}) Exception : {2}", (object)userNo, (object)certifiedKey, (object)ex.ToString()), "ERROR");
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_EXCEPTION");
                return commonResult;
            }
            return commonResult;
        }

        public static CommonResult CheckTicketNo(
          long userNo,
          int worldNo,
          byte ticketType,
          string ticketNo)
        {
            CommonResult commonResult = new CommonResult();
            try
            {
                using (SA_BETA_GAMEDB_0002 SA_BETA_GAMEDB_0002 = new SA_BETA_GAMEDB_0002()) //TradeModule.MakeGameDbName(hostName, worldNo)
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    SA_BETA_GAMEDB_0002.uspUsingTicket(new long?(userNo), new byte?(ticketType), ticketNo, rv, symNo);
                    commonResult.resultCode = Convert.ToInt32(rv.Value);
                    commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_UNAUTHORIZED");
                    if (commonResult.resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error] CheckTicketNo({0}/{1}/{2}/{3}), rv({4})", (object)userNo, (object)worldNo, (object)ticketType, (object)ticketNo, (object)commonResult.resultCode), "WARN");
                        return commonResult;
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB Exception] CheckTicketNo({0}/{1}/{2}/{3}) Exception : {4}", (object)userNo, (object)worldNo, (object)ticketType, (object)ticketNo, (object)ex.ToString()), "ERROR");
                commonResult.resultCode = 1;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_ERROR_MSG_EXCEPTION");
                return commonResult;
            }
            return commonResult;
        }

        public static string MakeGameDbName(string hostName, int worldNo)
        {
            string str = "SA_BETA_GAMEDB_0002";
            char[] chArray = new char[3] { '.', '/', '-' };
            string[] strArray = hostName.Split(chArray);
            if (ConstantMgr._serviceProject.Equals("BDO"))
                str = "SA_BETA_GAMEDB_0002_" + Convert.ToString(worldNo);
            else if (ConstantMgr._serviceProject.Equals("BDM"))
            {
                if (!strArray[0].Equals("local") && !strArray[0].Equals("dev"))
                    str = "SA_BETA_GAMEDB_0002" + strArray[1];
            }
            else if (ConstantMgr._serviceProject.Equals("CDO"))
                str = "SA_BETA_GAMEDB_0002";
            return str;
        }

        public static DateTime GetValuePackageExpiration(
          UserInfomationModel userInfo,
          string hostName)
        {
            DateTime minValue = DateTime.MinValue;
            string empty = string.Empty;
            try
            {
                using (SA_BETA_GAMEDB_0002 SA_BETA_GAMEDB_0002 = new SA_BETA_GAMEDB_0002(TradeModule.MakeGameDbName(hostName, userInfo._worldNo)))
                {
                    ObjectParameter packageExpiration = new ObjectParameter("packageExpiration", typeof(DateTime));
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    SA_BETA_GAMEDB_0002.uspGetPremiumPackageExpiration(new long?(userInfo._userNo), packageExpiration, symNo, rv);
                    Convert.ToInt32(rv.Value);
                    Convert.ToString(symNo.Value);
                    return Convert.ToDateTime(packageExpiration.Value);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("GetValuePackageExpiration - ({0}/{1}/{2}) Exception={3}", (object)userInfo._userNo, (object)userInfo._worldNo, (object)hostName, (object)ex.ToString()), "ERROR");
                return DateTime.MinValue;
            }
        }

        public static DateTime GetChargeBuffExpiration(
          UserInfomationModel userInfo,
          string hostName,
          byte buffType)
        {
            DateTime minValue = DateTime.MinValue;
            string empty = string.Empty;
            try
            {
                using (SA_BETA_GAMEDB_0002 SA_BETA_GAMEDB_0002 = new SA_BETA_GAMEDB_0002()) //TradeModule.MakeGameDbName(hostName, userInfo._worldNo)
                {
                    ObjectParameter packageExpiration = new ObjectParameter("packageExpiration", typeof(DateTime));
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    SA_BETA_GAMEDB_0002.uspGetChargeBuffExpiration(new long?(userInfo._userNo), new byte?(buffType), packageExpiration, symNo, rv);
                    Convert.ToInt32(rv.Value);
                    Convert.ToString(symNo.Value);
                    return Convert.ToDateTime(packageExpiration.Value);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("GetChargeBuffExpiration - ({0}/{1}/{2}) Exception={3}", (object)userInfo._userNo, (object)userInfo._worldNo, (object)hostName, (object)ex.ToString()), "ERROR");
                return DateTime.MinValue;
            }
        }

        public static int getFamilyPoint(long userNo, string hostName, int worldNo)
        {
            int familyPoint = 0;
            int num = 0;
            string empty = string.Empty;
            try
            {
                using (SA_BETA_GAMEDB_0002 SA_BETA_GAMEDB_0002 = new SA_BETA_GAMEDB_0002(TradeModule.MakeGameDbName(hostName, worldNo)))
                {
                    ObjectParameter objectParameter = new ObjectParameter("packageExpiration", typeof(DateTime));
                    ObjectParameter levelPoint = new ObjectParameter("levelPoint", typeof(int));
                    ObjectParameter lifeLevelPoint = new ObjectParameter("lifeLevelPoint", typeof(int));
                    ObjectParameter etcPoint = new ObjectParameter("etcPoint", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("rv", typeof(int));
                    ObjectParameter rv = new ObjectParameter("symNo", typeof(string));
                    SA_BETA_GAMEDB_0002.uspGetFamilyPointForWorldTradeMarket(new long?(userNo), levelPoint, lifeLevelPoint, etcPoint, rv, symNo);
                    num = Convert.ToInt32(symNo.Value);
                    empty = Convert.ToString(rv.Value);
                    familyPoint = Convert.ToInt32(levelPoint.Value) + Convert.ToInt32(lifeLevelPoint.Value) + Convert.ToInt32(etcPoint.Value);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB ERROR]GetFamilyPointError - ({0}/{1}) Exception={2}", (object)userNo, (object)hostName, (object)ex.ToString()), "ERROR");
                familyPoint = 0;
            }
            if (num != 0)
            {
                LogUtil.WriteLog(string.Format("[DB ERROR]GetFamilyPointError - ({0}/{1}) rv({2}) symNo({3})", (object)userNo, (object)hostName, (object)num, (object)empty), "WARN");
                familyPoint = 0;
            }
            return familyPoint;
        }

        public static int getMaidCount(long userNo, string hostName, int worldNo)
        {
            int maidCount1 = 0;
            int num = 0;
            string empty = string.Empty;
            try
            {
                using (SA_BETA_GAMEDB_0002 SA_BETA_GAMEDB_0002 = new SA_BETA_GAMEDB_0002(TradeModule.MakeGameDbName(hostName, worldNo)))
                {
                    ObjectParameter maidCount2 = new ObjectParameter("maidCount", typeof(int));
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    SA_BETA_GAMEDB_0002.uspGetTradeMaidCount(new long?(userNo), maidCount2, rv, symNo);
                    num = Convert.ToInt32(rv.Value);
                    empty = Convert.ToString(symNo.Value);
                    maidCount1 = Convert.ToInt32(maidCount2.Value);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB ERROR]uspGetTradeMaidCount - ({0}/{1}) Exception={2}", (object)userNo, (object)hostName, (object)ex.ToString()), "ERROR");
                maidCount1 = 0;
            }
            if (num != 0)
            {
                LogUtil.WriteLog(string.Format("[DB ERROR]uspGetTradeMaidCount - ({0}/{1}) rv({2}) symNo({3})", (object)userNo, (object)hostName, (object)num, (object)empty), "WARN");
                maidCount1 = 0;
            }
            return maidCount1;
        }

        public static bool isGameMaster(long userNo)
        {
            bool flag = false;
            int num = 0;
            string empty = string.Empty;
            try
            {
                using (SA_BETA_WORLDDB_0002 SA_BETA_WORLDDB_0002 = new SA_BETA_WORLDDB_0002())
                {
                    ObjectParameter isGameMaster = new ObjectParameter(nameof(isGameMaster), typeof(bool));
                    ObjectParameter symNo = new ObjectParameter("rv", typeof(int));
                    ObjectParameter rv = new ObjectParameter("symNo", typeof(string));
                    SA_BETA_WORLDDB_0002.uspIsGameMaster(new long?(userNo), isGameMaster, symNo, rv);
                    num = Convert.ToInt32(symNo.Value);
                    empty = Convert.ToString(rv.Value);
                    flag = Convert.ToBoolean(isGameMaster.Value);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB ERROR]uspIsGameMaster - ({0}) Exception={1}", (object)userNo, (object)ex.ToString()), "ERROR");
                flag = false;
            }
            if (num != 0)
            {
                LogUtil.WriteLog(string.Format("[DB ERROR]uspIsGameMaster - ({0}) rv({1}) symNo({2})", (object)userNo, (object)num, (object)empty), "WARN");
                flag = false;
            }
            return flag;
        }

        public static string GetMaintenanceInfo()
        {
            string maintenanceInfo = string.Empty;
            CommonModule.GetCustomTime();
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    SA_BETA_TRADEDB_0002.uspIsMarketOpen__XXX(symNo);
                    maintenanceInfo = symNo.Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("TradeModule GetMaintenanceInfo Exception Error=" + ex.ToString(), "ERROR");
            }
            return maintenanceInfo;
        }

        public static List<uspFamilySKillListFromWorldMarket_Result> getFamilySkillList(
          long userNo,
          string hostName,
          int worldNo)
        {
            int num = 0;
            string empty = string.Empty;
            List<uspFamilySKillListFromWorldMarket_Result> familySkillList = new List<uspFamilySKillListFromWorldMarket_Result>();
            try
            {
                using (SA_BETA_GAMEDB_0002 SA_BETA_GAMEDB_0002 = new SA_BETA_GAMEDB_0002(TradeModule.MakeGameDbName(hostName, worldNo)))
                {
                    ObjectParameter symNo = new ObjectParameter("rv", typeof(int));
                    ObjectParameter rv = new ObjectParameter("symNo", typeof(string));
                    familySkillList = ((IEnumerable<uspFamilySKillListFromWorldMarket_Result>)SA_BETA_GAMEDB_0002.uspFamilySKillListFromWorldMarket(new long?(userNo), symNo, rv)).ToList<uspFamilySKillListFromWorldMarket_Result>();
                    num = Convert.ToInt32(symNo.Value);
                    empty = Convert.ToString(rv.Value);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB ERROR]uspGetFamilySkillToWorldMarket - ({0}/{1}) Exception={2}", (object)userNo, (object)hostName, (object)ex.ToString()), "ERROR");
            }
            if (num != 0)
                LogUtil.WriteLog(string.Format("[DB ERROR]uspGetFamilySkillToWorldMarket - ({0}/{1}) rv({2}) symNo({3})", (object)userNo, (object)hostName, (object)num, (object)empty), "WARN");
            return familySkillList;
        }

        public static int getRingBuffList(long userNo, string hostName, int worldNo)
        {
            string empty = string.Empty;
            try
            {
                using (SA_BETA_GAMEDB_0002 SA_BETA_GAMEDB_0002 = new SA_BETA_GAMEDB_0002(TradeModule.MakeGameDbName(hostName, worldNo)))
                {
                    ObjectParameter symNo = new ObjectParameter("rv", typeof(int));
                    ObjectParameter ringBuffMaxCount = new ObjectParameter("ringBuffMaxCount", typeof(int));
                    ObjectParameter rv = new ObjectParameter("symNo", typeof(string));
                    SA_BETA_GAMEDB_0002.uspGetTradeRingBuff(new long?(userNo), ringBuffMaxCount, symNo, rv);
                    int int32 = Convert.ToInt32(symNo.Value);
                    string str = Convert.ToString(rv.Value);
                    if (int32 == 0)
                        return Convert.ToInt32(ringBuffMaxCount.Value);
                    LogUtil.WriteLog(string.Format("[DB ERROR]uspGetTradeRingBuff - ({0}/{1}) rv({2}) symNo({3})", (object)userNo, (object)hostName, (object)int32, (object)str), "WARN");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB ERROR]uspGetTradeRingBuff - ({0}/{1}) Exception={2}", (object)userNo, (object)hostName, (object)ex.ToString()), "ERROR");
                return 0;
            }
        }

        public static bool getWebMaintanace()
        {
            bool webMaintanace = true;
            string defaultCulture = ConstantMgr._defaultCulture;
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
                    webMaintanace = ((IEnumerable<uspGetShutDownCheckUseWeb_Result>)SA_BETA_TRADEDB_0002.uspGetShutDownCheckUseWeb(defaultCulture, resultCode)).Count<uspGetShutDownCheckUseWeb_Result>() > 0;
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("[DB ERROR]uspGetShutDownCheckUseWeb cultureCode :  - (" + defaultCulture + ") Exception=" + ex.ToString(), "ERROR");
            }
            return webMaintanace;
        }

        public static int historyInit()
        {
            int num = 0;
            string empty = string.Empty;
            try
            {
                using (SA_BETA_WORLDDB_0002 SA_BETA_WORLDDB_0002 = new SA_BETA_WORLDDB_0002())
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    SA_BETA_WORLDDB_0002.uspClearTradeAuthHistory(symNo, rv);
                    num = Convert.ToInt32(rv.Value);
                    string str = Convert.ToString(symNo.Value);
                    if (Convert.ToInt32(rv.Value) != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB ERROR]historyInit -  rv({0}) symNo({1})", (object)num, (object)str), "WARN");
                        return num;
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("[DB ERROR]uspClearTradeAuthHistory - Exception=" + ex.ToString(), "ERROR");
                return 1;
            }
            return num;
        }

        public static int noticeInfoInitByGame()
        {
            int num = 0;
            string empty = string.Empty;
            try
            {
                List<string> stringList = new List<string>();
                foreach (ConnectionStringSettings connectionString in (ConfigurationElementCollection)ConfigurationManager.ConnectionStrings)
                {
                    if (connectionString.Name.ToLower().IndexOf("SA_BETA_GAMEDB_0002") == 0)
                        stringList.Add(connectionString.Name);
                }
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                foreach (string name in stringList)
                {
                    using (SA_BETA_GAMEDB_0002 SA_BETA_GAMEDB_0002 = new SA_BETA_GAMEDB_0002(name))
                    {
                        SA_BETA_GAMEDB_0002.uspClearNoticeItemList(symNo, rv);
                        num = Convert.ToInt32(rv.Value);
                        string str = Convert.ToString(symNo.Value);
                        if (Convert.ToInt32(rv.Value) != 0)
                        {
                            LogUtil.WriteLog(string.Format("[DB ERROR]noticeInfoInitByGame{0} -  rv({1}) symNo({2})", (object)name, (object)num, (object)str), "WARN");
                            return num;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("[DB ERROR]uspClearNoticeItemList - Exception=" + ex.ToString(), "ERROR");
                return 1;
            }
            return num;
        }

        public static int noticeInfoInitByTrade()
        {
            int num = 0;
            string empty = string.Empty;
            try
            {
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    SA_BETA_TRADEDB_0002.uspClearNoticeItemList(symNo, rv);
                    num = Convert.ToInt32(rv.Value);
                    string str = Convert.ToString(symNo.Value);
                    if (Convert.ToInt32(rv.Value) != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB ERROR]noticeInfoInitByTrade -  rv({0}) symNo({1})", (object)num, (object)str), "WARN");
                        return num;
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("[DB ERROR]uspClearNoticeItemList - Exception=" + ex.ToString(), "ERROR");
                return 1;
            }
            return num;
        }

        public static void SendPearlAppAlarm(ref List<string> userIdList, int itemKey, string action)
        {
            if (!Convert.ToBoolean(PushUtil.EnableAppPushFlag))
                return;
            foreach (string str1 in userIdList)
            {
                try
                {
                    string str2 = "XB" == ConstantMgr._serviceType ? "XBOX" : ConstantMgr._serviceType;
                    SendAlarmModel sendAlarmModel = new SendAlarmModel()
                    {
                        topic = "TradeMarket|" + str2 + "|" + ConstantMgr._serviceRegion,
                        param = JsonConvert.SerializeObject((object)new AlarmTradeMarketModel()
                        {
                            Platform = str2,
                            Region = ConstantMgr._serviceRegion,
                            TargetUserId = str1,
                            ItemKey = itemKey,
                            Action = action
                        })
                    };
                    CommonModule.HttpRequestAsync(ConstantMgr._pearlAppDomain, JsonConvert.SerializeObject((object)sendAlarmModel), "POST", "text/json", true);
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog("Request PushAlarm Message Exception Error: " + ex.ToString(), "ERROR");
                }
            }
        }

        public static int updateWaitFail(waitItemModel model, long weight, DateTime currentTime)
        {
            int num = 0;
            string empty = string.Empty;
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter beforeCount1 = new ObjectParameter("beforeCount1", typeof(long));
            ObjectParameter afterCount1 = new ObjectParameter("afterCount1", typeof(long));
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    SA_BETA_TRADEDB_0002.uspUpdateWaitFail(new long?(model.waitNo), new long?(weight), beforeCount1, afterCount1, symNo, rv);
                    num = Convert.ToInt32(rv.Value);
                    string str = Convert.ToString(symNo.Value);
                    if (Convert.ToInt32(rv.Value) != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB ERROR]uspUpdateWaitFail -  rv({0}) symNo({1})", (object)num, (object)str), "WARN");
                        return num;
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("[DB ERROR]uspUpdateWaitFail - Exception=" + ex.ToString(), "ERROR");
                return 1;
            }
            WorldMarketLog.logWorldMarket(WorldMarketLog.OperationType.eWorldMarket_OperationType_Item, WorldMarketLog.ReasonType.eWorldMarket_ReasonType_SellWaitFailUpdate, currentTime, new CommonModel.TradeMarketUserLogInfo()
            {
                nationCode = model.nationCode,
                serverNo = model.worldNo,
                userNo = model.userNo
            }, new CommonModel.TradeMarketItemLogInfo()
            {
                keyType1 = model.sellKeyType,
                itemKey1 = model.sellMainKey,
                enchantLevel1 = model.sellSubKey,
                count1 = model.sellCount,
                beforeCount1 = Convert.ToInt64(beforeCount1.Value),
                afterCount1 = Convert.ToInt64(afterCount1.Value),
                keyType2 = 0,
                itemKey2 = 1,
                enchantLevel2 = 0,
                count2 = 0L
            }, param2: ((long)model.sellChooseKey), param3: Convert.ToInt64(model.isSealed), param5: 2L, param7: model.waitNo);
            return num;
        }

        public static int isOTPCheckItem(int keyType, int mainKey, int subKey, out bool result)
        {
            int num = 0;
            string empty = string.Empty;
            result = false;
            try
            {
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    ObjectParameter isOTPItem = new ObjectParameter("isOTPItem", typeof(bool));
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    SA_BETA_TRADEDB_0002.uspCheckOTPItem(new int?(keyType), new int?(mainKey), new int?(subKey), isOTPItem, symNo, rv);
                    num = Convert.ToInt32(rv.Value);
                    string str = Convert.ToString(symNo.Value);
                    if (Convert.ToInt32(rv.Value) != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB ERROR]uspCheckOTPItem -  rv({0}) symNo({1})", (object)num, (object)str), "WARN");
                        return num;
                    }
                    result = Convert.ToBoolean(isOTPItem.Value);
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("[DB ERROR]uspCheckOTPItem - Exception=" + ex.ToString(), "ERROR");
                return 1;
            }
            return num;
        }
    }
}
