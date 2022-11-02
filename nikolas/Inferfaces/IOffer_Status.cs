using nikolas.Entities.DTO;

namespace nikolas.Inferfaces
{
    public interface IOffer_Status
    {
        void Create(Offer_StatusCreation model);
        void DeleteOffer_Status(int id);

    }
}
