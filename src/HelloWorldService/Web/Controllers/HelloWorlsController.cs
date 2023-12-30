using Microsoft.AspNetCore.Mvc;

using HelloWorldService.Application.Services;
using HelloWorldService.Domain.Interfaces;
namespace HelloWorldService.Web.Controllers;

[Route("api/v1/hws")]
public class HelloWorldController : ControllerBase
{
    private readonly ILogger<HelloWorldController> _logger;
    private readonly IHelloWorldService _helloWorldService;
    public HelloWorldController(ILogger<HelloWorldController> logger, IHelloWorldService helloWorldService){
        _logger = logger;
        _helloWorldService = helloWorldService;
    }

    /// <summary>
    /// Hello world reponse endpoint 
    /// </summary>
    /// <response code="200">If operation succeeded</response>
    /// <return>Returns awaitable task</return>
    [HttpGet]
    [Produces("application/json")]
    public async Task<IActionResult> GetUploadBlobsMetainformation()
    {
        var jsonMessage = new { message = _helloWorldService.GetHelloWorldMessage() };
        return await Task.FromResult(StatusCode(200, jsonMessage));
    }
}
