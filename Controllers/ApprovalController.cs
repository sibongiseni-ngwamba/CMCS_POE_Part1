using Microsoft.AspNetCore.Mvc;

namespace CMCS_POE_Part1.Controllers
{
    public class ApprovalController : Controller
    {
        // GET: /Approval/PreApprove
        public IActionResult PreApprove()
        {
            return View();
        }

        // GET: /Approval/Approve
        public IActionResult Approve()
        {
            return View();
        }
    }
}
