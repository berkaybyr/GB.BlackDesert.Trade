using Microsoft.AspNetCore.Mvc;

namespace BlackDesert.TradeMarket.Process.Api.Controllers
{
namespace GB.BlackDesert.Trade.Web.Process.Api.Controllers;
public class HomeController : Controller
{
    [HttpGet]
    [Route("Contents/Common/xml/BDOWorldTradeMarketItemData/NA/BDOWorldMarketOptionInfo.xml")]
    public IActionResult Index()
    {
        return View();
    }
}
}