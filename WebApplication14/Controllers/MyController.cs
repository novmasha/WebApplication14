using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication14.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from the API!");
        }
    }
}
