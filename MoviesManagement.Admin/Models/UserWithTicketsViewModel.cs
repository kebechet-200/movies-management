using System.Collections.Generic;

namespace MoviesManagement.Admin.Models
{
    public class UserWithTicketsViewModel
    {
        public string UserName { get; set; }
        public List<TicketViewModel> Tickets { get; set; }
    }
}
