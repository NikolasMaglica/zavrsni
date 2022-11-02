using aplikacija_server.Entities;
using AutoMapper;
using nikolas.Contracts;
using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Repository
{
    public class Order_StatusRepository : RepositoryBase<Order_Status>, IOrder_StatusRepository
    {
        private RepositoryContext _context;
        private readonly IMapper _mapper;
        public Order_StatusRepository(RepositoryContext repositoryContext, IMapper mapper) : base(repositoryContext)
        {
            _context=repositoryContext; 
            _mapper=mapper;
        }

  

        public Order_Status GetOrder_StatusById(int id)
        {
            return FindByCondition(o => o.OrderStatusId.Equals(id)).FirstOrDefault();
        }

        public void Create(Order_StatusForCreationDto model)
        {
            var user = _mapper.Map<Order_Status>(model);
            Create(user);
            _context.SaveChanges();
        }

        public void Order_Status(int id)
        {
            var users = _context.Order_Status.Find(id);
            if (users == null)
                throw new KeyNotFoundException($"Status narudžbe s {id} nije pronađen u bazi podataka");
            Delete(users);
            _context.SaveChanges();
        }
    }
}
