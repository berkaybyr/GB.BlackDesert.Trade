// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.Controllers.ErrorController
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

using System.Net;
using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.Process.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index() => (ActionResult)new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
    }
}
