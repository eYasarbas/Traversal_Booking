using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Areas.Member.Controllers
{
    public class ReservatiomController : Controller
    {
        [Area("Member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
