using Microsoft.AspNetCore.Mvc;

namespace Resto_Backend.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
