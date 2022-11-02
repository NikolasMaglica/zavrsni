using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NIKOLASAPI.NewFolder
{
    public class OfferCreation
    {
        [Required]
        public string price { get; set; } = String.Empty;
        [Required]
        public string userid { get; set; } = String.Empty;

    }
}
