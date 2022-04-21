var builder = WebApplication.CreateBuilder(args);
var host = "localhost";
var port = 8000;

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(port);
});

var app = builder.Build();
app.MapGet("/", () => "Hello World!");

Console.WriteLine($"Server is running on http://{host}:{port}");
app.Run();
