// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Controllers.MaintenanceController
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.DB;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.Controllers
{
    public class MaintenanceController : Controller
    {
        public ActionResult Index() => (ActionResult)this.View();

        public ActionResult WebMaintanace()
        {
            string cultureCode = ConstantMgr._defaultCulture;
            if (!string.IsNullOrEmpty(CookieLib.GetCookie("lang")))
                cultureCode = CookieLib.GetCookie("lang");
            uspGetShutDownCheckUseWeb_Result checkUseWebResult = new uspGetShutDownCheckUseWeb_Result();
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
                    checkUseWebResult = ((IEnumerable<uspGetShutDownCheckUseWeb_Result>)tradeWebDb.uspGetShutDownCheckUseWeb(cultureCode, resultCode)).FirstOrDefault<uspGetShutDownCheckUseWeb_Result>();
                    if (checkUseWebResult == null)
                        return (ActionResult)this.Redirect("/AuthCallback/Index");
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[DB ERROR]WebMaintanace Error uspGetShutDownCheckUseWeb cultureCode :  - ({0}) Exception={1}", (object)cultureCode, (object)ex.ToString()), "ERROR");
            }
            return (ActionResult)this.View((object)checkUseWebResult);
        }
    }
}
