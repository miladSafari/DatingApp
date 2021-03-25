using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(100, MinimumLength = 3)]
        public string Username { get; set; }
        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(100, MinimumLength = 3)]
        public string Password { get; set; }
    }
}