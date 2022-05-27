using MoviesManagement.Services.Enum;

namespace MoviesManagement.Admin.Models
{
    public class TicketViewModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public int MovieId { get; set; }

        public TicketStatus State { get; set; }
    }
}
