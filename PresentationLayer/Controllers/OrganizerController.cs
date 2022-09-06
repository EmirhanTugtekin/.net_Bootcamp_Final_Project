using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class OrganizerController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index","Activity");
            
        }
    }
}
