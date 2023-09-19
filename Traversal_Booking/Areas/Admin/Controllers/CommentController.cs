﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Areas.Admin.Controllers;

[Area("Admin")]
public class CommentController : Controller
{
    private readonly CommentManager _commentManager = new(new EfCommentDal());

    public IActionResult Index()
    {
        var values = _commentManager.TGetListCommentsWithDestination();
        return View(values);
    }

    public IActionResult DeleteComment(int id)
    {
        var values = _commentManager.TGetById(id);
        _commentManager.TDelete(values);
        return RedirectToAction(nameof(Index));
    }
}