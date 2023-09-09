using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Traversal_Booking.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class ReservationController : Controller
    {
        DestinationManager _destinationManager = new(new EfDestinationDal());
        ReservationManager _reservationManager = new(new EfReservationDal());
        public IActionResult MyCurrentReservation()
        {
            return View();
        }
        public IActionResult MyOldReservation()
        {
            return View();
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

            ViewBag.v = values;

            return View();
        }


        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            //if (!ModelState.IsValid)
            //{
            //    List<string> errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            //    ViewBag.Errors = errors;

            //    return View();
            //}

            reservation.AppUserId = 1;
            reservation.Status = "Wait Check";
            _reservationManager.TAdd(reservation);

            return RedirectToAction(nameof(MyCurrentReservation));

        }

    }
}
