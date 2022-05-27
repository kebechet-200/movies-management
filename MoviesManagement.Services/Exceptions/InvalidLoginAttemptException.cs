using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Exceptions
{
    public class InvalidLoginAttemptException : Exception
    {
        public string Code = "Invalid login";
        public InvalidLoginAttemptException(string message) : base(message)
        {
        }
    }
}
