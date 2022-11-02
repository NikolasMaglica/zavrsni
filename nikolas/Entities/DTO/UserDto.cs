using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class UserDto
    {
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
