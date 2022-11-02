using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class Service_OfferCreation
    {
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public int OfferID { get; set; }
        [Required]
        public int Service_OfferQuantity { get; set; }
       
        public int Service_OfferDiscount { get; set; }
    }
}
