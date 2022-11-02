using nikolas.Entities.DTO;

namespace nikolas.Contracts
{
    public interface IOrderRepository
    {
        void Create(OrderCreation model);
        void DeleteOrder(int id);

    }
}
