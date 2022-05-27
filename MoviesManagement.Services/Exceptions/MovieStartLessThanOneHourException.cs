using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Exceptions
{
    public class MovieStartLessThanOneHourException : Exception
    {
        public string code = "Movie starts less than one hour";

        public MovieStartLessThanOneHourException(string message) : base(message) { }
    }
}
