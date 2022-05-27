using System.ComponentModel.DataAnnotations;

namespace MoviesManagement.Web.Models
{
    public class AccountLoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
