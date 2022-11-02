using aplikacija_server.Entities;
using AutoMapper;
using nikolas.Contracts;
using nikolas.Entities.Models;

namespace nikolas.Repository
{
    public class Vehicle_TypeRepository : RepositoryBase<Vehicle_Type>, IVehicle_TypeRepository
    {
        private RepositoryContext _repositoryContext;

        public Vehicle_TypeRepository(RepositoryContext repositoryContext, IMapper mapper) : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;

         }

        public void CreateVehicle_Type(Vehicle_Type vehicle_type)
        {
            
                Create(vehicle_type);
            _repositoryContext.SaveChanges();

         
        }

        public void DeleteVehicle_Type(Vehicle_Type vehicle_type)
        {
            Delete(vehicle_type);
        }

        public void UpdateVehicle_Type(Vehicle_Type vehicle_type)
        {
            Update(vehicle_type);
        }
    }
}