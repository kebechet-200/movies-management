using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Exceptions
{
    public class UserDoesNotExist : Exception
    {
        public string Code = "იუზერი ვერ მოიძებნა";
        public UserDoesNotExist(string message) : base(message)
        {
        }
    }
}
