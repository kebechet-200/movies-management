using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Enum;
using MoviesManagement.Services.Models;
using MoviesManagement.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MoviesManagement.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly ITicketService _ticketService;

        public AccountController(IUserService service, ITicketService ticketService)
        {
            _userService = service;
            _ticketService = ticketService;
    }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View();

            Dictionary<int, string> movies;

            var moviesStr = HttpContext.Session.GetString("movies");
            if (moviesStr != null)
                movies = JsonConvert.DeserializeObject<Dictionary<int, string>>(moviesStr);
            else
                movies = new Dictionary<int, string>();


            string userId = string.Empty;

            try
            {
                userId = await _userService.AuthenticateAsync(model.Adapt<UserModel>());
            }
            catch (Exception)
            {
                ModelState.AddModelError("Login", "Username Or Password Is Incorrect");
                return View();
            }


            TicketRequestViewModel request;


            foreach (var item in movies)
            {
                if (item.Value == "Buy")
                {
                    request = new TicketRequestViewModel { UserId = userId, MovieId = item.Key };
                    await _ticketService.BuyTicketAsync(request.Adapt<TicketModel>());
                }
                else
                {
                    request = new TicketRequestViewModel { MovieId = item.Key, UserId = userId };
                    await _ticketService.TicketReservationAsync(request.Adapt<TicketModel>());
                }

            }

            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            return RedirectToAction("Index", "Home");


        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _userService.CreateAsync(model.Adapt<UserModel>());

            if (result == RegisterStatus.RegisteredSuccessfully)
                return RedirectToAction("Login");

            return View();
        }

        public async Task<IActionResult> Signout()
        {
            await _userService.SignoutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
