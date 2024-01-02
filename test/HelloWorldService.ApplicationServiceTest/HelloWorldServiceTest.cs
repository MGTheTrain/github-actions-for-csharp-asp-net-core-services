// <copyright file="HelloWorldServiceTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HelloWorldService.ApplicationServiceTest
{
    using Microsoft.Extensions.Logging;
    using Moq;
    using Xunit;

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
