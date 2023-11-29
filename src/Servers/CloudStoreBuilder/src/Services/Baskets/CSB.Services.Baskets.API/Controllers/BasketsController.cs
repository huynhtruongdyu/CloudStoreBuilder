using Microsoft.AspNetCore.Mvc;

namespace CSB.Services.Baskets.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BasketsController : ControllerBase {
    private readonly ILogger<BasketsController> _logger;

    public BasketsController(ILogger<BasketsController> logger) {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetBaskets() {
        _logger.LogInformation("hello world");
        _logger.LogCritical("Cristical");
        _logger.LogDebug("Debug");
        _logger.LogError("Error");
        _logger.LogTrace("Trace");
        _logger.LogWarning("Warning");
        return Ok(nameof(GetBaskets));
    }
}
