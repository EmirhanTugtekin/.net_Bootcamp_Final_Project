using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    
	public class ActivityController : Controller
	{
        UserActivityManager userActivityManager = new UserActivityManager(new EfUserActivityRepository());
        ActivityManager activityManager = new ActivityManager(new EfActivityRepository());
        public IActionResult Index()
		{
            var values = activityManager.GetListWithCategory();
            return View(values);
        }
        public IActionResult ActivityReadAll(int id)
        {
            ViewBag.Id = id;
            var values = activityManager.GetListWithEverything(id);

            return View(values);
        }
        [HttpGet]
        public IActionResult AddActivity()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddActivity(Activity p)
        {
            p.IsActive = true;
            activityManager.AddT(p);
            return RedirectToAction("Index", "Activity");
        }
        public IActionResult JoinActivity()
        {
            return RedirectToAction("MyActivities", "User");
        }
        

    }
}
