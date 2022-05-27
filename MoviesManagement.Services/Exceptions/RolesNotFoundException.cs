using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Exceptions
{
    public class RolesNotFoundException : Exception
    {
        public string Code = "როლები ვერ მოიძებნა";

        public RolesNotFoundException(string message) : base(message)
        {
        }
    }
}
