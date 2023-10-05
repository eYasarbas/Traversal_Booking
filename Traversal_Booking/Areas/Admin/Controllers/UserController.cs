using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Areas.Admin.Controllers;

[Area("Admin")]
public class UserController : Controller
{
    private readonly IAppUserService _appUserService;

    public UserController(IAppUserService appUserService)
    {
        _appUserService = appUserService;
    }

    public IActionResult Index()
    {
        var values = _appUserService.TGetList();
        return View(values);
    }

    public IActionResult Delete(int id)
    {
        var values = _appUserService.TGetById(id);
        _appUserService.TDelete(values);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult EditUser(int id)
    {
        var values = _appUserService.TGetById(id);
        return View(values);
    }

    [HttpPost]
    public IActionResult EditUser(AppUser appUser)
    {
        _appUserService.TUpdate(appUser);
        return RedirectToAction(nameof(Index));
    }
    public IActionResult CommentUser(int id)
    {
        var values = _appUserService.TGetList();
        return View(values);
    }
    public IActionResult ReservationUser()
    {
        var values = _appUserService.TGetList();
        return View(values);
    }
}