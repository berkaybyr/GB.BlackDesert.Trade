using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Mvc;


namespace BlackDesert.TradeMarket.Game.Api.Controllers
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
