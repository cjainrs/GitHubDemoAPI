using Microsoft.AspNetCore.Mvc;

namespace GitHubDemoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Git Stash Demo");
        }
    }
}
    

