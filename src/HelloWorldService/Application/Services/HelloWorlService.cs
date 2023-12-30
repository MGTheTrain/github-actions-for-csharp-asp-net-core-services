using Microsoft.Extensions.Logging;
using HelloWorldService.Domain.Interfaces;

namespace HelloWorldService.Application.Services
{
    public class HelloWorldService: IHelloWorldService
    {
        private readonly ILogger<HelloWorldService> _logger;

        public HelloWorldService(ILogger<HelloWorldService> logger)
        {
            _logger = logger;
        }

        public string GetHelloWorldMessage()
        {
            return "Hello from C# ASP .NET Core";
        }
    }
}
