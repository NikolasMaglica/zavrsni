using nikolas.Entities.DTO;

namespace nikolas.Inferfaces
{
    public interface IServiceRepository
    {
        void Create(ServiceCreation model);
        void DeleteService(int id);

    }
}
