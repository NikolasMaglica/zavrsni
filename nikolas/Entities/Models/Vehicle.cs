using nikolas.Entities.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nikolas.Entities.Models
{
    [Table("Vehicle")]
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Required(ErrorMessage = "Morate unijeti proizvodaca")]
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        public string? manufactrer { get; set; }
        [Required(ErrorMessage = "Morate unijeti model vozila")]
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        public string? model { get; set; }
        [Required(ErrorMessage = "Morate unijeti godinu proizvodnje")]
        [StringLength(5, ErrorMessage = "Unos ne smije biti veci od 5 znamenki")]
        public int ProductionYear { get; set; }
        [Required(ErrorMessage = "Morate unijet ibroj prijedenih kilometara")]
        [StringLength(5, ErrorMessage = "Unos ne smije biti veci od 6 znamenki")]
        public int KilometresTraveled { get; set; }

        [ForeignKey(nameof(Vehicle_Type))]
        public int Vehicle_TypeId { get; set; }
        public Vehicle_Type? Vehicles { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }
        public Client? Clients { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }



    }
}


