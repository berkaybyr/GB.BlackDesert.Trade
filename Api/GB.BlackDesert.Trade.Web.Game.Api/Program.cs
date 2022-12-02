using EasMe.Extensions;
using EasMe;
using GB.BlackDesert.Trade.Web.Game.Api;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System.Reflection.Metadata;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



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

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseSession();




app.UseHttpsRedirection();

app.UseCookiePolicy();

app.UseAuthentication();
app.UseAuthorization();

app.Use((context, next) =>
{
    IEasLog.StaticLogger.Debug("Ip: " + context.Request.GetHeaderRealIPs().JsonSerialize() + "Header: " + context.Request.Headers.JsonSerialize());

    return next();
});


app.MapControllers();

LogUtil.ConfigureLoggerConfigDebug("Game");
GameApplication.InitializeOnceAsync();
app.Run();
