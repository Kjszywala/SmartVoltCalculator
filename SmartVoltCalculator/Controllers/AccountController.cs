using Microsoft.AspNetCore.Mvc;

namespace SmartVoltCalculator.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
