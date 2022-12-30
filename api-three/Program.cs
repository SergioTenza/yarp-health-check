var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api", () => "Hello Mario The Princess is in Castle 3!");

app.Run();
