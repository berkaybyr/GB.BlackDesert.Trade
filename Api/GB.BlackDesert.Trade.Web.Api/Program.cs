using EasMe;
using EasMe.Extensions;
using GB.BlackDesert.Trade.Web.Api;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




builder.Services.AddMvc();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDistributedSqlServerCache(options =>
{
    options.ConnectionString = @"Data Source=144.76.119.8;Initial Catalog=SA_BETA_TRADEDB_0002;Integrated Security=True;User id=CrimsonDesert;Password=BlackNo.1Game#^%;";
    options.SchemaName = "dbo";
    options.TableName = "SQLSessions";
});

builder.Services.AddSession(options =>
{
    options.Cookie.Name = ConstantMgr._cookieDomain;
    options.IdleTimeout = TimeSpan.FromMinutes(1440);
    options.Cookie.IsEssential = true;
});
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();


builder.Services.AddHttpContextAccessor();

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.MinimumSameSitePolicy = SameSiteMode.None;
    options.Secure = CookieSecurePolicy.Always;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseCookiePolicy();

app.UseSession();

app.UseHttpsRedirection();


app.UseAuthentication();
app.UseAuthorization();


app.Use((context, next) =>
{
    IEasLog.StaticLogger.Debug("Ip: " + context.Request.GetHeaderRealIPs().JsonSerialize()  + "Header: "+ context.Request.Headers.JsonSerialize());

    context.Request.HttpContext.Session.SetString("TradeAuth_Session", "f2kya3tx2krrndieorbtotgn");
    context.Response.HttpContext.Session.SetString("TradeAuth_Session", "f2kya3tx2krrndieorbtotgn");
    context.Response.Cookies.Append("TradeAuth_Session", "f2kya3tx2krrndieorbtotgn");
    context.Request.Headers.Add("TradeAuth_Session", "f2kya3tx2krrndieorbtotgn");
    context.Response.Headers.Add("TradeAuth_Session", "f2kya3tx2krrndieorbtotgn");
    return next();
});
app.MapControllers();

LogUtil.ConfigureLoggerConfigDebug("Trade");
TradeApplication.InitializeOnceAsync();
app.Run();