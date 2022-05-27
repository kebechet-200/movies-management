using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Exceptions
{

    public class MovieAlreadyStartedException : Exception
    {
        public string Code = "Movie already started";

        public MovieAlreadyStartedException(string message) : base(message) { }
    }
}
