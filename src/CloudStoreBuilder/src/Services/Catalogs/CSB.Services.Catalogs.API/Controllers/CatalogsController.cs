using Microsoft.AspNetCore.Mvc;

namespace CSB.Services.Catalogs.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CatalogsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCatalogs()
    {
        return Ok(nameof(GetCatalogs));
    }
}
