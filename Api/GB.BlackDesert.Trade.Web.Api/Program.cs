using GB.BlackDesert.Trade.Web.Api;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMvc();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddResponseCaching();
builder.Services.AddHttpContextAccessor();
builder.Services.AddLocalization(x => x.ResourcesPath = "Resources" );


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//var supportedCultures = new[]
//        {
//            new CultureInfo("en"),
//            new CultureInfo("tr"),
//            new CultureInfo("es"),
//        };
//app.UseRequestLocalization(x =>
//{
//    x.DefaultRequestCulture = new RequestCulture("en");
//    x.SupportedCultures = supportedCultures;
//    x.SupportedUICultures = supportedCultures;
//});

LogUtil.ConfigureLoggerConfigDebug("Trade");

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();


app.MapControllers();
app.UseResponseCaching();

TradeApplication.InitializeOnce();
app.Run();
