using Microsoft.AspNetCore.Mvc;

namespace TennisStoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return new JsonResult(new string[] { "111" });
        }
        [HttpGet("2")]
        public IActionResult Index2()
        {
            return NotFound();
        }
    }
}
