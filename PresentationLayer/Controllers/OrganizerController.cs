using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace PresentationLayer.Controllers
{
    public class OrganizerController : Controller
    {
        [Authorize(Roles = "Organizer")]
        public IActionResult Index()
        {
            return RedirectToAction("Index","Activity");
            
        }
    }
}
