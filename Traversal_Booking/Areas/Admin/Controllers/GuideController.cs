using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/Guide")]
//[Route("Admin/[controller]/[action]")]
//[Route("Admin/Guide/[action]/{id?}")]
public class GuideController : Controller
{
    private readonly IGuideService _guideService;

    public GuideController(IGuideService guideService)
    {
        _guideService = guideService;
    }

    [Route("")]
    [Route("Index")]
    public IActionResult Index()
    {
        var values = _guideService.TGetList();
        return View(values);
    }

    [Route("AddGuide")]
    [HttpGet]
    public IActionResult AddGuide()
    {
        return View();
    }

    [Route("AddGuide")]
    [HttpPost]
    public IActionResult AddGuide(Guide guide)
    {
        GuideValidator validationRules = new();
        var validationResult = validationRules.Validate(guide);
        if (validationResult.IsValid)
        {
            _guideService.TAdd(guide);
            return RedirectToAction(nameof(Index), nameof(Guide), new
            {
                area = "Admin"
            });
        }

        foreach (var item in validationResult.Errors) ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        return View();
    }

    [Route("EditGuide")]
    [HttpGet]
    public IActionResult EditGuide(int id)
    {
        var values = _guideService.TGetById(id);
        return View(values);
    }

    [Route("EditGuide")]
    [HttpPost]
    public IActionResult EditGuide(Guide guide)
    {
        _guideService.TUpdate(guide);
        return RedirectToAction(nameof(Index), nameof(Guide), new
        {
            area = "Admin"
        });
    }

    [Route("ChangeToTrue")]
    [HttpPost]
    public IActionResult ChangeToTrue(int id)
    {
        _guideService.TChangeToTrueByGuide(id);
        return RedirectToAction(nameof(Index), nameof(Guide), new
        {
            area = "Admin"
        });
    }

    [Route("GuidesstatuChangeToTrue{id}")]
    public async Task<IActionResult> GuidesstatuChangeToTrue(int id)
    {
        var model = await _guideService.GuidesstatuChangeToTrue(id);


        return Redirect("/Admin/Guide/Index/");
    }


    [Route("ChangeToFalse")]
    [HttpPost]
    public IActionResult ChangeToFalse(int id)
    {
        _guideService.TChangeToFalseByGuide(id);
        return RedirectToAction(nameof(Index), nameof(Guide), new
        {
            area = "Admin"
        });
    }
}