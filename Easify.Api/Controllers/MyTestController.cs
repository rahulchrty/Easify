using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Easify.Api.Controllers;

[ApiController]
[Route("api")]
public class MyTestController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public MyTestController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("test")]
    public async Task<IActionResult> RunTest()
    {
        await Task.Delay(0);
        return Ok("Hello and etc. etc.");
    }
}
