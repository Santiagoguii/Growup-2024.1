using Microsoft.AspNetCore.Mvc;

namespace SistemaBiblioteca.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{

    [HttpGet]
    public IActionResult HelloWorld()
    {
        return  Ok("Hello World");
    }

}
