namespace nikolas.Entities.DTO
{
    public class Vehicle_TypeDto
    {
        public int Id { get; set; }
        public string? name { get; set; }

        public IEnumerable<VehicleDto> Vehicles { get; set; }
    }
}
