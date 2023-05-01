using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILoggerManager _logger;
    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IEnumerable<string> Get()
    {
        _logger.LogInfo("Info message from controller.");
        _logger.LogWarn("Warn message from controller.");
        _logger.LogDebug("Debug message from controller.");
        _logger.LogError("Error message from controller.");

        return new string[] { "value1", "value2" };
    }
};