using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Areas.Member.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
