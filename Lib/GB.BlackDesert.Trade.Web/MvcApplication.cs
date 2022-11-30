// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.MvcApplication
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace GB.BlackDesert.Trade.Web
{
    public class MvcApplication : HttpApplication
    {
        private static object lockObj = new object();
        private static bool initialized = false;

        public override void Init()
        {
            base.Init();
            try
            {
                string str = "TradeMarket";
                if (string.IsNullOrEmpty(str))
                    return;
                foreach (string module1 in (NameObjectCollectionBase)this.Modules)
                {
                    if (this.Modules[module1] is SessionStateModule module2)
                    {
                        SessionStateStoreProviderBase storeProviderBase = (SessionStateStoreProviderBase)typeof(SessionStateModule).GetField("_store", BindingFlags.Instance | BindingFlags.NonPublic).GetValue((object)module2);
                        if (storeProviderBase == null)
                        {
                            HttpRuntime httpRuntime = (HttpRuntime)typeof(HttpRuntime).GetField("_theRuntime", BindingFlags.Static | BindingFlags.NonPublic).GetValue((object)null);
                            typeof(HttpRuntime).GetField("_appDomainAppId", BindingFlags.Instance | BindingFlags.NonPublic).SetValue((object)httpRuntime, (object)str);
                        }
                        else
                        {
                            Type type = storeProviderBase.GetType();
                            if (type.Name.Equals("OutOfProcSessionStateStore"))
                                type.GetField("s_uribase", BindingFlags.Static | BindingFlags.NonPublic).SetValue((object)type, (object)str);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("Global.asax Init Exception={0}", (object)ex.Message), "FATAL");
            }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            if (MvcApplication.initialized)
                return;
            lock (MvcApplication.lockObj)
            {
                if (MvcApplication.initialized)
                    return;
                LogUtil.WriteLog("Application_BeginRequest_InitializeOnceAsync Start", "INFO");
                MvcApplication.initialized = true;
                this.InitializeOnceAsync();
                LogUtil.WriteLog("Application_BeginRequest_InitializeOnceAsync Task Requested", "INFO");
            }
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        private Task InitializeOnceAsync() => Task.Run((Action)(() => this.InitializeOnce()));

        private void InitializeOnce()
        {
            if (ServerControlManager.This().Open(ServerType.eView, ConstantMgr._isTradeWebOpen) != 0)
                return;
            AuthenticateManager._servcerType = ServerType.eView;
            ServerControlManager.This().LoadComplete(ServerType.eView);
        }

        protected void Application_PreSendRequestHeaders()
        {
            MvcHandler.DisableMvcResponseHeader = true;
            this.Response.Headers.Remove("Server");
            this.Response.Headers.Remove("X-AspNetMvc-Version");
            this.Response.Headers.Remove("X-AspNet-Version");
            this.Response.Headers.Remove("X-Powered-By");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception lastError = this.Server.GetLastError();
            bool flag = string.Equals("XMLHttpRequest", this.Context.Request.Headers["x-requested-with"], StringComparison.OrdinalIgnoreCase);
            LogUtil.WriteLog(string.Format("Application_Error Exception={0} isAjaxCall = {1}", (object)lastError.ToString(), (object)flag), "FATAL");
            this.Response.Clear();
            this.Server.ClearError();
            this.Response.TrySkipIisCustomErrors = true;
            if (flag)
            {
                JsonResult jsonResult = new JsonResult()
                {
                    Data = (object)new
                    {
                        resultCode = -8745,
                        resultMsg = "/Error"
                    },
                    JsonRequestBehavior = (JsonRequestBehavior)0
                };
                this.Context.Response.ContentType = "application/json";
                this.Context.Response.StatusCode = 200;
                this.Context.Response.Write(JsonConvert.SerializeObject(jsonResult.Data));
            }
            else
            {
                if (HttpContext.Current.Request.Path.ToLower().IndexOf("/error/notfound") > -1)
                    return;
                this.Response.Status = "301 Moved Permanently";
                this.Response.AddHeader("Location", "/Error");
                this.Response.Redirect("/Error");
            }
        }

        public string GetHeaderProto() => HttpContext.Current.Request.Headers["X-Forwarded-Proto"] == null ? "https" : HttpContext.Current.Request.Headers["X-Forwarded-Proto"].ToString();
    }
}
