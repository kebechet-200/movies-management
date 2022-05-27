using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Admin.Models;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Enum;
using MoviesManagement.Services.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesManagement.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {

        public IUserService _userService;
        public ITicketService _ticketService;

        public UserController(IUserService userService, ITicketService ticketService)
        {
            _userService = userService;
            _ticketService = ticketService;
        }

        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            var users = await _userService.GetAllUserWithRoles();
            var usersWithRoles = users.Adapt<List<GetUserWithRolesViewModel>>().AsQueryable();
            return View(PageModelList<GetUserWithRolesViewModel>.Create(usersWithRoles, pageNumber, 5));
        }

        public async Task<IActionResult> Manage(string id)
        {
            ViewBag.Id = id;
            var user = await _userService.GetUserName(id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            ViewBag.UserName = user;
            var manage = new List<ChangeUserRolesViewModel>();
            foreach (var role in await _userService.GetAllRolesAsync())
            {
                var userRole = new ChangeUserRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };
                if (await _userService.IsInRole(user, role.Name))
                    userRole.Selected = true;
                else
                    userRole.Selected = false;
                manage.Add(userRole);
            }
            return View(manage);
        }

        [HttpPost]
        public async Task<IActionResult> Manage([FromForm] List<ChangeUserRolesViewModel> model, string id)
        {

            ViewBag.Id = id;
            var user = await _userService.GetUserName(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }

            ViewBag.UserName = user;
            var roles = await _userService.GetUserRolesAsync(id);

            if (roles.Count > 0)
            {
                var deleting = await _userService.DeleteUserRoles(user, roles);
                if (!deleting.Succeeded)
                {
                    ModelState.AddModelError("", "მომხმარებელს ამ როლს ვერ წაუშლი");
                    return View(model);
                }
            }

            var adding = await _userService.AddToRolesAsync(user, model.Where(x => x.Selected).Select(y => y.RoleName));

            if (!adding.Succeeded)
            {
                ModelState.AddModelError("", "მომხმარებელს ამ როლს ვერ დაუმატებ");
                return View(model);
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UserTickets(string id)
        {
            ViewBag.UserName = await _userService.GetUserName(id);
            if (ViewBag.UserName == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }

            var userTickets = await _userService.GetUserWithTicketsAsync(id);

            return View(userTickets.Adapt<UserWithTicketsViewModel>());
        }

        //[Route("{controller}/{action}/{userId}/{movieId}")]
        [HttpGet]
        public async Task<IActionResult> CancelTicket(string userId, int movieId)
        {
            var cancel = new TicketViewModel
            {
                UserId = userId,
                MovieId = movieId,
                State = TicketStatus.Cancelled
            };

            await _ticketService.CancelTicketAsync(cancel.Adapt<TicketModel>());

            return RedirectToAction("Index");
        }
    }
}
