using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Models;
using MoviesManagement.Web.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MoviesManagement.Web.Controllers
{
    
    public class TicketController : Controller
    {
        private Dictionary<int,string> movies;
        private readonly ITicketService _service;
        private string userId = string.Empty;

        public TicketController(ITicketService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Buy(int id)
        {
            userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if(userId == string.Empty || userId == null)
            {
                var session = HttpContext.Session.GetString("movies");

                if(session != null)
                    movies = JsonConvert.DeserializeObject<Dictionary<int, string>>(session);
                else
                    movies = new Dictionary<int, string>();

                if (movies.ContainsKey(id))
                    movies[id] = "Buy";

                else
                    movies.Add(id, "Buy");

                var movieStr = JsonConvert.SerializeObject(movies);
                HttpContext.Session.SetString("movies", movieStr);
                return RedirectToAction("Index", "Home");
            }

            var data = new TicketRequestViewModel { MovieId = id, UserId = userId };
            await _service.BuyTicketAsync(data.Adapt<TicketModel>());
            return RedirectToAction("Index", "Home");

        }

        public async Task<IActionResult> Reserve(int id)
        {
            userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == string.Empty || userId == null)
            {
                var session = HttpContext.Session.GetString("movies");

                if (session != null)
                    movies = JsonConvert.DeserializeObject<Dictionary<int, string>>(session);
                else
                    movies = new Dictionary<int, string>();

                if (movies.ContainsKey(id))
                    movies[id] = "Reserve";
                else
                    movies.Add(id, "Reserve");

                var movieStr = JsonConvert.SerializeObject(movies);
                HttpContext.Session.SetString("movies", movieStr);
                return RedirectToAction("Index", "Home");
            }

            var data = new TicketRequestViewModel { MovieId = id, UserId = userId };
            await _service.TicketReservationAsync(data.Adapt<TicketModel>());
            return RedirectToAction("Index", "Home");

        }
        public async Task<IActionResult> Cancel(int id)
        {
            userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = new TicketRequestViewModel { MovieId = id, UserId = userId };
            await _service.CancelTicketAsync(data.Adapt<TicketModel>());
            return RedirectToAction("Index", "Home");
        }
    }
}
