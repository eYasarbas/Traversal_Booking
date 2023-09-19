using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.ViewComponents.AdminDashboard;

public class _DashboardBanner : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}