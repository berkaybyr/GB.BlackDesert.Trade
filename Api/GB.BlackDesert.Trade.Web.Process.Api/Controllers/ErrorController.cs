using Microsoft.AspNetCore.Mvc;

namespace BlackDesert.TradeMarket.Process.Api.Controllers
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
