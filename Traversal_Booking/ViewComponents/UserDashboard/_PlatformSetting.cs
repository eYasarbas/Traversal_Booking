using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.ViewComponents.UserDashboard;

public class _PlatformSetting : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}