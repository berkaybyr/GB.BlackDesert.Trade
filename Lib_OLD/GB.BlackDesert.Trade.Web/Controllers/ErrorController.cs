// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Controllers.ErrorController
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Models.Base;
using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Index(string param)
        {
            ErrorViewPageModel errorViewPageModel = new ErrorViewPageModel();
            if (!AuthenticateManager.IsAutheticated && string.IsNullOrEmpty(param))
                param = "Wallet";
            else if (string.IsNullOrEmpty(param))
                return this.View(nameof(Index));
            errorViewPageModel.type = param;
            if (!(param == "Mobile"))
            {
                if (!(param == "Browser"))
                {
                    if (param == "Wallet")
                        return this.View(param);
                    return param == "AGE" ? this.View(param) : this.View(nameof(Index));
                }
                errorViewPageModel.errorMessage = CommonModule.GetResourceValue("TRADE_MARKET_PC_BROWSER_NOT_ALLOW");
            }
            else
                errorViewPageModel.errorMessage = CommonModule.GetResourceValue("TRADE_MARKET_PC_BROWSER_ERROR");
            return this.View("Error", (object)errorViewPageModel);
        }
    }
}
