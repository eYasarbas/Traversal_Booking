using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Traversal_Booking.Models;

namespace Traversal_Booking.Areas.Admin.Controllers;

[Area("Admin")]
public class CityController : Controller
{
    public static List<CityClass> cities = new()
    {
        CityItem(1, "Üsküp", "Makedonya"),
        CityItem(2, "Roma", "İtalya"),
        CityItem(3, "Londra", "İngiltere")
    };


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CityList()
    {
        var jsonCity = JsonConvert.SerializeObject(cities);
        return Json(jsonCity);
    }

    private static CityClass CityItem(int id, string name, string country)
    {
        return new CityClass
        {
            CityID = id,
            CityName = name,
            CityCountry = country
        };
    }
}