using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Activity");
        }
    }
}
