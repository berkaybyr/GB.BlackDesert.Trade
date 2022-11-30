using GB.BlackDesert.Trade.Web.Lib.Util;
using GB.BlackDesert.Trade.Web.Process.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

LogUtil.ConfigureLoggerConfigDebug("Process");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseSession();

//app.Use((context, next) =>
//{
//    context.Request.EnableBuffering();
//    return next();
//});

ProcessApplication.InitializeOnceAsync();
app.Run();
