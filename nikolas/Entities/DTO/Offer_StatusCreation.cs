using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class Offer_StatusCreation
    {
        [Required]
        public string Offer_Statusstatus { get; set; }=String.Empty;
    }
}
