using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.ViewComponents.Default
{
    public class _Statistics :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var _context =new Context();
            ViewBag.v1 = _context.Set<Destination>().Count();
            ViewBag.v2 = _context.Set<Guide>().Count();
            ViewBag.v3 = "285";
            return View();
        }
    }
}
