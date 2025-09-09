using Microsoft.AspNetCore.Mvc;

namespace CMCS_POE_Part1.Controllers
{
    public class ClaimsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
