using Mapster;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.API.Models.Request;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Models;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJWTService _jwtService;

        public UserController(IUserService userService, IJWTService jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }

        // GET: api/<UserController>/Login
        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginDTO account)
        {
            var user = await _userService.AuthenticateAsync(account.Adapt<UserModel>());
            var token = _jwtService.GenerateSecurityToken(user);
            return Ok(token);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterDTO account)
        {
            var result = await _userService.CreateAsync(account.Adapt<UserModel>());
            return Ok(result.ToString());
        }
    }
}
