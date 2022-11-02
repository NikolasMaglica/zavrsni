using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Contracts
{
    public interface IOrder_StatusRepository
    {
        Order_Status GetOrder_StatusById(int id);
        void Create(Order_StatusForCreationDto model);
        void Order_Status(int id);

    }

}
