using System.ComponentModel.DataAnnotations;

namespace MoviesManagement.Identity.Models
{
    public class LoginRequestViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
