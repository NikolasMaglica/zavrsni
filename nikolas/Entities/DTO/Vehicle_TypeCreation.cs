using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class Vehicle_TypeCreation
    {
        [Required]
        public string name { get; set; }=String.Empty;
    }
}
