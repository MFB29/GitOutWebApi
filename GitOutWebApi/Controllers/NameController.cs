using Microsoft.AspNetCore.Mvc;

namespace GitOutWebApi.Controllers;

// A Web API controller handles HTTP requests sent to its route.
// NameController answers GET /api/name with the developer's name.
// ASP.NET Core serializes the returned object to JSON automatically.
[ApiController]
[Route("api/[controller]")]
public class NameController : ControllerBase
{
    private const string DeveloperName = "Mason Foust";

    // Mason Foust
    [HttpGet]
    public IActionResult GetName()
    {
        return Ok(new { name = DeveloperName });
    }
}
