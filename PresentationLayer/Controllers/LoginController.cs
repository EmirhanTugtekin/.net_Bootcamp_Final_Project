using BusinessLayer.Abstract;
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


        //---------------------------------------------------------------------------------------------
        
        [HttpGet]
		public IActionResult Index()//for user
		{
			return View();
		}
		[HttpPost]
        public async Task<IActionResult> Index(User p)//for user
        {
            Context context = new Context();
            var datavalue = context.Users.FirstOrDefault(x => x.UserMail == p.UserMail && x.UserPassword == p.UserPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.UserMail),
                    new Claim(ClaimTypes.Role,"User")//rol verme
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "User");
            }
            else
                return View();
        }

        //------------------------------------------------------------------
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
                    new Claim(ClaimTypes.Name,p.OrganizerMail),
                    new Claim(ClaimTypes.Role,"Organizer")//rol verme
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Organizer");
            }
            else
                return View();

        }
        //------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult LoginCompany()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginCompany(Company p)
        {
            Context context = new Context();
            var datavalue = context.Companies.FirstOrDefault(x => x.CompanyMail == p.CompanyMail && x.CompanyPassword == p.CompanyPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.CompanyMail),
                };
                var useridentity = new ClaimsIdentity(claims, "A");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Company");
            }
            else
                return View();
        }
        //-------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult LoginAdmin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginAdmin(Admin p)
        {
            Context context = new Context();
            var datavalue = context.Admins.FirstOrDefault(x => x.AdminMail == p.AdminMail && x.AdminPassword == p.AdminPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.AdminMail),
                    new Claim(ClaimTypes.Role,"Admin")//rol verme
                };
                var useridentity = new ClaimsIdentity(claims, "A");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Admin");
            }
            else
                return View();
        }

    }
}
