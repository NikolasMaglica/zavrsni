using aplikacija_server.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using nikolas.Contracts;
using nikolas.Entities.Models;
using nikolas.Entities.DTO;

namespace nikolas.Repository;

public class UserRepository : RepositoryBase<User>, IUser
{
    private RepositoryContext _context;
    private readonly IMapper _mapper;

    public UserRepository(RepositoryContext context, IMapper mapper) : base(context)
    {
        _context = context;
        _mapper = mapper;
    }


    public IEnumerable<User> GetAllUsers()
    {

        return FindAll()
               .OrderBy(ow => ow.firstname)
               .ToList();
    }

    public void Registration(UserCreation register)

    {
        if (_context.Users!.Any(x => x.username == register.username))
            throw new AppException("Korisnicko ime  '" + register.username + "' je zauzeto");

        var user = _mapper.Map<User>(register);
        Create(user);
        _context.SaveChanges();

    }
    public void DeleteUser(int id)
    {
        var users = _context.Users.Find(id);
        if (users == null)
            throw new KeyNotFoundException($"Zaposlenik s {id} nije pronađeno u bazi podataka");
        Delete(users);
        _context.SaveChanges();
    }

    public void UpdateUser(int id, [FromBody] UserUpdate model)
    {

        var user = _context.Users.Find(id);
        if (user == null)
            throw new KeyNotFoundException($"Zaposlenik s {id} nije pronađeno u bazi podataka");
        user.firstname = model.firstname;
        user.lastname = model.lastname;
        user.username = model.username;
        user.password = model.password;
        _mapper.Map(model, user);

        Update(user);
        _context.SaveChanges();


    }

}
    