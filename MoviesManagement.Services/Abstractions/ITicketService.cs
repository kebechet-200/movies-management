using MoviesManagement.Services.Enum;
using MoviesManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Services.Abstractions
{
    public interface ITicketService
    {
        Task BuyTicketAsync(TicketModel ticket); 
        Task TicketReservationAsync(TicketModel ticket); 
        Task CancelTicketAsync(TicketModel ticket); 
    }
}
