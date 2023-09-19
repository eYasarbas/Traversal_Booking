using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.ViewComponents.AdminDashboard;

public class _Cards1Statistic : ViewComponent
{
    private readonly Context c = new();

    public IViewComponentResult Invoke()
    {
        ViewBag.v1 = c.Destinations.Count();
        ViewBag.v2 = c.Users.Count();
        return View();
    }
}