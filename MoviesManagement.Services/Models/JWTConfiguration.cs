using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Models
{
    public class JWTConfiguration
    {
        public string Secret { get; set; }
        public int ExpInMin { get; set; }
    }
}
