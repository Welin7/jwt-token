using JwtExample.Models;
using JwtExample.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<JwtService>();

var app = builder.Build();

app.MapGet("/", (JwtService service) => service.Create(new User(
    1,
    "Welington",
    "welington.dias@gmail.com",
    "Image",
    "123456",
    new[]
    {
        "Diamond"
    })));

app.Run();
