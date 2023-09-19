using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Areas.Admin.Controllers;

[Area("Admin")]
public class DestinationController : Controller
{
    DestinationManager _destinationManager = new(new EfDestinationDal());


    public IActionResult Index()
    {
        var values = _destinationManager.TGetList();
        return View(values);
    }

    [HttpGet]
    public IActionResult AddDestination()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddDestination(Destination destination)
    {
        _destinationManager.TAdd(destination);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult DeleteDestination(int id)
    {
        var values = _destinationManager.TGetById(id);
        _destinationManager.TDelete(values);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult UpdateDestination(int id)
    {
        var values = _destinationManager.TGetById(id);

        return View(values);
    }

    [HttpPost]
    public IActionResult UpdateDestination(Destination destination)
    {
        _destinationManager.TUpdate(destination);
        return RedirectToAction(nameof(Index));
    }
}