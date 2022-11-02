using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
