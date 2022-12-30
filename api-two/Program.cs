var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api", () => "Hello Mario The Princess is in Castle 2!");

app.Run();
