using MoviesManagement.Services.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string UserId { get; set; }
        public TicketStatus State { get; set; }
    }
}
