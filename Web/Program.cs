using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.MapGet("/", () => "Hello World!");



app.Run();
