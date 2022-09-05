using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.CompanyActivity
{
    public class CompanyActivity:ViewComponent
    {
        CompanyActivityManager companyActivityManager = new CompanyActivityManager(new EfCompanyActivityRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = companyActivityManager.GetList(id);
            return View(values);
        }
    }
}
