using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.ViewComponents.AdminDashboard;

public class _AdminDashboardHeader : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}