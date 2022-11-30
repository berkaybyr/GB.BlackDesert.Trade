// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.MvcApplication
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Collections.Specialized;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace GB.BlackDesert.Trade.Web.Game
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

        private Task InitializeOnceAsync() => Task.Run((Action)(() => this.InitializeOnce()));

        private void InitializeOnce()
        {
            if (ServerControlManager.This().Open(ServerType.eGame, ConstantMgr._isTradeWebOpen) != 0 || ServerControlManager.This().dataInit(ServerType.eGame) != 0 || ServerControlManager.This().TimerOpen(ServerType.eGame) != 0)
                return;
            AuthenticateManager._servcerType = ServerType.eGame;
            ServerControlManager.This().LoadComplete(ServerType.eGame);
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
