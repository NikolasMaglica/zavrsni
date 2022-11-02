using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nikolas.Entities.Models
{
    [Table("Vehicle_Type")]

    public class Vehicle_Type
    {


        [Key]
        public int Vehicle_TypeId { get; set; }

        [Required(ErrorMessage = "Morate unijeti vrstu vozila")]
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        public string? Vehicle_TypeName { get; set; }

        public ICollection<Vehicle>? Vehicles { get; set; }
    }
}
