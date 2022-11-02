
using nikolas.Contracts;
using nikolas.Entities.Models;

namespace nikolas.Repository
{
    public interface IVehicle_TypeRepository : IRepositoryBase<Vehicle_Type>
    {
        
        void CreateVehicle_Type(Vehicle_Type vehicle_type);
        void DeleteVehicle_Type(Vehicle_Type vehicle_type);
        void UpdateVehicle_Type(Vehicle_Type vehicle_type);

    }
}
