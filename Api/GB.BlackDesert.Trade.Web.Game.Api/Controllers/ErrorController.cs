using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Mvc;


namespace GB.BlackDesert.Trade.Web.Game.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ErrorController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index() => StatusCode(500);
    }
}
