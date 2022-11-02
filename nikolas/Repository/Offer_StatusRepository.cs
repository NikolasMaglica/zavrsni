using aplikacija_server.Entities;
using AutoMapper;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;
using nikolas.Inferfaces;

namespace nikolas.Repository
{
    public class Offer__StatusRepository : RepositoryBase<Offer_Status>, IOffer_Status
    {

        private RepositoryContext _context;
        private IMapper _mapper;
        public Offer__StatusRepository(RepositoryContext repositoryContext, IMapper mapper) : base(repositoryContext)
        {
            _context = repositoryContext;
            _mapper = mapper; 

        }

        public void Create(Offer_StatusCreation model)
        {
            var user = _mapper.Map<Offer_Status>(model);
            Create(user);
            _context.SaveChanges();
        }

        public void DeleteOffer_Status(int id)
        {
            var users = _context.Offer_Statuses.Find(id);
            if (users == null)
                throw new KeyNotFoundException($"Status materijala s {id} nije pronađen u bazi podataka");
            Delete(users);
            _context.SaveChanges();
        }
    }
}
