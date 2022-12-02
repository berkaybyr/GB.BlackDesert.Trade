// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Controllers.ErrorController
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using EasMe;
using Microsoft.AspNetCore.Mvc;

namespace BlackDesert.TradeMarket.Trade.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ErrorController : Controller
    {
        public ErrorController(IHttpContextAccessor accessor)
        {
            IEasLog.ConfigureHttpContext(accessor);
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Error()
        {
            return StatusCode(500);
        }
        [HttpGet]
        public IActionResult Index(string? param)
        {
            return StatusCode(403);
        }
    }
}
