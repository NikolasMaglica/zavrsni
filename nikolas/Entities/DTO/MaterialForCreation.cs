using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class MaterialForCreation
    {
         [Required]
        public string? MaterialName { get; set; }
        [Required]
        public int in_stock_quantity { get; set; }
        [Required]
        public int price { get; set; }
        public string? description { get; set; }
    }
}
