using Microsoft.AspNetCore.Mvc;

namespace Prototype_Sim.Controllers
{

    [ApiController]
    [Route("api/controller")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Working");
        }
    }
}
