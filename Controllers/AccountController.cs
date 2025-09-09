using Microsoft.AspNetCore.Mvc;

namespace CMCS_POE_Part1.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/SignIn (no auth/validation, just navigate)
        [HttpPost]
        public IActionResult SignIn(string username, string password, string role)
        {
            // For prototype, ignore inputs and go to Home
            return RedirectToAction("Home", "Home");
        }

        // GET: /Account/Register (static mock page)
        public IActionResult Register()
        {
            return View();
        }
    }
}
