using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        UserManager userManager = new UserManager(new EfUserRepository());
        
        [HttpGet]
        public IActionResult Index()//For user
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User p)
        {
            UserValidator userValidator = new UserValidator();
            ValidationResult results = userValidator.Validate(p);
            if (results.IsValid)
            {
                p.IsActive = true;
                //p.RoleId = 1;
                userManager.AddUser(p);
                return RedirectToAction("Index", "Activity");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        [HttpGet]
        public IActionResult RegisterOrganizer()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RegisterCompany()
        {
            return View();
        }
        
        
    }
}
