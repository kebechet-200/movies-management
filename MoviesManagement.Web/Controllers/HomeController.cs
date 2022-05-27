using Mapster;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MoviesManagement.Web.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IMovieService _service;

        public HomeController(IMovieService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var moviesEntity = await _service.GetAllActiveAsync();
            return View(moviesEntity.Adapt<List<MovieViewModel>>());
        }

        public async Task<IActionResult> Details(int id)
        {
            ViewBag.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var entity = await _service.GetActiveAsync(id);
            if(ViewBag.UserId != null)
            {
                var userTicket = entity.Tickets.SingleOrDefault(x => x.UserId == ViewBag.UserId);
                if (userTicket != null)
                    ViewBag.UserTicket = userTicket;
                else
                    ViewBag.UserTicket = null;
            }
            return View(entity.Adapt<MovieViewModel>());
        }
    }
}
