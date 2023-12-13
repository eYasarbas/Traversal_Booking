using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Traversal_Booking.Models;

namespace Traversal_Booking.Areas.Admin.Controllers;

[Area("Admin")]
public class MailController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(MailRequest request)
    {
        MimeMessage message = new();
        var mailboxAddressFrom = new MailboxAddress(request.Name, "");
        message.From.Add(mailboxAddressFrom);
        var mailboxAddressTo = new MailboxAddress("User", request.RecieverMail);
        message.To.Add(mailboxAddressTo);
        message.Subject = request.Subject;
        var bodyBuilder = new BodyBuilder();
        bodyBuilder.TextBody = request.Body;
        message.Body = bodyBuilder.ToMessageBody();
        //message.Body = 
        var client = new SmtpClient();
        client.Connect("smtp.gmail.com", 587, false);
        client.Authenticate("", "");
        client.Send(message);
        client.Disconnect(true);
        return View();
    }
}