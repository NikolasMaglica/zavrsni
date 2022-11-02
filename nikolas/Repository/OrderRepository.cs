using aplikacija_server.Entities;
using AutoMapper;
using nikolas.Contracts;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {

        private RepositoryContext _context;
        private readonly IMapper _mapper;
        public OrderRepository(RepositoryContext repositoryContext, IMapper mapper) : base(repositoryContext)
        {
            _context=repositoryContext;
            _mapper=mapper;

        }

       

        public void Create(OrderCreation model)
        {
            var user = _mapper.Map<Order>(model);
            Create(user);
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var users = _context.Orders.Find(id);
            if (users == null)
                throw new KeyNotFoundException($"Narudžba s {id} nije pronađena u bazi podataka");
            Delete(users);
            _context.SaveChanges();
        }
    }
}
