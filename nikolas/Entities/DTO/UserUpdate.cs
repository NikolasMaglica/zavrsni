using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class UserUpdate
    {
        [Required]
        public string firstname { get; set; }=String.Empty;

        [Required]
        public string lastname { get; set; } = String.Empty;

        [Required]
        public string username { get; set; } = String.Empty;

        [Required]
        public string password { get; set; } = String.Empty;
    }
}
