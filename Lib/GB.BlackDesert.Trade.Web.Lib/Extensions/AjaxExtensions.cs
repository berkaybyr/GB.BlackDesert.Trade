namespace BlackDesert.TradeMarket.Lib.Extensions
{
namespace GB.BlackDesert.Trade.Web.Api.Application;

public static class Extensions
{
    public static bool IsAjaxRequest(this HttpRequest request)
    {
        var val = request.Headers["X-Requested-With"].ToString();
        return val.Equals("XMLHttpRequest");
    }
}
}