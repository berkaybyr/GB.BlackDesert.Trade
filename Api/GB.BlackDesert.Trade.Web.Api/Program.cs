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

builder.Services.AddDistributedMemoryCache();
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
app.UseSession();




app.UseHttpsRedirection();

app.UseCookiePolicy();

app.UseAuthentication();
app.UseAuthorization();



app.MapControllers();

LogUtil.ConfigureLoggerConfigDebug("Trade");
TradeApplication.InitializeOnceAsync();
app.Run();