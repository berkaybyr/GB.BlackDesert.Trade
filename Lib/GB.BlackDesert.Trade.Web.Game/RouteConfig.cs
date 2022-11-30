// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.RouteConfig
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

using System.Web.Mvc;
using System.Web.Routing;

namespace GB.BlackDesert.Trade.Web.Game
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
