using System.Diagnostics;
using CMCS_POE_Part1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMCS_POE_Part1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Home
        public IActionResult Home()
        {
            ViewBag.Message = "Welcome to the Contract Monthly Claim System (Prototype)";
            return View();
        }
    }
}
