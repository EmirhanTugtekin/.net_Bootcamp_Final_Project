using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
	public class LoginController : Controller
	{
        UserManager userManager = new UserManager(new EfUserRepository());
        [HttpGet]
		public IActionResult Index()//for user
		{
			return View();
		}
		[HttpPost]
        public IActionResult Index(User p)//for user
        {
            return View();
        }
        [HttpGet]
        public IActionResult LoginOrganizer()
        {
            return View();
        }
        [HttpGet]
        public IActionResult LoginCompany()
        {
            return View();
        }
        
    }
}
