// <copyright file="HelloWorlsController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using HelloWorldService.Application.Services;
using HelloWorldService.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldService.Web.Controllers;

[Route("api/v1/hws")]
public class HelloWorldController : ControllerBase
{
    private readonly ILogger<HelloWorldController> logger;
    private readonly IHelloWorldService helloWorldService;

    public HelloWorldController(ILogger<HelloWorldController> logger, IHelloWorldService helloWorldService)
    {
        this.logger = logger;
        this.helloWorldService = helloWorldService;
    }

    /// <summary>
    /// Hello world reponse endpoint.
    /// </summary>
    /// <response code="200">If operation succeeded.</response>
    /// <return>Returns awaitable task.</return>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    [HttpGet]
    [Produces("application/json")]
    public async Task<IActionResult> GetUploadBlobsMetainformation()
    {
        var jsonMessage = new { message = this.helloWorldService.GetHelloWorldMessage() };
        return await Task.FromResult(this.StatusCode(200, jsonMessage));
    }
}
