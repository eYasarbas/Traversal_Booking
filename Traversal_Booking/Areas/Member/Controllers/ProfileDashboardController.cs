using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Areas.Member.Controllers;

[Area("Member")]
public class ProfileDashboardController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public ProfileDashboardController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        ViewBag.userName = values?.Name + " " + values?.SurName;
        ViewBag.userImage = values.ImageUrl;
        return View();
    }
}