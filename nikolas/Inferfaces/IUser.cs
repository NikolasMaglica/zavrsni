using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Contracts
{
    public interface IUser
    {
        IEnumerable<User> GetAllUsers();
        void Registration(UserCreation model);
        void DeleteUser(int id);
        void UpdateUser(int id, UserUpdate model);

    }
}
