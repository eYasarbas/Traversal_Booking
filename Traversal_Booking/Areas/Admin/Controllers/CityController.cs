using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Destination = EntityLayer.Concrete.Destination;

namespace Traversal_Booking.Areas.Admin.Controllers;

[Area("Admin")]
public class CityController : Controller
{
    private readonly IDestinationService _destinationService;

    public CityController(IDestinationService destinationService)
    {
        _destinationService = destinationService;
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CityList()
    {
        var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
        return Json(jsonCity);
    }

    public IActionResult AddCityDestination(Destination destination)
    {
        _destinationService.TAdd(destination);
        return Json(destination);
    }
}