using Microsoft.AspNetCore.Mvc;

namespace GitOutAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { Name = "Your Name" });
        }
    }
}