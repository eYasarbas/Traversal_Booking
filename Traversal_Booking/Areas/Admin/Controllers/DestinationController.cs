using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Areas.Admin.Controllers;

[Area("Admin")]
public class DestinationController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}