using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.ViewComponents.UserDashboard;

public class _GuideList : ViewComponent
{
    private GuideManager guideManager = new(new EfGuideDal());

    public IViewComponentResult Invoke()
    {
        var values = guideManager.TGetList();
        return View(values);
    }
}