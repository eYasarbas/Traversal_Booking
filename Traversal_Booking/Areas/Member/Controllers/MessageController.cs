using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
