using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class ServiceCreation
    {
        [Required]
        public string? ServiceName { get; set; }
       [Required]
        public int price { get; set; }
        public string? ServiceDescription { get; set; }
    }
}
