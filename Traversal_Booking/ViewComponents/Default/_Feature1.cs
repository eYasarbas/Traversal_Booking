using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.ViewComponents.Default
{
	public class _Feature1 : ViewComponent
	{
		Feature1Manager feature1Manager =
			new Feature1Manager(new EfFeatureDal());
		public IViewComponentResult Invoke()
		{
			//var values = feature1Manager.TGetList();
			//ViewBag.
			return View();
		}
	}
}
