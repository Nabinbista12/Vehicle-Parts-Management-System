using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController: Controller
{
    [HttpPost("register")]
    public IActionResult Register()
    {
        return Empty;
    }
}