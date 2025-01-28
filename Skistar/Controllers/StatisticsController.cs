using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Skistar.Services.Interfaces;
using Skistar.ViewModels;

namespace Skistar.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IStatisticsService _statisticsService;
        private readonly UserManager<IdentityUser> _userManager;

        public StatisticsController(IStatisticsService statisticsService, UserManager<IdentityUser> userManager)
        {
            _statisticsService = statisticsService;
            _userManager = userManager;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            //var model = await _statisticsService.GetUserStatistics();
            var model = new StatisticsViewModel();
            return View(model);
        }

        [Authorize(Roles = "admin")]
        //[Authorize]
        public async Task<IActionResult> Admin()
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = _userManager.GetUserId(User);




            var model = new RoleViewModel()
            {
                Role = "admin",
                UserId = userId
            };
            return View(model);
        }
    }
}
