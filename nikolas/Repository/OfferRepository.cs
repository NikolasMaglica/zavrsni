using aplikacija_server.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using nikolas.Contracts;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Repository
{
    public class OfferRepository : RepositoryBase<Offer>, IOfferRepository
    {
        private IMapper _mapper;
        private RepositoryContext _context;
        public OfferRepository(RepositoryContext repositoryContext, IMapper mapper, RepositoryContext context) : base(repositoryContext)
        {
            _mapper = mapper;
            _context = context; 
        }

    

        public void Create_OfferRepository(OfferForCreation offer)
        {
            var user = _mapper.Map<Offer>(offer);
            Create(user);
            _context.SaveChanges();
        }

        public Offer GetOfferbyId(int id)
        {
            return FindByCondition(ow => ow.OfferId.Equals(id)).FirstOrDefault();
        }

        public void UpdateOffer(int id,OfferUpdate offer)
        {
            var update = FindByCondition(w => w.OfferId.Equals(id)).FirstOrDefault();
            if (update is null)
            {
                throw new KeyNotFoundException("Ponuda nije pronađena u bazi podataka");

            }
            _mapper.Map(offer, update);
            var materialOffer = _context.Material_Offers!.Where(x => x.OfferID == update.OfferId).FirstOrDefault();

            if (offer.Offer_StatusID == 1 && materialOffer is not null)
            {
                var material = _context.Materials!.Where(x => x.MaterialId == materialOffer!.MaterialID).FirstOrDefault();
                material!.MaterialInStockQuantity -= materialOffer!.Material_OfferQuantity;
                _context.Materials!.Update(material);
                _context.SaveChanges();
            }
            if (materialOffer == null)
            {
                throw new KeyNotFoundException("Ponuda materijala nije pronadena u bazi podataka");
            }
            else
            {
               _context.Offers.Update(update);
                _context.SaveChanges();
            }

            _context.SaveChanges();
        }
    
        public Offer GetOfferWithDetail(int offer)
        {

            var promjena = FindByCondition(owner => owner.OfferId.Equals(offer)).Include(a => a.Service_Offers).Include(b => b.Material_Offers).FirstOrDefault();
                if (promjena is null)
                {
                    throw new KeyNotFoundException("Ponuda nije pronađena u bazi podataka");
                }

             
                return promjena;
            
            
        }

        public void DeleteOffer(int id)
        {
            var users = _context.Offers.Find(id);
            if (users == null)
                throw new KeyNotFoundException($"Narudžba s {id} nije pronađena u bazi podataka");
            Delete(users);
            _context.SaveChanges();
        }
    }
}

