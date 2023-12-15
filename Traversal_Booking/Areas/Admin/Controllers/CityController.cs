using BusinessLayer.Abstract;
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
}