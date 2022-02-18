using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme);
var app = builder.Build();


app.MapGet("/", () => "Hello World!");



app.Run();
