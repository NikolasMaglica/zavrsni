using System.ComponentModel.DataAnnotations;

namespace nikolas.Entities.DTO
{
    public class VehicleDto
    {
     
        public string? manufactrer { get; set; }
        
        public string? model { get; set; }
     
        public int ProductionYear { get; set; }
      
        public int KilometreTraveled { get; set; }
        public int ClientId { get; set; }
        public int Vehicle_TypeId { get; set; } 
    }
}
