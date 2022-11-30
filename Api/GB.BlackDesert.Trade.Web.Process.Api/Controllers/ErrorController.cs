using Microsoft.AspNetCore.Mvc;

namespace GB.BlackDesert.Trade.Web.Process.Api.Controllers
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
