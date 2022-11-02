using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        [Required(ErrorMessage = "Morate unijeti naziv usluge")]
        public string? ServiceName { get; set; }
        [StringLength(4, ErrorMessage = "Unos ne smije biti veci od 4 znamenke")]
        [Required(ErrorMessage = "Morate unijeti cijenu usluge")]
        public double price { get; set; }
        [StringLength(512, ErrorMessage = "Unos ne smije biti veci od 512 znamenki")]
        public string? ServiceDescription { get; set; }
        public ICollection<Service_Offer>? Service_Offer { get; set; }


    }
}
