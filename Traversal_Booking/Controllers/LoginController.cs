using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}
		[HttpGet]
		public IActionResult SignIn()
		{
			return View();
		}
	}
}
