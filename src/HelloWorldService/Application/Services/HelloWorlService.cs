// <copyright file="HelloWorlService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HelloWorldService.Application.Services
{
    using HelloWorldService.Domain.Interfaces;
    using Microsoft.Extensions.Logging;

    public class HelloWorldService : IHelloWorldService
    {
        private readonly ILogger<HelloWorldService> logger;

        public HelloWorldService(ILogger<HelloWorldService> logger)
        {
            this.logger = logger;
        }

        public string GetHelloWorldMessage()
        {
            return "Hello from C# ASP .NET Core";
        }
    }
}
