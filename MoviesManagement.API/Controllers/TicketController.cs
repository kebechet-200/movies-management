using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.API.Enum;
using MoviesManagement.API.Models.Request;
using MoviesManagement.Services.Abstractions;
using MoviesManagement.Services.Models;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MoviesManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        private string _userId;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [Authorize]
        [Route("Buy")]
        [HttpPost]
        public async Task<IActionResult> Buy([FromBody] int movieId)
        {
            _userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = new TicketRequestDTO { UserId = _userId, MovieId = movieId };
            await _ticketService.BuyTicketAsync(data.Adapt<TicketModel>());
            return Ok(TicketStatuses.Bought.ToString());
        }

        [Authorize]
        [Route("Reserve")]
        [HttpPost]
        public async Task<IActionResult> Reserve([FromBody] int movieId)
        {
            _userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = new TicketRequestDTO { UserId = _userId, MovieId = movieId };
            await _ticketService.TicketReservationAsync(data.Adapt<TicketModel>());
            return Ok(TicketStatuses.Reserved.ToString());
        }

        [Authorize]
        [Route("Cancel")]
        [HttpPost]
        public async Task<IActionResult> Cancel([FromBody] int movieId)
        {
            _userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var data = new TicketRequestDTO { UserId = _userId, MovieId = movieId };
            await _ticketService.CancelTicketAsync(data.Adapt<TicketModel>());
            return Ok(TicketStatuses.Cancelled.ToString());
        }
    }
}
