using Microsoft.EntityFrameworkCore;
using MoviesManagement.Data.Repository_Interfaces;
using MoviesManagement.Domain.Enum;
using MoviesManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Data.Ef.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly IBaseRepository<Ticket> _repo;
        private readonly IMovieRepository _movieRepo;

        public TicketRepository(IBaseRepository<Ticket> repo, IMovieRepository movieRepo)
        {
            _repo = repo;
            _movieRepo = movieRepo;
        }

        public async Task BuyTicketAsync(Ticket ticket)
        {
            var userTickets = await _repo.Table.SingleOrDefaultAsync(x => x.UserId == ticket.UserId && x.MovieId == ticket.MovieId);
            

            if (userTickets != null && userTickets.State == TicketEnum.Reserved)
            {
                userTickets.State = TicketEnum.Bought;
                await _repo.UpdateAsync(userTickets);
            }
            else
                await _repo.AddAsync(ticket);
        }

        public async Task CancelTicket(Ticket ticket)
        {
            var userTickets = await _repo.Table.SingleOrDefaultAsync(x => x.UserId == ticket.UserId && x.MovieId == ticket.MovieId);

            if (userTickets.State == TicketEnum.Reserved)
            {
                userTickets.State = TicketEnum.Cancelled;
                await _repo.UpdateAsync(userTickets);
            }
        }

        public int UserTicketId(Movie movie, string userId)
        {
            var userTicket = movie.Tickets.Where(x => x.UserId == userId).First();
            return userTicket.Id;
        }

        public bool UserHasTicket(Movie movie, string userId)
        {
            return movie.Tickets.Any(x => x.UserId == userId);
        }

        public async Task<Movie> GetMovie(int id)
        {
            return await _movieRepo.GetAsync(id);
        }


        public async Task TicketReservationAsync(Ticket ticket)
        {
            var movieTicket = await GetMovie(ticket.MovieId);
            if (this.UserHasTicket(movieTicket, ticket.UserId))
            {
                ticket.State = TicketEnum.Reserved;
                
                ticket.Id = this.UserTicketId(movieTicket, ticket.UserId);
                await _repo.UpdateAsync(ticket);
            }
            else
                await _repo.AddAsync(ticket);
        }

        public async Task<bool> TicketBoughtExist(Ticket ticket)
        {
            return await _repo.AnyAsync(x => x.UserId == ticket.UserId && x.MovieId == ticket.MovieId && x.State == TicketEnum.Bought);
        }

        public async Task<bool> TicketReserveExist(Ticket ticket)
        {
            return await _repo.AnyAsync(x => x.UserId == ticket.UserId && x.MovieId == ticket.MovieId && x.State == TicketEnum.Reserved);
        }

        public async Task CancelExpiredMovieTickets()
        {
            var tickets = await _repo.Table
                .Include(x => x.Movie)
                .AsNoTracking()
                .Where(x => x.Movie.StartDate <= DateTime.Now.AddHours(1))
                .ToListAsync();

            foreach (var ticket in tickets)
            {
                ticket.State = TicketEnum.Cancelled;
                await _repo.UpdateAsync(ticket);
            }
        }
    }
}
