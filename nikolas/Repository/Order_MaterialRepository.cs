using aplikacija_server.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nikolas.Contracts;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Repository
{
    public class Order_MaterialRepository : RepositoryBase<Order_Material>, IOrder_MaterialRepository
    {
        private RepositoryContext _context;
        private readonly IMapper _mapper;

        public Order_MaterialRepository(RepositoryContext repositoryContext,IMapper mapper) : base(repositoryContext)
        {
            _context = repositoryContext;
            _mapper = mapper;
        }

        public void CreateOrder_MaterialRepository(Order_MaterialForCreation order_material)
        {
            var user = _mapper.Map<Order_Material>(order_material);
            Create(user);
            _context.SaveChanges();

        }

        public Order_Material GetOrder_MaterialById(int id)
        {
            {
                var kik = FindByCondition(order_material => order_material.OrderId.Equals(id))
                           .FirstOrDefault();
                if (kik == null)
                {
                    throw new KeyNotFoundException("Narudzba nije pronađena u bazi podataka");

                }

                return kik;

            }
        }

        public void UpdateOrder_Material(int id,Order_MaterialUpdate order_material)
        {
            var update = FindByCondition(order_material => order_material.OrderId.Equals(id))
                           .FirstOrDefault();
            if (update is null)
            {
                throw new KeyNotFoundException("Narudzba nije pronađena u bazi podataka");

            }
            _mapper.Map(order_material, update);
            var material = _context.Materials!.Where(x => x.MaterialId == update.MaterialId).FirstOrDefault();
            var orderMaterial = _context.Order_Materials!.Where(x => x.MaterialId == material!.MaterialId).AsNoTracking().FirstOrDefault();
            if (order_material.Order_StatusId == 1)
            {
                material!.MaterialInStockQuantity += orderMaterial!.Order_MaterialQuantity;
                _context.Order_Materials.Update(update);
                _context.Materials!.Update(material!);
                _context.SaveChanges();
            }
            else
            {
                _context.Order_Materials.Update(update);
                _context.SaveChanges();
            }

            _context.SaveChanges();
        }
        
    }
}

