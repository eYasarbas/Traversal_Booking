using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Traversal_Booking.Areas.Member.Controllers;

[Area("Member")]
public class ReservationController : Controller
{
    private readonly DestinationManager _destinationManager = new(new EfDestinationDal());
    private readonly ReservationManager _reservationManager = new(new EfReservationDal());
    private readonly UserManager<AppUser> _userManager;

    public ReservationController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> MyCurrentReservation()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        var valuesList = _reservationManager.GetListWithReservationByWaitAccepted(values.Id);
        return View(valuesList);
    }

    public async Task<IActionResult> MyOldReservation()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        var valuesList = _reservationManager.GetListWithReservationByWaitPrevious(values.Id);
        return View(valuesList);
    }

    public async Task<IActionResult> MyApprovalReservation()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        var valuesList = _reservationManager.GetListWithReservationByWaitApproval(values.Id);
        return View(valuesList);
    }

    [HttpGet]
    public IActionResult NewReservation()
    {
        List<SelectListItem> values = (from x in _destinationManager.TGetList()
                                       select new SelectListItem
                                       {
                                           Text = x.Ctiy,
                                           Value = x.DestinationID.ToString()
                                       }
            ).ToList();

        ViewBag.Destination = values;

        return View();
    }


    [HttpPost]
    public IActionResult NewReservation(Reservation reservation)
    {
        reservation.AppUserId = 1;
        reservation.Status = "Wait Check";
        _reservationManager.TAdd(reservation);
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            ViewBag.Errors = errors;

            return View();
        }

        return RedirectToAction(nameof(MyCurrentReservation));
    }
}