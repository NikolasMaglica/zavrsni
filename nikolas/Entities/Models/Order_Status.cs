using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.Models
{
    public class Order_Status
    {
        [Key]
        public int OrderStatusId { get; set; }
        [Required(ErrorMessage = "Morate unijeti status")]
        [StringLength(60, ErrorMessage = "Unos ne smije biti veci od 60 znamenki")]
        public string? OrderStatusStatus { get; set; }
        public virtual ICollection<Order_Material>? Order_Materials { get; set; }

      
    }
}
