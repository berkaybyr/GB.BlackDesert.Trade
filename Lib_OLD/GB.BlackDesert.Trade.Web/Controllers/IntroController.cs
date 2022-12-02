// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Controllers.IntroController
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Manager;
using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.Controllers
{
    public class IntroController : BaseController
    {
        public ActionResult Index()
        {
            try
            {
                return ConstantMgr._serviceType.ToUpper().Equals("NA") || ConstantMgr._serviceType.ToUpper().Equals("GT") ? (ActionResult)this.View() : (ActionResult)this.RedirectToAction(nameof(Index), "Home");
            }
            catch
            {
                return (ActionResult)this.RedirectToAction(nameof(Index), "Home");
            }
        }
    }
}
