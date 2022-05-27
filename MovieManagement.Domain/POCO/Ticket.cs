using Microsoft.AspNetCore.Identity;
using MoviesManagement.Domain.Enum;

namespace MoviesManagement.Domain.POCO
{
    public class Ticket
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string UserId { get; set; }
        public TicketEnum State { get; set; }

        //navigation properties

        public Movie Movie { get; set; }
        public User User { get; set; }

    }
}
