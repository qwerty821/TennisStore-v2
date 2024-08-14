using Microsoft.AspNetCore.Mvc;
using OnlineStore.Contracts;
using OnlineStore.Models.RacketsModels;
using OnlineStore.Services;
 

namespace OnlineShop.Controllers
{
    [Route("/api/[controller]")]
    public class RacketController : Controller
    {
        private readonly RacketService _racketService;

        public RacketController(RacketService racketService)
        {
            _racketService = racketService;
        }


        [Produces("application/json")]
        [HttpGet("get")]
        public  IActionResult GetOne(Guid id)
        {
            var r = _racketService.Get(id);
            if (r == null)
            {
                return BadRequest();
            }
            return new JsonResult(r);
        }

        [Produces("application/json")]
        [HttpGet("get/all")]
        public async Task<IActionResult> GetAll(FilterOptions? filterOptions)
        {
            var r = await _racketService.GetAll(filterOptions);
            if (r == null)
            {
                return BadRequest();
            }
            return new JsonResult(r);
        }

    }
}