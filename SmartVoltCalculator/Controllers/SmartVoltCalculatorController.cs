using Microsoft.AspNetCore.Mvc;

namespace SmartVoltCalculator.Controllers;

public class SmartVoltCalculatorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}