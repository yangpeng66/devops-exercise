var builder = WebApplication.CreateBuilder(args);
var bindPort = 8000;

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(bindPort);
});

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.Run();
