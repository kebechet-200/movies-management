using System.ComponentModel.DataAnnotations;

namespace MoviesManagement.Identity.Models
{
    public class RegistrationRequestViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password is not matched")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
