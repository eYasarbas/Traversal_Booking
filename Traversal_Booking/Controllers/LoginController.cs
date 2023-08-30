using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal_Booking.Models;

namespace Traversal_Booking.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel userRegister)
        {
            AppUser appUser = new AppUser()
            {
                Name = userRegister.Name,
                SurName = userRegister.SurName,
                Email = userRegister.Mail,
                UserName = userRegister.UserName,
            };
            if (userRegister.Password == userRegister.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, userRegister.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);

                    }
                }
            }

            return View(userRegister);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserRegisterViewModel userRegister)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(
                    userRegister.UserName, userRegister.Password, false, true
                    );
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new { area = "Member" });
                }
                else
                {
                    return RedirectToAction("SıgnIn", "Login");
                }
            }
            return View();
        }
    }
}