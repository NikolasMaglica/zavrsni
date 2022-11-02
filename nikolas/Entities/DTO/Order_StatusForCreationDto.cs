using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class Order_StatusForCreationDto
    {
        [Required]
        public string? status { get; set; }
    }
}
