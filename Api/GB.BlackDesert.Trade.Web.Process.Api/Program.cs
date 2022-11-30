using GB.BlackDesert.Trade.Web.Lib.Util;
using GB.BlackDesert.Trade.Web.Process.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();


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

ProcessApplication.InitializeOnce();
app.Run();
