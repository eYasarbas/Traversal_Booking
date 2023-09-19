using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.ViewComponents.AdminDashboard;

public class _TotalRevenue : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}