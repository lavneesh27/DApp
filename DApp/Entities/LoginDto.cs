using System.ComponentModel.DataAnnotations;

namespace DApp.Entities
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
