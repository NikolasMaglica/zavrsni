using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.Models
{
    public class Offer_Status
    {
        [Key]
        public int OfferStatusId { get; set; }
        [Required(ErrorMessage = "Morate unijeti status")]
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        public string? Offer_Statusstatus { get; set; }
        public virtual ICollection<Offer>? Offers { get; set; }
    }
}
