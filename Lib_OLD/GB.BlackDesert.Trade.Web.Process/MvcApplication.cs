// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.MvcApplication
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Threading.Tasks;

using System.Web.Mvc;
using System.Web.Routing;

namespace GB.BlackDesert.Trade.Web.Process
{
    public class MvcApplication : HttpApplication
    {
        private static object lockObj = new object();
        private static bool initialized = false;

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
            if (ServerControlManager.This().Open(ServerType.eProcess, ConstantMgr._isTradeWebOpen) != 0 || ServerControlManager.This().DataUpdateByRepository(ServerType.eProcess) != 0 || ServerControlManager.This().dataInit(ServerType.eProcess) != 0 || ServerControlManager.This().TimerOpen(ServerType.eProcess) != 0)
                return;
            ServerControlManager.This().LoadComplete(ServerType.eProcess);
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
            LogUtil.WriteLog(string.Format("Application_Error Exception={0}", (object)this.Server.GetLastError().ToString()), "FATAL");
            this.Response.Clear();
            this.Server.ClearError();
            this.Response.TrySkipIisCustomErrors = true;
            if (HttpContext.Current.Request.Path.ToLower().IndexOf("/error/notfound") > -1)
                return;
            this.Response.Status = "301 Moved Permanently";
            this.Response.AddHeader("Location", "/Error");
            this.Response.Redirect("/Error");
        }

        public string GetHeaderProto() => HttpContext.Current.Request.Headers["X-Forwarded-Proto"] == null ? "https" : HttpContext.Current.Request.Headers["X-Forwarded-Proto"].ToString();
    }
}
