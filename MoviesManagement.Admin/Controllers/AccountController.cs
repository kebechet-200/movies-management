using Mapster;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Admin.Models;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Models;
using System;
using System.Threading.Tasks;

namespace MoviesManagement.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login() => 
            View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View();


            try
            {
                await _userService.AuthenticateAsync(model.Adapt<UserModel>());
            }
            catch (Exception)
            {
                ModelState.AddModelError("Login", "Username Or Password Is Incorrect");
                return View();
            }

            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Signout()
        {
            await _userService.SignoutAsync();
            return RedirectToAction("Login");
        }
    }
}
