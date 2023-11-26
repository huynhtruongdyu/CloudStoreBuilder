using Microsoft.AspNetCore.Mvc;

namespace CSB.Services.Baskets.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BasketsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetBaskets()
    {
        return Ok(nameof(GetBaskets));
    }
}
