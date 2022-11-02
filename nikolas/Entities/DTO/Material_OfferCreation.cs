

using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class Material_OfferCreation
    {
        [Required]
        public int MaterialID { get; set; }
        [Required]
        public int OfferID { get; set; }
        [Required]
        public int Material_OfferQuantity { get; set; }
        
        public int Material_OfferDiscount { get; set; }
    }
}
