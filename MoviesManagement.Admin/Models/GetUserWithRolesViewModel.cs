using System.Collections.Generic;

namespace MoviesManagement.Admin.Models
{
    public class GetUserWithRolesViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
