using Microsoft.AspNetCore.Mvc;

namespace Demo01.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult HelloWorld()
    {
        return Ok("Hello World");
    }
    
    [HttpGet("[action]")]
    public IActionResult HelloWorld2()
    {
        return Ok("Hello World");
    }

}
