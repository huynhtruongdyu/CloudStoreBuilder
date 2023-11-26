using Microsoft.AspNetCore.Mvc;

namespace CSB.Services.Baskets.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BasketsController : ControllerBase {
    private ILogger<BasketsController> _logger;

    public BasketsController(ILogger<BasketsController> logger) {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetBaskets() {
        _logger.LogInformation("hello world");
        return Ok(nameof(GetBaskets));
    }
}
