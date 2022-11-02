using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Contracts
{
    public interface IOfferRepository
    {
        void Create_OfferRepository(OfferForCreation offer);
        Offer GetOfferbyId(int id);

        void UpdateOffer(int id,OfferUpdate offer);
        Offer GetOfferWithDetail(int id);
        void DeleteOffer(int id);



    }
}
