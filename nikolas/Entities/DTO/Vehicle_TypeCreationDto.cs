using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class Vehicle_TypeDto
    {
        [Required(ErrorMessage = "Morate unijeti vrstu vozila")]
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        public string? name { get; set; }
    }
}
