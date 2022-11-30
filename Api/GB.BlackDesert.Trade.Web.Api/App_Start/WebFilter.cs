// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.App_Start.WebFilter
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Api.Application;
using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GB.BlackDesert.Trade.Web.Api.App_Start
{
    public class WebFilter : ActionFilterAttribute
    {
        public bool _isLogin;
        public bool _checkBlock;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string remoteIp = CommonModule.GetRemoteIP();
            CommonModule.GetCulture();
            var httpContext = filterContext.HttpContext;
            var request = httpContext.Request;
            var actionName = request.RouteValues["Controller"];
            var controllerName = request.RouteValues["Action"];
            string str = string.Empty;
            CommonModule.GetCustomTime();
            AuthenticationInfo authInfo = AuthenticateManager.GetAuthInfo();
            string empty = string.Empty;
            bool flag;
            if (ConstantMgr._isLive)
            {
                if (CommonModule.IsMobile.Equals(false))
                {
                    flag = CommonModule.IsAllowBrowser;
                    str = !flag.Equals(false) ? string.Empty : "Browser";
                }
                if (request.Headers["PAChecker"].ToString() is not null)
                {
                    string header = request.Headers["PAChecker"];
                    flag = string.IsNullOrEmpty(header);
                    if (flag.Equals(false) && header.Equals("PearlAbyss"))
                        CookieLib.SetCookie(ConstantMgr._cookieDomain, "ViewAgent", "APP");
                }
                flag = string.IsNullOrEmpty(str);
                if (flag.Equals(false))
                {
                    filterContext.Result = (ActionResult)new RedirectResult(string.Format("/Error?param={0}", (object)str));
                    base.OnActionExecuting(filterContext);
                    return;
                }
            }
            flag = string.IsNullOrEmpty(TradeModule.GetMaintenanceInfo());
            if (flag.Equals(false))
            {
                flag = CommonModule.CheckAllowIPAccess(remoteIp);
                if (flag.Equals(false))
                {
                    filterContext.Result = (ActionResult)new RedirectResult("/Maintenance");
                    base.OnActionExecuting(filterContext);
                    return;
                }
            }
            if (ConstantMgr._isLive)
            {
                flag = ConstantMgr._isTradeWebOpen;
                if (flag.Equals(false))
                {
                    flag = CommonModule.CheckAllowIPAccess(remoteIp);
                    if (flag.Equals(false))
                        filterContext.Result = (ActionResult)new RedirectResult("Error");
                }
            }
            if (TradeModule.getWebMaintanace())
            {
                flag = CommonModule.CheckAllowIPAccess(remoteIp);
                if (flag.Equals(false))
                {
                    filterContext.Result = (ActionResult)new RedirectResult("/Maintenance/WebMaintanace");
                    base.OnActionExecuting(filterContext);
                    return;
                }
            }
            if (this._isLogin.Equals(false) && (authInfo == null || authInfo.accountNo.Equals(0L)))
            {
                AuthenticateManager.RemoveAuthTicket();
                LogUtil.WriteLog(string.Format("WebFilter OnActionExecuting Error UserInformation is Empty. IPAddress={0} Controller={1} Action={2}", (object)remoteIp, (object)controllerName, (object)actionName), "WARN");
                if (!request.IsAjaxRequest())
                    return;
                filterContext.Result = (ActionResult)new JsonResult((object)new
                {
                    resultCode = 2000,
                    resultMsg = "TRADE_MARKET_ERROR_MSG_UNAUTHORIZED",
                    redirectUrl = ConstantMgr._authRedirectUri
                });
            }
            else
            {
                try
                {
                    flag = AuthenticateManager.IsAutheticated;
                    if (flag.Equals(true))
                    {
                        CommonResult commonResult = new CommonResult();
                        AuthenticateManager.GetAuthInfo();
                        if (!(ConstantMgr._publishServiceType.ToLower() == "jp"))
                        {
                            if (!(ConstantMgr._publishServiceType.ToLower() == "sa"))
                                goto label_30;
                        }
                        string cookie = CookieLib.GetCookie(ConstantMgr._serviceAuthCookieName);
                        if (string.IsNullOrEmpty(cookie))
                        {
                            try
                            {
                                AuthenticateManager.RemoveAuthTicket();
                                LogUtil.WriteLog(string.Format("Not Found TradeMarket Cookie Param / _gcAuthInfo={0}", (object)cookie), "WARN");
                            }
                            catch (Exception ex)
                            {
                                LogUtil.WriteLog(string.Format("Logout Exception : {0}", (object)ex.ToString()), "ERROR");
                                commonResult.resultCode = -9999;
                                commonResult.resultMsg = ex.ToString();
                            }
                            filterContext.Result = (ActionResult)new RedirectResult(ConstantMgr._authRedirectUri);
                            base.OnActionExecuting(filterContext);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("[Error]HomeController Index() Exception Error={0}", (object)ex.ToString()), "ERROR");
                }
            label_30:
                base.OnActionExecuting(filterContext);
            }
        }
    }
}
