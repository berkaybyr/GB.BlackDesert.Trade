using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Mvc;

namespace GB.BlackDesert.Trade.Web.Game.Api.Controllers
{

    public class BaseController : Controller
    {
        
        public AuthenticationInfo _userinfo = AuthenticateManager.GetAuthInfo();
        private bool _isPakageCheck = CommonModule.CheckPakage();
    }
}
