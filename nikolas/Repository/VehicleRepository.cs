using aplikacija_server.Entities;
using AutoMapper;
using nikolas.Contracts;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Repository
{
    public class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {
        private RepositoryContext _context;
        private readonly IMapper _mapper;
        public VehicleRepository(RepositoryContext repositoryContext, IMapper mapper) : base(repositoryContext)
        {
            RepositoryContext=repositoryContext;
            _mapper=mapper; 
        }

        public void CreateVehicle(Vehicle model)
        {
                       
                Create(model);
                _context.SaveChanges();
            
        }

        public Vehicle GetVehiclById(int id)
        {
            var kik = FindByCondition(user => user.VehicleId.Equals(id))
                           .FirstOrDefault();
            if (kik == null)
            {
                throw new KeyNotFoundException("Vozilo nije pronađeno u bazi podataka");

            }

            return kik;
        }

        public void DeleteVehicle(int id)
        {
            var users = _context.Vehicles.Find(id);
            if (users == null)
                throw new KeyNotFoundException($"Vozilo s {id} nije pronađeno u bazi podataka");
            Delete(users);
            _context.SaveChanges();
        }
    }
}
