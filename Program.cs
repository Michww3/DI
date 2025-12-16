using DI.DTOs;
using DI.Interfaces;

var builder = WebApplication.CreateBuilder();
builder.Services.AddTransient<ITimeService, ShortTimeService>();

var app = builder.Build();
var timeService = app.Services.GetService<ITimeService>();

app.Run(async context =>
{
    await context.Response.WriteAsync($"Time: {timeService?.GetTime()}");
});

app.Run();