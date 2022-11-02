using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required(ErrorMessage = "Morate unijeti ime")]
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Morate unijeti prezime")]
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Morate unijeti email")]
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Morate unijeti adresu")]
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        public string? Adress { get; set; }
        [Required(ErrorMessage = "Morate unijeti broj mobitela")]
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 20 znamenki")]
        public int PhoneNumber { get; set; }
        public virtual ICollection<Offer>? Offers { get; set; }
        public ICollection<Vehicle>? Vehicles { get; set; }


    }
}
