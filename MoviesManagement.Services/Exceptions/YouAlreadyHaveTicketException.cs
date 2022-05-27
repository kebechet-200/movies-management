using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Exceptions
{
    public class YouAlreadyHaveTicketException : Exception
    {
        public string Code = "თქვენ უკვე განხორციელებული გაქვთ ყიდვა/დაჯავშნა";
        public YouAlreadyHaveTicketException(string message) : base(message) { }
    }
}
