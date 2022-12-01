using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Mvc;

namespace GB.BlackDesert.Trade.Web.Api.Controllers
{
    public class IntroController : BaseController
    {

        public IntroController(IHttpContextAccessor accessor)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            return StatusCode(500);
            try
            {
                return ConstantMgr._serviceType.ToUpper().Equals("NA") || ConstantMgr._serviceType.ToUpper().Equals("GT") ? new ViewResult() : new RedirectToActionResult(nameof(Index), "Home", null);
            }
            catch
            {
                return new RedirectToActionResult(nameof(Index), "Home", null);
            }
        }
    }
}
