using aplikacija_server.Entities;
using AutoMapper;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;
using nikolas.Inferfaces;

namespace nikolas.Repository
{
    public class Service_OfferRepository : RepositoryBase<Service_Offer>, IService_OfferRepository
    {
        private RepositoryContext _context;
        private readonly IMapper _mapper;

        public Service_OfferRepository(RepositoryContext repositoryContext, IMapper mapper) : base(repositoryContext)
        {
            _context = repositoryContext;   
            _mapper = mapper;
        }

        public void Create(Service_OfferCreation model)
        {
            var user = _mapper.Map<Service_Offer>(model);
            Create(user);
            _context.SaveChanges();
        }
    }
}
