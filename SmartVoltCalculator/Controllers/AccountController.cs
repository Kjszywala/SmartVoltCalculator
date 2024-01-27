using Microsoft.AspNetCore.Mvc;
using SmartVoltCalculator.Models.Account;

namespace SmartVoltCalculator.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult RegisterUser(RegisterViewModel model)
        {
            return View("Index");
        }
        
        [HttpPost]
        public IActionResult LoginUser(LoginViewModel model)
        {
            return View("Index");
        }
    }
}
