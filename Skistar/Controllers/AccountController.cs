using Microsoft.AspNetCore.Mvc;
using Skistar.ViewModels;

namespace Skistar.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {

            return View();
        }
    }
}
