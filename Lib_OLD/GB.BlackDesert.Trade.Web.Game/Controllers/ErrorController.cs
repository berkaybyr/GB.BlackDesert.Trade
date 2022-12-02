// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Controllers.ErrorController
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

using System.Net;
using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.Game.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index() => (ActionResult)new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
    }
}
