using Xunit;
using Moq;
using Microsoft.Extensions.Logging;

namespace HelloWorldService.ApplicationServiceTest
{
    public class HelloWorldServiceTests
    {
        [Fact]
        public void GetHelloWorldMessage_ReturnsHelloWorld()
        {
            var loggerMock = new Mock<ILogger<HelloWorldService.Application.Services.HelloWorldService>>();
            var helloWorldService = new HelloWorldService.Application.Services.HelloWorldService(loggerMock.Object);

            var result = helloWorldService.GetHelloWorldMessage();
            Assert.Equal("Hello from C# ASP .NET Core", result);
        }
    }
}
