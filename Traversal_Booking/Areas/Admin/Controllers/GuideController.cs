﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Areas.Admin.Controllers;

[Area("Admin")]
public class GuideController : Controller
{
    private readonly IGuideService _guideService;

    public GuideController(IGuideService guideService)
    {
        _guideService = guideService;
    }

    public IActionResult Index()
    {
        var values = _guideService.TGetList();
        return View(values);
    }

    [HttpGet]
    public IActionResult AddGuide()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddGuide(Guide guide)
    {
        if (guide == null) _guideService.TAdd(guide);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult EditGuide(int id)
    {
        var values = _guideService.TGetById(id);
        return View(values);
    }

    [HttpPost]
    public IActionResult EditGuide(Guide guide)
    {
        _guideService.TUpdate(guide);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult ChangeToStatuse(int id)
    {
        return RedirectToAction(nameof(Index));
    }
}