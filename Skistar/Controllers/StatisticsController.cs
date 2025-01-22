using Microsoft.AspNetCore.Mvc;
using Skistar.Services;
using Skistar.Services.Interfaces;
using Skistar.ViewModels;

namespace Skistar.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IStatisticsService _statisticsService;
        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _statisticsService.GetUserStatistics();
            return View(model);
        }
    }
}
