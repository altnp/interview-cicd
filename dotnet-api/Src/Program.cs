using Api;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog();

var app = builder.Build();

app.MapGet("/api/echo", (string input, ILogger<Program> logger) =>
{
    logger.LogInformation("Request to echo {e}", input);
    var response = new Logic().Echo(input);
    return Results.Ok(response);
});

app.MapGet("/health", () => Results.Ok("healthy"));

app.Run();
