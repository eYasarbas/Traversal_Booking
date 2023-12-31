﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Areas.Admin.Controllers;

[Area("Admin")]
public class CommentController : Controller
{
    private readonly ICommentService _commentService;

    public CommentController(ICommentService commentService)
    {
        _commentService = commentService;
    }
    public IActionResult Index()
    {
        var values = _commentService.TGetListCommentsWithDestination();
        return View(values);
    }

    public IActionResult DeleteComment(int id)
    {
        var values = _commentService.TGetById(id);
        _commentService.TDelete(values);
        return RedirectToAction(nameof(Index));
    }
}