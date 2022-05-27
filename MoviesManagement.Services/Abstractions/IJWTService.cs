using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Abstractions
{
    public interface IJWTService
    {
        public string GenerateSecurityToken(string username);
    }
}
