using Microsoft.AspNetCore.Mvc;

namespace CMCS_POE_Part1.Controllers
{
    public class TrackController : Controller
    {
        // GET: /Track
        public IActionResult Index()
        {
            return View();
        }
    }
}
