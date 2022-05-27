using MoviesManagement.Domain.Enum;
using MoviesManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Data.Repository_Interfaces
{
    public interface ITicketRepository
    {
        Task BuyTicketAsync(Ticket ticket);

        Task TicketReservationAsync(Ticket ticket);

        Task CancelTicket(Ticket ticket);

        Task<bool> TicketBoughtExist(Ticket ticket);
        Task<bool> TicketReserveExist(Ticket ticket);

        Task CancelExpiredMovieTickets();
    }
}
