using aplikacija_server.Entities;
using AutoMapper;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;
using nikolas.Inferfaces;

namespace nikolas.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        private RepositoryContext _context;
        private readonly IMapper _mapper;
        public ClientRepository(RepositoryContext repositoryContext,IMapper mapper) : base(repositoryContext)
        {
            _context = repositoryContext;
            _mapper = mapper;
        }

        public void Create(ClientCreation model)
        {
            var user = _mapper.Map<Client>(model);
            Create(user);
            _context.SaveChanges();
        }

        public void DeleteClient(int id)
        {
            var users = _context.Clients.Find(id);
            if (users == null)
                throw new KeyNotFoundException($"Klijent s {id} nije pronađen u bazi podataka");
            Delete(users);
            _context.SaveChanges();
        }
    }
}
