using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.Services.Models
{
    public class UserWithRolesModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
