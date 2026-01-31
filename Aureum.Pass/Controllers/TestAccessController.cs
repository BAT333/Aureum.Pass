using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aureum.Pass.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class TestAccessController : ControllerBase
    {

        [HttpGet]
        [Authorize(Policy = "Access")]
        public IActionResult Get()
        {
            return Ok("Access 02");
        }
    }
}
