// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Controllers.Auth.PearlabyssController
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib;
using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Manager.Auth;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GB.BlackDesert.Trade.Web.Api.Controllers.Auth
{
    //[ApiController]
    //[Route("[controller]/[action]")]
    public class PearlabyssController : BaseController
    {
        public PearlabyssController(IHttpContextAccessor accessor)
        {
            ContextAccess.Configure(accessor);
        }

        private string _path = "/Pearlabyss";

        [HttpGet]
        public RedirectResult Index()
        {
            this._path += "/Index";
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            string empty3 = string.Empty;
            string empty4 = string.Empty;
            try
            {
                if (!ConstantMgr._isPaAccount)
                {
                    LogUtil.WriteLog(string.Format("{0} serviceType not match {1}", (object)this._path, (object)ConstantMgr._serviceType), "WARN");
                    return this.Redirect("/Error");
                }
                if (AuthenticateManager.IsAutheticated)
                    return this.Redirect("/Home");
                string strMsg;
                string str;
                if (Request.Headers["uuid"].ToString() is not null)
                {
                    string header = HttpContext.Request.Headers["uuid"];
                    strMsg = string.Format("{0}|{1}|", (object)CommonModule.GetRandomString(), (object)header);
                    str = "pearlApp";
                }
                else
                {
                    strMsg = string.Format("{0}", (object)CommonModule.GetRandomString());
                    str = "profile";
                }
                string strCookieValue = WebUtility.UrlEncode(new SecurityLib().Encrypt(strMsg, SecurityMgr.Enum.AES));
                CookieLib.SetCookie(ConstantMgr._cookieDomain, ConstantMgr._oauthCookieName, strCookieValue);
                return this.Redirect(string.Format("{0}/Member/Login/AuthorizeOauth?response_type=code&scope={1}&state={2}&client_id=client_id&redirect_uri={3}/Pearlabyss/Oauth2CallBack", (object)ConstantMgr._accountDomain, (object)str, (object)strCookieValue, (object)ConstantMgr._tradeDomain));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("{0} Exception : {1}", (object)this._path, (object)ex.ToString()), "ERROR");
                return this.Redirect("/Error");
            }
        }

        [HttpPost]
        public ActionResult Oauth2CallBack(Oauth2CallBackModel model)
        {
            this._path += "/Oauth2CallBack";
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            string empty3 = string.Empty;
            string empty4 = string.Empty;
            try
            {
                if (!ModelState.IsValid)
                {
                    LogUtil.WriteLog("Oauth2CallBack modelstate not valid.", "WARN");
                    return (ActionResult)this.Redirect(string.Format("{0}/Error", (object)ConstantMgr._tradeDomain));
                }
                string str1 = new SecurityLib().Decrypt(WebUtility.UrlDecode(CookieLib.GetCookie(ConstantMgr._oauthCookieName)), SecurityMgr.Enum.AES);
                CookieLib.Delete(ConstantMgr._cookieDomain, ConstantMgr._oauthCookieName);
                string str2 = new SecurityLib().Decrypt(model.state, SecurityMgr.Enum.AES);
                if (!str1.Equals(str2))
                    LogUtil.WriteLog(string.Format("{0} state is not Matching. decCookieState={1} decModelState={2}", (object)this._path, (object)str1, (object)str2), "WARN");
                AccessTokenParamModel deserializeObject = new AccessTokenParamModel();
                deserializeObject._code = model.code;
                HttpRequestResult httpRequestResult1 = CommonModule.HttpRequest(new HttpRequestModel(string.Format("{0}/Authorize/AccessToken", (object)ConstantMgr._apiBaseOauthUrl), CommonModule.SerializeObjectToJsonString<AccessTokenParamModel>(deserializeObject), "POST", "application/json"));
                if (httpRequestResult1._resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("{0} GetAccesstoken request fail resultCode={1}", (object)this._path, (object)httpRequestResult1._resultCode), "WARN");
                    return (ActionResult)this.Redirect(string.Format("{0}/Error", (object)ConstantMgr._tradeDomain));
                }
                if (string.IsNullOrEmpty(httpRequestResult1._resultData))
                {
                    LogUtil.WriteLog(string.Format("{0} GetAccesstoken resultdata is empty", (object)this._path), "WARN");
                    return (ActionResult)this.Redirect(string.Format("{0}/Error", (object)ConstantMgr._tradeDomain));
                }
                AccessTokenResultModel json1 = CommonModule.DeserializeOjectToJson<AccessTokenResultModel>(httpRequestResult1._resultData);
                HttpRequestResult httpRequestResult2 = CommonModule.HttpRequest(new HttpRequestModel(string.Format("{0}/Authorize/GetSessionInfo", (object)ConstantMgr._apiBaseOauthUrl), CommonModule.SerializeObjectToJsonString<GetSessionInfoParamModel>(new GetSessionInfoParamModel()
                {
                    _accessToken = json1.access_token
                }), "POST", "application/json"));
                if (httpRequestResult2._resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("{0} GetSessionInfo request fail resultCode={1}", (object)this._path, (object)httpRequestResult2._resultCode), "WARN");
                    return (ActionResult)this.Redirect(string.Format("{0}/Error", (object)ConstantMgr._tradeDomain));
                }
                if (string.IsNullOrEmpty(httpRequestResult2._resultData))
                {
                    LogUtil.WriteLog(string.Format("{0} GetSessionInfo resultdata is empty", (object)this._path), "WARN");
                    return (ActionResult)this.Redirect(string.Format("{0}/Error", (object)ConstantMgr._tradeDomain));
                }
                GetSessionInfoResultModel json2 = CommonModule.DeserializeOjectToJson<GetSessionInfoResultModel>(httpRequestResult2._resultData);
                json2._accessToken = json1.access_token;
                json2._refreshToken = json1.refresh_token;
                json2._expireDate = CommonModule.GetCustomTime().AddMilliseconds((double)json1.expires_in).ToString("yyyy-MM-dd HH:mm:ss");
                json2._ipCheckTime = 0L;
                json2._isPearlApp = "pearlApp".Equals(json1.scope);
                AuthenticateManager.SetAuthenticationInfo(json2);
                return !AuthenticateManager.IsAutheticated ? (ActionResult)this.Redirect(string.Format("{0}/Error", (object)ConstantMgr._tradeDomain)) : (ActionResult)this.RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("{0} Exception : {1}", (object)this._path, (object)ex.ToString()), "ERROR");
                return (ActionResult)this.Redirect(string.Format("{0}/Error", (object)ConstantMgr._tradeDomain));
            }
        }

        [HttpGet]
        public ActionResult CheckPearlApp()
        {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            try
            {
                var current = HttpContext.Request;
                if (string.IsNullOrEmpty(current.Headers["accesstoken"]))
                    return (ActionResult)this.View();
                if (AuthenticateManager.IsAutheticated)
                    return (ActionResult)this.RedirectToAction("Index", "Home");
                PearlAppTokenModel json1 = CommonModule.DeserializeOjectToJson<PearlAppTokenModel>(SecurityLib.GetAES256DecryptFromUrlTokenEncode(CommonModule.DeserializeOjectToJson<PAAuthModel>(SecurityLib.GetAES256DecryptFromUrlTokenEncode(current.Headers["accesstoken"]).Split('|')[1]).Token));
                CheckAccessTokenModel deserializeObject = new CheckAccessTokenModel()
                {
                    _accessToken = json1._accessToken
                };
                HttpRequestResult httpRequestResult = CommonModule.HttpRequest(new HttpRequestModel(string.Format("{0}/Authorize/Check", (object)ConstantMgr._apiBaseOauthUrl), CommonModule.SerializeObjectToJsonString<CheckAccessTokenModel>(deserializeObject), "POST", "application/json"));
                if (httpRequestResult._resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("Check AccessToken response fail, accessToken : {0} / reulstCode : {1}", (object)json1._accessToken, (object)httpRequestResult._resultCode), "WARN");
                    return (ActionResult)this.View();
                }
                if (string.IsNullOrEmpty(httpRequestResult._resultData))
                {
                    LogUtil.WriteLog(string.Format("Check AccessToken resultdata is empt, accessToken : {0}y", (object)json1._accessToken), "WARN");
                    return (ActionResult)this.View();
                }
                CheckAccessToeknResultModel json2 = CommonModule.DeserializeOjectToJson<CheckAccessToeknResultModel>(httpRequestResult._resultData);
                if (json2 == null || json2._resultCode != 0)
                {
                    int num = json2 == null ? -99999 : json2._resultCode;
                    LogUtil.WriteLog(string.Format("AccessToken is not valid, accessToken : {0} / reulstCode : {1}", (object)json1._accessToken, (object)num), "WARN");
                }
                else
                {
                    AuthenticateManager.SetAuthenticationInfo(new GetSessionInfoResultModel()
                    {
                        _sessionId = json1._pearAppSessionInfoModel._sessionId,
                        _accountNo = json1._pearAppSessionInfoModel._accountNo,
                        _accessToken = json1._accessToken,
                        _refreshToken = json1._refreshToken,
                        _expireDate = json1._expireDate,
                        _ipCheckTime = 0L,
                        _isPearlApp = true
                    });
                    return (ActionResult)this.RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("CheckPearlApp Exception {0}", (object)ex.ToString()), "ERROR");
            }
            return (ActionResult)this.View();
        }
    }
}
