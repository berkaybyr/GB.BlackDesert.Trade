// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.AuthenticateManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.DB;
using GB.BlackDesert.Trade.Web.Lib.Manager.Auth;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public class AuthenticateManager
    {

        private static readonly HttpContext httpContext = new HttpContextAccessor().HttpContext;
        public static ServerType _servcerType = ServerType.eCount;

        public static bool IsAutheticated
        {
            get
            {
                bool isAutheticated = false;
                if (!ConstantMgr._isPaAccount)
                {
                    AuthenticationInfo authenticationInfo = AuthenticateManager.GetAuthenticationInfo();
                    if (authenticationInfo != null)
                    {
                        if (authenticationInfo.AuthExpiration > CommonModule.GetCustomTime())
                        {
                            isAutheticated = true;
                        }
                        else
                        {
                            isAutheticated = false;
                            AuthenticateManager.RemoveAuthTicket();
                        }
                    }
                }
                else if (AuthenticateManager.NewGetAuthenticationInfo() != null)
                    isAutheticated = true;
                return isAutheticated;
            }
        }

        public static void Authenticate(AuthenticationInfo AuthenticationInfo)
        {
            string empty = string.Empty;
            try
            {
                string str = new SecurityLib().Encrypt(CommonModule.SerializeObjectToJsonString<AuthenticationInfo>(AuthenticationInfo), SecurityMgr.Enum.Des);
                httpContext.Session.Set(ConstantMgr._authCookieName,Encoding.Default.GetBytes(str));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("AuthenticateManager Authenticate Exception Error=" + ex.ToString(), "ERROR");
            }
        }

        public static void SetAuthenticationInfo(GetSessionInfoResultModel sessionInfo)
        {
            string empty = string.Empty;
            try
            {
                string str = new SecurityLib().Encrypt(CommonModule.SerializeObjectToJsonString<GetSessionInfoResultModel>(sessionInfo), SecurityMgr.Enum.AES);
                httpContext.Session.Set(ConstantMgr._authCookieName, Encoding.Default.GetBytes(str));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[AuthenticateManager][New Authenticate][Exception][ERROR] {0}", (object)ex), "ERROR");
            }
        }

        public static void RemoveAuthTicket()
        {

            httpContext.Session.Remove(ConstantMgr._authCookieName);
            httpContext.Session.Clear();
            CookieLib.Delete(ConstantMgr._cookieDomain, "ASP.NET_SessionId");
        }

        public static AuthenticationInfo GetAuthInfo() => ConstantMgr._isPaAccount ? AuthenticateManager.NewGetAuthenticationInfo() : AuthenticateManager.GetAuthenticationInfo();

        private static AuthenticationInfo GetAuthenticationInfo()
        {
            AuthenticationInfo authenticationInfo = (AuthenticationInfo)null;
            string str = string.Empty;
            try
            {
                if (httpContext.Session.TryGetValue(ConstantMgr._authCookieName, out var bytes))
                {

                    str = Encoding.Default.GetString(bytes);
                    if (!string.IsNullOrEmpty(str))
                    {
                        str = new SecurityLib().Decrypt(str, SecurityMgr.Enum.Des);
                        authenticationInfo = CommonModule.DeserializeOjectToJson<AuthenticationInfo>(str);
                        if (authenticationInfo != null)
                        {
                            if (authenticationInfo.AuthExpiration < CommonModule.GetCustomTime())
                            {
                                authenticationInfo = (AuthenticationInfo)null;
                                AuthenticateManager.RemoveAuthTicket();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("Authenticatemanager GetAuthenticationInfo authTicket : " + str + " \n Exception : " + ex.ToString(), "ERROR");
                authenticationInfo = (AuthenticationInfo)null;
                AuthenticateManager.RemoveAuthTicket();
            }
            return authenticationInfo;
        }

        private static AuthenticationInfo NewGetAuthenticationInfo()
        {
            DateTime minValue1 = DateTime.MinValue;
            DateTime minValue2 = DateTime.MinValue;
            DateTime minValue3 = DateTime.MinValue;
            DateTime minValue4 = DateTime.MinValue;
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            string empty3 = string.Empty;
            bool flag = false;
            try
            {
                if (!httpContext.Session.TryGetValue(ConstantMgr._authCookieName, out var bytes))
                    return (AuthenticationInfo)null;
                string absolutePath = httpContext.Request.Path;
                var sessionVal = Encoding.Default.GetString(bytes);
                GetSessionInfoResultModel json1 = CommonModule.DeserializeOjectToJson<GetSessionInfoResultModel>(new SecurityLib().Decrypt(sessionVal, SecurityMgr.Enum.AES));
                DateTime dateTime1 = Convert.ToDateTime(json1._expireDate);
                DateTime customTime = CommonModule.GetCustomTime();
                if (!json1._isPearlApp)
                {
                    if (dateTime1 < customTime)
                    {
                        AuthenticateManager.RemoveAuthTicket();
                        return (AuthenticationInfo)null;
                    }
                    if (dateTime1.AddMinutes(-10.0) < customTime && customTime < dateTime1)
                    {
                        absolutePath = httpContext.Request.Path;
                        UseRefreshtokenModel deserializeObject = new UseRefreshtokenModel();
                        deserializeObject._refreshtoken = json1._refreshToken;
                        HttpRequestResult httpRequestResult1 = CommonModule.HttpRequest(new HttpRequestModel(ConstantMgr._apiBaseOauthUrl + "/Authorize/RefreshToken", CommonModule.SerializeObjectToJsonString<UseRefreshtokenModel>(deserializeObject), "POST", "application/json"));
                        if (httpRequestResult1._resultCode != 0)
                        {
                            LogUtil.WriteLog(string.Format("{0} UseRefreshtoken request fail resultCode={1}", (object)absolutePath, (object)httpRequestResult1._resultCode), "WARN");
                            return (AuthenticationInfo)null;
                        }
                        if (string.IsNullOrEmpty(httpRequestResult1._resultData))
                        {
                            LogUtil.WriteLog(absolutePath + " UseRefreshtoken resultdata is empty", "WARN");
                            return (AuthenticationInfo)null;
                        }
                        AccessTokenResultModel json2 = CommonModule.DeserializeOjectToJson<AccessTokenResultModel>(httpRequestResult1._resultData);
                        HttpRequestResult httpRequestResult2 = CommonModule.HttpRequest(new HttpRequestModel(ConstantMgr._apiBaseOauthUrl + "/Authorize/GetSessionInfo", CommonModule.SerializeObjectToJsonString<GetSessionInfoParamModel>(new GetSessionInfoParamModel()
                        {
                            _accessToken = json2.access_token
                        }), "POST", "application/json"));
                        if (httpRequestResult2._resultCode != 0)
                        {
                            LogUtil.WriteLog(string.Format("{0} GetSessionInfo request fail resultCode={1}", (object)absolutePath, (object)httpRequestResult2._resultCode), "WARN");
                            return (AuthenticationInfo)null;
                        }
                        if (string.IsNullOrEmpty(httpRequestResult2._resultData))
                        {
                            LogUtil.WriteLog(absolutePath + " GetSessionInfo resultdata is empty", "WARN");
                            return (AuthenticationInfo)null;
                        }
                        json1 = CommonModule.DeserializeOjectToJson<GetSessionInfoResultModel>(httpRequestResult2._resultData);
                        json1._accessToken = json2.access_token;
                        json1._refreshToken = json2.refresh_token;
                        GetSessionInfoResultModel sessionInfoResultModel = json1;
                        DateTime dateTime2 = CommonModule.GetCustomTime();
                        dateTime2 = dateTime2.AddMilliseconds((double)json2.expires_in);
                        string str = dateTime2.ToString("yyyy-MM-dd HH:mm:ss");
                        sessionInfoResultModel._expireDate = str;
                        AuthenticateManager.SetAuthenticationInfo(json1);
                    }
                }
                TimeSpan timeSpan = CommonModule.GetCustomTime() - json1._sessionSearchTime;
                if (string.IsNullOrEmpty(json1._authTicket) || 1.0 <= timeSpan.TotalSeconds)
                {
                    string remoteIp = CommonModule.GetRemoteIP();
                    GetSessionAuthTicketParamModel deserializeObject = new GetSessionAuthTicketParamModel()
                    {
                        _accountNo = json1._accountNo,
                        _sessionID = json1._sessionId,
                        _ip = remoteIp
                    };
                    HttpRequestResult httpRequestResult = CommonModule.HttpRequest(
                        new HttpRequestModel(ConstantMgr._paSessionApiUrl + "/session/getAuthticket", 
                        CommonModule.SerializeObjectToJsonString<GetSessionAuthTicketParamModel>(deserializeObject), 
                        "POST", 
                        "application/json",
                        "utf-8"));
                    if (httpRequestResult._resultCode != 0)
                    {
                        LogUtil.WriteLog(string.Format("[Authenticatemanager][GetNewAuthenticationInfo][SessionAPIRequest][ERROR] {0}", (object)httpRequestResult._resultCode), "WARN");
                        AuthenticateManager.RemoveAuthTicket();
                        return (AuthenticationInfo)null;
                    }
                    GetSessionAuthTicketResultModel json3 = CommonModule.DeserializeOjectToJson<GetSessionAuthTicketResultModel>(httpRequestResult._resultData);
                    if (json3 == null || string.IsNullOrEmpty(json3._authTicket))
                    {
                        LogUtil.WriteLog("[Authenticatemanager][GetNewAuthenticationInfo][GetSessionAuthTicket][ERROR]", "WARN");
                        AuthenticateManager.RemoveAuthTicket();
                        return (AuthenticationInfo)null;
                    }
                    if (!json1._isPearlApp && new DateTime(json1._ipCheckTime).AddHours(1.0) < customTime)
                    {
                        if (!string.IsNullOrEmpty(json3._ip) && !remoteIp.Equals(new SecurityLib().Decrypt(json3._ip, SecurityMgr.Enum.AES)))
                        {
                            LogUtil.WriteLog("[Authenticatemanager][GetAuthenticationInfo] Ip not match", "WARN");
                            AuthenticateManager.RemoveAuthTicket();
                            return (AuthenticationInfo)null;
                        }
                        json1._ipCheckTime = customTime.Ticks;
                    }
                    json1._authTicket = json3._authTicket;
                    json1._sessionSearchTime = CommonModule.GetCustomTime();
                    AuthenticateManager.SetAuthenticationInfo(json1);
                }
                AuthModel json4 = CommonModule.DeserializeOjectToJson<AuthModel>(new SecurityLib().Decrypt(json1._authTicket, SecurityMgr.Enum.AES));
                if (json1.userInfoModel == null)
                {
                    if (ConstantMgr._isUseSecondPwd.Contains(ConstantMgr._serviceType))
                    {
                        if (json4._loginType == (byte)3)
                            flag = true;
                    }
                    else
                        flag = true;
                    switch (AuthenticateManager._servcerType)
                    {
                        case ServerType.eView:
                            ObjectParameter userNo = new ObjectParameter("userNo", typeof(string));
                            ObjectParameter userNickName = new ObjectParameter("userNickName", typeof(string));
                            ObjectParameter serviceType = new ObjectParameter("serviceType", typeof(int));
                            ObjectParameter worldNo = new ObjectParameter("worldNo", typeof(int));
                            ObjectParameter valuepackage = new ObjectParameter("valuepackage", typeof(DateTime));
                            ObjectParameter addWeightBuff = new ObjectParameter("addWeightBuff", typeof(DateTime));
                            ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
                            ObjectParameter resultMsg = new ObjectParameter("resultMsg", typeof(string));
                            using (TradeWebDB tradeWebDb = new TradeWebDB())
                                tradeWebDb.uspGetMyWalletInfo(json4._accountNo.ToString(), userNo, userNickName, serviceType, worldNo, valuepackage, addWeightBuff, resultCode, resultMsg);
                            int int32 = Convert.ToInt32(resultCode.Value);
                            if (int32 != 0)
                            {
                                LogUtil.WriteLog(string.Format("{0} NewGetAuthenticationInfo uspGetMyWalletInfo error {1}", (object)absolutePath, (object)int32), "WARN");
                                AuthenticateManager.RemoveAuthTicket();
                                return (AuthenticationInfo)null;
                            }
                            if (Convert.ToInt64(userNo.Value) == 0L)
                            {
                                LogUtil.WriteLog(absolutePath + " NewGetAuthenticationInfo userNo is zero", "WARN");
                                AuthenticateManager.RemoveAuthTicket();
                                return (AuthenticationInfo)null;
                            }
                            GetSessionInfoResultModel sessionInfoResultModel = json1;
                            UserInfomationModel userInfomationModel = new UserInfomationModel();
                            userInfomationModel._userNo = Convert.ToInt64(userNo.Value);
                            userInfomationModel._nationCode = Convert.ToInt32(serviceType.Value);
                            userInfomationModel._worldNo = Convert.ToInt32(worldNo.Value);
                            userInfomationModel._userNickName = Convert.ToString(userNickName.Value);
                            DateTime dateTime3 = Convert.ToDateTime(valuepackage.Value);
                            userInfomationModel._valuePackageExpiration = dateTime3.AddHours((double)ConstantMgr._serviceUtcTime);
                            dateTime3 = Convert.ToDateTime(addWeightBuff.Value);
                            userInfomationModel._addWeightBuffExpiration = dateTime3.AddHours((double)ConstantMgr._serviceUtcTime);
                            userInfomationModel._secondPwdPass = flag;
                            sessionInfoResultModel.userInfoModel = userInfomationModel;
                            AuthenticateManager.SetAuthenticationInfo(json1);
                            break;
                        case ServerType.eGame:
                            UserInfomationResultModel infomationResultModel1 = new UserInfomationResultModel();
                            GetWalletInfoModel getWalletInfoModel = new GetWalletInfoModel();
                            getWalletInfoModel._accountNo = json4._accountNo;
                            string errorMsg = string.Empty;
                            string relResult = string.Empty;
                            int num = CommonModule.HttpRequest(ConstantMgr._processDomain + "/GetMyWalletInfoProcess", JsonConvert.SerializeObject((object)getWalletInfoModel), "POST", "text/json", out relResult, out errorMsg);
                            if (num != 0)
                            {
                                LogUtil.WriteLog(string.Format("{0} [Http Error]NewGetAuthenticationInfo({1}) - HttpRequest NewGetAuthenticationInfo errorMsg : {2}", (object)absolutePath, (object)getWalletInfoModel._accountNo, (object)errorMsg), "WARN");
                                AuthenticateManager.RemoveAuthTicket();
                                return (AuthenticationInfo)null;
                            }
                            UserInfomationResultModel infomationResultModel2 = JsonConvert.DeserializeObject<UserInfomationResultModel>(relResult);
                            if (infomationResultModel2 == null)
                            {
                                LogUtil.WriteLog(string.Format("{0} [Http Error]NewGetAuthenticationInfo({1}) - HttpRequest NewGetAuthenticationInfo result : _result null, errorMsg : {2}", (object)absolutePath, (object)getWalletInfoModel._accountNo, (object)errorMsg), "WARN");
                                AuthenticateManager.RemoveAuthTicket();
                                return (AuthenticationInfo)null;
                            }
                            if (infomationResultModel2._result.resultCode != 0)
                            {
                                LogUtil.WriteLog(string.Format("{0} NewGetAuthenticationInfo  HttpRequest NewGetAuthenticationInfo resultCode : {1}", (object)absolutePath, (object)num), "WARN");
                                AuthenticateManager.RemoveAuthTicket();
                                return (AuthenticationInfo)null;
                            }
                            json1.userInfoModel = new UserInfomationModel()
                            {
                                _userNo = infomationResultModel2._userInfo._userNo,
                                _nationCode = infomationResultModel2._userInfo._nationCode,
                                _worldNo = infomationResultModel2._userInfo._worldNo,
                                _userNickName = infomationResultModel2._userInfo._userNickName,
                                _valuePackageExpiration = infomationResultModel2._userInfo._valuePackageExpiration,
                                _addWeightBuffExpiration = infomationResultModel2._userInfo._addWeightBuffExpiration,
                                _secondPwdPass = flag
                            };
                            AuthenticateManager.SetAuthenticationInfo(json1);
                            break;
                        default:
                            LogUtil.WriteLog(string.Format("{0} NewGetAuthenticationInfo serverType chech fail {1}", (object)absolutePath, (object)AuthenticateManager._servcerType), "WARN");
                            AuthenticateManager.RemoveAuthTicket();
                            return (AuthenticationInfo)null;
                    }
                }
                return new AuthenticationInfo()
                {
                    accountNo = json4._accountNo,
                    AuthExpiration = dateTime1,
                    LoginIP = CommonModule.GetRemoteIP(),
                    LoginTime = CommonModule.GetCustomTime(),
                    userInfoModel = json1.userInfoModel
                };
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("[Authenticatemanager][NewGetAuthenticationInfo][Exception][ERROR] " + ex.ToString(), "ERROR");
                AuthenticateManager.RemoveAuthTicket();
                return (AuthenticationInfo)null;
            }
        }

        //public static bool getValidateDomain(string url)
        //{
        //    if (string.IsNullOrEmpty(url))
        //        return false;
        //    foreach (string allKey in httpContext.Application.AllKeys)
        //    {
        //        int length = httpContext.Application[allKey].ToString().Length;
        //        if (url.Length >= length && url.Substring(0, length) == httpContext.Application[allKey].ToString())
        //            return true;
        //    }
        //    return false;
        //}

        public static bool IsAccetpRefererDomain(string url)
        {
            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(ConstantMgr._acceptRefererDomainList))
                return false;
            List<string> list = ((IEnumerable<string>)ConstantMgr._acceptRefererDomainList.Split('|')).ToList<string>();
            if (list == null || list.Count < 1)
                return false;
            foreach (string str in list)
            {
                if (url.IndexOf(str) > 0)
                    return true;
            }
            return false;
        }

        public static void SetPakageInfo(PakageAuthInfo pakageAuthInfo)
        {
            string empty = string.Empty;
            try
            {
                var str = new SecurityLib().Encrypt(CommonModule.SerializeObjectToJsonString<PakageAuthInfo>(pakageAuthInfo), SecurityMgr.Enum.Des); ;
                var bytes = Encoding.Default.GetBytes(str);
                httpContext.Session.Set("PakageAuth", bytes); 
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("AuthenticateManager PakageAuthInfoAuth Exception Error=" + ex.ToString(), "ERROR");
            }
        }

        public static PakageAuthInfo GetPakageInfo()
        {
            PakageAuthInfo pakageInfo = (PakageAuthInfo)null;
            string str = string.Empty;
            try
            {
                if (httpContext.Session.TryGetValue("PakageAuth", out var bytes))
                {
                    str = Encoding.Default.GetString(bytes);
                    if (!string.IsNullOrEmpty(str))
                    {
                        str = new SecurityLib().Decrypt(str, SecurityMgr.Enum.Des);
                        pakageInfo = CommonModule.DeserializeOjectToJson<PakageAuthInfo>(str);
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("Authenticatemanager pakageAuthInfo authTicket : " + str + " \n Exception : " + ex.ToString(), "ERROR");
                pakageInfo = (PakageAuthInfo)null;
                AuthenticateManager.RemoveAuthTicket();
            }
            return pakageInfo;
        }
    }
}
