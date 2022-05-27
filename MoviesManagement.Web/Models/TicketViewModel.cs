using MoviesManagement.Services.Enum;

namespace MoviesManagement.Web.Models
{
    public class TicketViewModel
    {
        public string UserId { get; set; }
        public int MovieId { get; set; }

        public TicketStatus State { get; set; }
    }
}
