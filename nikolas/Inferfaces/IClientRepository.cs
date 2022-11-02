using nikolas.Entities.DTO;

namespace nikolas.Inferfaces
{
    public interface IClientRepository
    {
        void Create(ClientCreation model);
        void DeleteClient(int id);

    }
}
