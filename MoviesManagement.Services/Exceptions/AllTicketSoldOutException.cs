using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Exceptions
{
    public class AllTicketSoldOutException : Exception
    {
        public string Code = "ყველა ბილეთი გაყიდულია";
        public AllTicketSoldOutException(string message) : base(message)
        {
        }
    }
}
