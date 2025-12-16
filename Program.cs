using DI.DTOs;
using DI.Interfaces;

var builder = WebApplication.CreateBuilder();
builder.Services.AddTransient<ITimeService, DevTimeTimeService>();

var app = builder.Build();
var timeService = app.Services.GetService<ITimeService>();

app.Run(async context =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync(timeService?.GetTime() ?? "Нет данных");
});

app.Run();