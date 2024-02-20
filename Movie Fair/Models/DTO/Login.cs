using System.ComponentModel.DataAnnotations;

namespace Movie_Fair.Models.DTO
{
    public class Login
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
