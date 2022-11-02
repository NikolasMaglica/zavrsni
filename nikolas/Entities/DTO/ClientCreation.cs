using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class ClientCreation
    {
       
        [Required]
        public string FirstName { get; set; }=String.Empty;
        [Required]
        public string LastName { get; set; }=String.Empty;
        [Required]
        public string Email { get; set; } = String.Empty;
        [Required]
        public string Adress { get; set; } = String.Empty;
        [Required]
        public int PhoneNumber { get; set; }
    }
}
