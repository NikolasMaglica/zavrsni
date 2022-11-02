using aplikacija_server.Entities;
using AutoMapper;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;
using nikolas.Inferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nikolas.Repository
{
    public class Material_OfferRepository : RepositoryBase<Material_Offer>, IMaterial_OfferRepository
    {
        private RepositoryContext _context;
        private readonly IMapper _mapper;

        public Material_OfferRepository(RepositoryContext repositoryContext,IMapper mapper) : base(repositoryContext)
        {
            _context = RepositoryContext;
            _mapper = mapper;
        }

        public void Create(Material_OfferCreation model)
        {
            var user = _mapper.Map<Material_Offer>(model);
            Create(user);
            _context.SaveChanges();
        }
    }
}
