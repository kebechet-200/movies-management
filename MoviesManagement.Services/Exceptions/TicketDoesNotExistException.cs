using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Exceptions
{
    public class TicketDoesNotExistException : Exception
    {
        public string Code = "ბილეთი არ არსებობს";
        public TicketDoesNotExistException(string message) : base(message)
        {
        }
    }
}
