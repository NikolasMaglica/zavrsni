using aplikacija_server.Entities;
using AutoMapper;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;
using nikolas.Inferfaces;

namespace nikolas.Repository
{
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        private RepositoryContext _context;
        private readonly IMapper _mapper;
        public ServiceRepository(RepositoryContext repositoryContext,IMapper mapper) : base(repositoryContext)
        {
            _context = repositoryContext;
            _mapper = mapper;
        }

     

        public void Create(ServiceCreation model)
        {
            var user = _mapper.Map<Service>(model);
            Create(user);
            _context.SaveChanges();
        }

        public void DeleteService(int id)
        {
            var users = _context.Services.Find(id);
            if (users == null)
                throw new KeyNotFoundException($"Usluga s {id} nije pronađena u bazi podataka");
            Delete(users);
            _context.SaveChanges();
        }
    }
}
