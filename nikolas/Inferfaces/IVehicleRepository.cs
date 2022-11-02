

using nikolas.Entities.Models;

namespace nikolas.Contracts
{
    public interface IVehicleRepository:IRepositoryBase<Vehicle>
    {
        void CreateVehicle(Vehicle model);
        Vehicle GetVehiclById(int id);
        void DeleteVehicle(int id);

    }
}
