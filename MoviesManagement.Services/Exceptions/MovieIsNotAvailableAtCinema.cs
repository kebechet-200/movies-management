using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Exceptions
{
    public class MovieIsNotAvailableAtCinema : Exception
    {
        public string Code = "Movie is not available";
        public MovieIsNotAvailableAtCinema(string message) : base(message)
        {
        }
    }
}
