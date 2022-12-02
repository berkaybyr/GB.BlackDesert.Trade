// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.RouteConfig
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

using System.Web.Mvc;
using System.Web.Routing;

namespace GB.BlackDesert.Trade.Web.Process
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            RouteCollectionExtensions.IgnoreRoute(routes, "{resource}.axd/{*pathInfo}");
            RouteCollectionExtensions.MapRoute(routes, "Default", "{controller}/{action}/{id}", (object)new
            {
                controller = "Error",
                action = "Index",
                id = UrlParameter.Optional
            });
        }
    }
}
