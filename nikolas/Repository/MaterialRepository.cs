using aplikacija_server.Entities;
using AutoMapper;
using nikolas.Contracts;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Repository
{
    public class MaterialRepository : RepositoryBase<Material>, IMaterialRepository
    {
        private RepositoryContext _context;
        private readonly IMapper _mapper;
        public MaterialRepository(RepositoryContext repositoryContext, IMapper mapper) : base(repositoryContext)
        {
            _context = repositoryContext;
            _mapper = mapper;
        }

        public void Create(MaterialForCreation material)
        {
            var user = _mapper.Map<Material>(material);
            Create(user);
            _context.SaveChanges();
        }

        public void DeleteMaterial(int id)
        {
            var users = _context.Materials.Find(id);
            if (users == null)
                throw new KeyNotFoundException($"Material s {id} nije pronađen u bazi podataka");
            Delete(users);
            _context.SaveChanges();
        }
    }
}
