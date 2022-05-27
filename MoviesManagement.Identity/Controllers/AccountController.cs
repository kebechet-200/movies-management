using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesManagement.Identity.Models;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Enum;
using MoviesManagement.Services.Models;
using System.Threading.Tasks;

namespace MoviesManagement.Identity.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IUserService _service;

        public AccountController(ILogger<AccountController> logger, IUserService service)
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegistrationRequestViewModel model)
        {
            if (!ModelState.IsValid)
                return View();

            var user = model.Adapt<UserModel>();

            var result = await _service.CreateAsync(user);

            if (result != RegisterStatus.RegisteredSuccessfully)
            {

                ModelState.AddModelError("Register", "Registration Failed");
                return View();
            }
            return RedirectToAction(nameof(Login));
        }

        public IActionResult Login()
        {
            return View();
        }

        

    }

}
