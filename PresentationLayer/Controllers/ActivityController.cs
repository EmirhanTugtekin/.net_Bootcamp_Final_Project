using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
	public class ActivityController : Controller
	{
        ActivityManager activityManager = new ActivityManager(new EfActivityRepository());
        public IActionResult Index()
		{
            var values = activityManager.GetList();
            return View(values);
        }
        public IActionResult ActivityReadAll(int id)
        {
            ViewBag.Id = id;
            var values = activityManager.GetActivityById(id);
            return View(values);
        }
	}
}
