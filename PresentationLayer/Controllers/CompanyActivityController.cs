﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CompanyActivityController : Controller
    {
        CompanyActivityManager companyManager = new CompanyActivityManager(new EfCompanyActivityRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AddCompanyToActivity()
        {
            return PartialView();
        }
        public PartialViewResult ListCompanyActivity(int id)
        {
            var values=companyManager.GetList(id);
            return PartialView(values);
        }

    }
}
