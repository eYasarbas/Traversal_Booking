using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

    [HttpPost]
    public IActionResult AddCityDestination(Destination destination)
    {
        _destinationService.TAdd(destination);
        var values = JsonConvert.SerializeObject(destination);
        return Json(values);
    }

    public IActionResult GetById(int DestinationID)
    {
        var values = _destinationService.TGetById(DestinationID);
        return Json(JsonConvert.SerializeObject(values));
    }

    public IActionResult DeleteCity(int id)
    {
        var values = _destinationService.TGetById(id);
        _destinationService.TDelete(values);
        return NoContent();
    }

    public IActionResult UpdateCity(Destination destination)
    {
        _destinationService.TUpdate(destination);
        var jsonValue = JsonConvert.SerializeObject(destination);
        return Json(jsonValue);
    }
}







