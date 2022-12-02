// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Controllers.Auth.AuthCallbackController
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.DB;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Data.Entity.Core.Objects;
using System.IO;
using System.Net;
using System.Text;

using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.Controllers.Auth
{
    public class AuthCallbackController : Controller
    {
        public ActionResult Index(string callbackParam)
        {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            try
            {
                if (AuthenticateManager.IsAutheticated.Equals(true))
                    return (ActionResult)this.Redirect("/");
                bool flag1 = string.IsNullOrEmpty(callbackParam);
                if (flag1.Equals(true))
                {
                    LogUtil.WriteLog("AuthCallbackController Invalid Param", "WARN");
                    return (ActionResult)this.Redirect(ConstantMgr._authRedirectUri);
                }
                callbackParam = HttpUtility.UrlEncode(callbackParam);
                HttpWebRequest httpWebRequest;
                if (ConstantMgr._serviceType.ToUpper().Equals("CS") && ConstantMgr._serviceRegion.IsNotNull())
                    httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Format("{0}{1}&remoteIp={2}&region={3}", (object)ConstantMgr._authCheckRequestUri, (object)callbackParam, (object)CommonModule.GetRemoteIP(), (object)ConstantMgr._serviceRegion));
                else
                    httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Format("{0}{1}&remoteIp={2}", (object)ConstantMgr._authCheckRequestUri, (object)callbackParam, (object)CommonModule.GetRemoteIP()));
                httpWebRequest.Method = "GET";
                if (ConstantMgr._isUseProxy)
                    httpWebRequest.Proxy = (IWebProxy)new WebProxy(string.Format("{0}:{1}", (object)ConstantMgr._webProxyUrl, (object)ConstantMgr._webProxyPort))
                    {
                        BypassProxyOnLocal = false
                    };
                httpWebRequest.Timeout = 60000;
                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                if (!response.StatusCode.Equals((object)HttpStatusCode.OK))
                {
                    LogUtil.WriteLog("AuthCallbackController Invalid AuthToken Process", "WARN");
                    return (ActionResult)this.Redirect("/Error");
                }
                string end = new StreamReader(response.GetResponseStream(), Encoding.Default).ReadToEnd();
                flag1 = string.IsNullOrEmpty(end);
                if (flag1.Equals(true))
                {
                    LogUtil.WriteLog(string.Format("AuthCallbackController Invalid / Param={0} / Response={1}", (object)callbackParam, (object)end), "WARN");
                    return (ActionResult)this.Redirect("/Error");
                }
                string str = end.Replace("\"", "");
                int int32_1 = Convert.ToInt32(str.Split('|')[0]);
                if (int32_1 != 0)
                {
                    if (CookieLib.GetCookie("tradeRegion").IsNotNullOrEmpty())
                        CookieLib.Delete(ConstantMgr._cookieDomain, "tradeRegion");
                    if (int32_1 == 72)
                        return (ActionResult)this.Redirect("/Error?param=AGE");
                    if (int32_1 == 73)
                    {
                        LogUtil.WriteLog(string.Format("AuthCallbackController Security IP ADDRESS Difference / Param={0} / ResultCode={1}", (object)callbackParam, (object)int32_1), "WARN");
                        return (ActionResult)this.Redirect("/Error");
                    }
                    LogUtil.WriteLog(string.Format("AuthCallbackController Invalid Result / Param={0} / ResultCode={1}", (object)callbackParam, (object)int32_1), "WARN");
                    return (ActionResult)this.Redirect("/Error");
                }
                string userId = str.Split('|')[1];
                bool flag2;
                if (Array.IndexOf<string>(ConstantMgr._isUseSecondPwd.Split('|'), ConstantMgr._serviceType.ToUpper()) > -1)
                {
                    if (str.Split('|').Length > 2)
                        flag2 = Convert.ToBoolean(str.Split('|')[2]);
                    else
                        flag2 = true;
                }
                else
                    flag2 = true;
                AuthenticationInfo AuthenticationInfo = new AuthenticationInfo();
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    ObjectParameter userNo = new ObjectParameter("userNo", typeof(string));
                    ObjectParameter userNickName = new ObjectParameter("userNickName", typeof(string));
                    ObjectParameter serviceType = new ObjectParameter("serviceType", typeof(int));
                    ObjectParameter worldNo = new ObjectParameter("worldNo", typeof(int));
                    ObjectParameter valuepackage = new ObjectParameter("valuepackage", typeof(DateTime));
                    ObjectParameter addWeightBuff = new ObjectParameter("addWeightBuff", typeof(DateTime));
                    ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
                    ObjectParameter resultMsg = new ObjectParameter("resultMsg", typeof(string));
                    tradeWebDb.uspGetMyWalletInfo(userId, userNo, userNickName, serviceType, worldNo, valuepackage, addWeightBuff, resultCode, resultMsg);
                    int int32_2 = Convert.ToInt32(resultCode.Value);
                    LogUtil.WriteLog(string.Format("AuthCallback AuthToken={0} / UserID={1} / resultCode={2}", (object)callbackParam, (object)userId, (object)int32_2), "DEBUG");
                    flag1 = int32_2.Equals(0);
                    if (flag1.Equals(false))
                    {
                        if (CookieLib.GetCookie("tradeRegion").IsNotNullOrEmpty())
                            CookieLib.Delete(ConstantMgr._cookieDomain, "tradeRegion");
                        LogUtil.WriteLog(string.Format("AuthCallbackController Check UserInfo Error ResultCode={0} // Token={1}", (object)int32_2, (object)callbackParam), "WARN");
                        return (ActionResult)this.Redirect("/Error?param=Wallet");
                    }
                    if (Convert.ToInt64(userNo.Value) == 0L)
                    {
                        if (CookieLib.GetCookie("tradeRegion").IsNotNullOrEmpty())
                            CookieLib.Delete(ConstantMgr._cookieDomain, "tradeRegion");
                        return (ActionResult)this.Redirect("/Error?param=Wallet");
                    }
                    AuthenticationInfo.accountNo = Convert.ToInt64(userNo.Value);
                    AuthenticationInfo.AuthExpiration = CommonModule.GetCustomTime().AddMinutes((double)ConstantMgr._authenticationTimeOut);
                    AuthenticationInfo.LoginIP = CommonModule.GetRemoteIP();
                    AuthenticationInfo.LoginTime = CommonModule.GetCustomTime();
                    if (ConstantMgr._publishServiceType.ToLower() == "kr")
                    {
                        string[] strArray = str.Split('|');
                        AuthenticationInfo.publisherID = strArray.Length <= 2 ? "" : strArray[2];
                    }
                    AuthenticationInfo.userInfoModel = new UserInfomationModel()
                    {
                        _userNo = AuthenticationInfo.accountNo,
                        _nationCode = Convert.ToInt32(serviceType.Value),
                        _worldNo = Convert.ToInt32(worldNo.Value),
                        _userNickName = Convert.ToString(userNickName.Value),
                        _valuePackageExpiration = Convert.ToDateTime(valuepackage.Value).AddHours((double)ConstantMgr._serviceUtcTime),
                        _addWeightBuffExpiration = Convert.ToDateTime(addWeightBuff.Value).AddHours((double)ConstantMgr._serviceUtcTime),
                        _secondPwdPass = flag2
                    };
                    AuthenticationInfo.accountNo = Convert.ToInt64(userId);
                }
                AuthenticateManager.Authenticate(AuthenticationInfo);
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("AuthCallbackController Exception : {0}", (object)ex.ToString()), "ERROR");
                return (ActionResult)this.Redirect("/Error");
            }
            return (ActionResult)this.RedirectToAction(nameof(Index), "Home");
        }

        [HttpPost]
        public ActionResult Logout()
        {
            CommonResult commonResult = new CommonResult();
            try
            {
                AuthenticateManager.RemoveAuthTicket();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("Logout Exception : {0}", (object)ex.ToString()), "ERROR");
                commonResult.resultCode = -9999;
                commonResult.resultMsg = ex.ToString();
            }
            return !string.IsNullOrEmpty(ConstantMgr._authRemoveUri) ? (ActionResult)this.Redirect(ConstantMgr._authRemoveUri) : (ActionResult)this.Redirect(ConstantMgr._redirectDomain);
        }
    }
}
