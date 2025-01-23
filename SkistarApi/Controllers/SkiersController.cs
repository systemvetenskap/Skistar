using Microsoft.AspNetCore.Mvc;
using SkistarApi.Services.Interface;

namespace SkistarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkiersController : ControllerBase
    {
        private readonly ISkierService _skierService;

        public SkiersController(ISkierService skierService)
        {
            this._skierService = skierService;
        }

        [HttpGet("favorite")]
        public async Task<IActionResult> All()
        {
            var dto = await _skierService.GetMyFavoriteSkier(1);
            if (dto == null)
                return NoContent();

            return Ok(dto);
        }
    }
}
