using Microsoft.EntityFrameworkCore;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Contracts
{
    public interface IOrder_MaterialRepository
    {
        void CreateOrder_MaterialRepository(Order_MaterialForCreation order_material);
        Order_Material GetOrder_MaterialById(int id);
        void UpdateOrder_Material(int id, Order_MaterialUpdate  order_material);
    }
}
