using System;
using System.Collections.Generic;

namespace MoviesManagement.Web.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }

        public List<TicketViewModel> Tickets { get; set; }
    }
}
