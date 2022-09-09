using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        UserManager userManager = new UserManager(new EfUserRepository());
        OrganizerManager organizerManager = new OrganizerManager(new EfOrganizerRepository());
        CompanyManager companyManager = new CompanyManager(new EfCompanyRepository());  

        [HttpGet]
        public IActionResult Index()//For user
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User p)//For user
        {
            UserValidator userValidator = new UserValidator();
            ValidationResult results = userValidator.Validate(p);
            if (results.IsValid)
            {
                p.IsActive = true;
                userManager.AddT(p);
                return RedirectToAction("Index", "Login");
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
        [HttpPost]
        public IActionResult RegisterOrganizer(Organizer p)
        {
            OrganizerValidator organizerValidator = new OrganizerValidator();
            ValidationResult results = organizerValidator.Validate(p);
            if (results.IsValid)
            {
                p.IsActive = true;
                organizerManager.AddT(p);
                return RedirectToAction("LoginOrganizer", "Login");
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
        public IActionResult RegisterCompany()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterCompany(Company p)
        {
            CompanyValidator companyValidator = new CompanyValidator();
            ValidationResult results = companyValidator.Validate(p);
            if (results.IsValid)
            {
                companyManager.AddT(p);
                return RedirectToAction("LoginCompany", "Login");
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


    }
}
