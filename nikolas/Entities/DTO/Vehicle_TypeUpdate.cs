using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class Vehicle_TypeUpdate
    {
        [Required(ErrorMessage = "Morate unijeti ime")]
        [StringLength(60, ErrorMessage = "Unos mora biti ogranicen na 60 znamenki")]
        public string name { get; set; }
    }
}
