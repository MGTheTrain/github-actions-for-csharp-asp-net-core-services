using HelloWorldService.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IHelloWorldService, HelloWorldService.Application.Services.HelloWorldService>();
// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
