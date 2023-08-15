using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.ViewComponents.Default
{
	public class _SliderPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
