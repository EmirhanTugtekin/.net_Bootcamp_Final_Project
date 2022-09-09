using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return RedirectToAction("Index", "Activity");
		}
	}
}
