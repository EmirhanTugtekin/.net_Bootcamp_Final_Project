using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PresentationLayer.Controllers
{
    [AllowAnonymous]
	public class LoginController : Controller
	{
        UserManager userManager = new UserManager(new EfUserRepository());
        [HttpGet]
		public IActionResult Index()//for user
		{
			return View();
		}
		[HttpPost]
        public async Task<IActionResult> Index(User p)//for user
        {
            return View();
        }
        [HttpGet]
        public IActionResult LoginOrganizer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginOrganizer(Organizer p)
        {
            Context context = new Context();
            var datavalue = context.Organizers.FirstOrDefault(x => x.OrganizerMail == p.OrganizerMail && x.OrganizerPassword == p.OrganizerPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.OrganizerMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Organizer");
            }
            else
                return View();

        }

        [HttpGet]
        public IActionResult LoginCompany()
        {
            return View();
        }
        
    }
}
