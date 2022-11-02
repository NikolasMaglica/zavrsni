using nikolas.Entities.DTO;
using nikolas.Entities.Models;

namespace nikolas.Contracts
{
    public interface IMaterialRepository:IRepositoryBase<Material>
    {
        void Create(MaterialForCreation material);
        void DeleteMaterial(int id);

    }
}
