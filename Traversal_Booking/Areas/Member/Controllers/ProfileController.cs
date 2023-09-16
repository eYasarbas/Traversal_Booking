using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal_Booking.Areas.Member.Models;

namespace Traversal_Booking.Areas.Member.Controllers;

[Area("Member")]
[Route("Member/[controller]/[action]")]
public class ProfileController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public ProfileController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        //var user = await _userManager.FindByNameAsync(User.Identity.Name);


        var userEditViewModel = new UserEditViewModel();
        userEditViewModel.name = "Defaultname";
        userEditViewModel.surname = "Defaultsurname";
        userEditViewModel.phoneNumber = "324r3245245";
        userEditViewModel.mail = "sdsas.gmail.com";
        // Varsayılan olarak AppUser nesnesinde Name özelliği yoksa burada hata alırsınız.
        // Gerektiğinde AppUser sınıfınızdaki özellikleri güncelleyin.
        // Diğer özellikleri de burada user nesnesinden çekerek userEditViewModel'e atayabilirsiniz.

        return View(userEditViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);
        if (userEditViewModel.Image != null)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(userEditViewModel.Image.FileName);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = resource + "/wwwroot/userImages/" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            await userEditViewModel.Image.CopyToAsync(stream);
            user.ImageUrl = imageName;
        }

        user.Name = userEditViewModel.name;
        user.SurName = userEditViewModel.surname;
        user.PasswordHash = _userManager.PasswordHasher.HashPassword(
            user, userEditViewModel.password);
        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded) return RedirectToAction("Index", "Home");
        return View();
    }
}