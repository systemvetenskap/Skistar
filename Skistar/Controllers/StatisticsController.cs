using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Skistar.Services.Interfaces;

namespace Skistar.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IStatisticsService _statisticsService;
        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var model = await _statisticsService.GetUserStatistics();
            return View(model);
        }

        public async Task<IActionResult> Admin()
        {
            var model = await _statisticsService.GetUserStatistics();
            return View(model);
        }
    }
}
