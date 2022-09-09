using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace PresentationLayer.Controllers
{
    [Authorize(Roles = "User")]
    public class UserController : Controller
    {

        UserActivityManager userActivityManager = new UserActivityManager(new EfUserActivityRepository());
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Activity");
        }
        public IActionResult MyActivities(int id)
        {
            var values = userActivityManager.GetListWithEverything(id);
            return View(values);
        }
    }
}
