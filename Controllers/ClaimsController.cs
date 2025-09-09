using Microsoft.AspNetCore.Mvc;

namespace CMCS_POE_Part1.Controllers
{
    public class ClaimsController : Controller
    {
        // Lecturer's new claim form
        public IActionResult New()
        {
            return View();
        }

        // Lecturer's claim list / queue
        public IActionResult Index()
        {
            return View();
        }
    }
}
