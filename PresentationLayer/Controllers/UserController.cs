using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace PresentationLayer.Controllers
{
    public class UserController : Controller
    {
        [Authorize(Roles = "User")]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Activity");
        }
        public IActionResult MyActivities()
        {
            return View();
        }
    }
}
