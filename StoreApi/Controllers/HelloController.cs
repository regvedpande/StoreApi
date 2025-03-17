using Microsoft.AspNetCore.Mvc;

namespace StoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from the StoreApi!");
        }
    }
}
