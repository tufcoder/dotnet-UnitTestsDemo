using UnitTestsDemo.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServiceConfigurations(builder);

var app = builder.Build();

app.UseAppMiddleware();

app.Run();