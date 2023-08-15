using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
