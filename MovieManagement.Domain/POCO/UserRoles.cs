using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Domain.POCO
{
    public class UserRoles
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
