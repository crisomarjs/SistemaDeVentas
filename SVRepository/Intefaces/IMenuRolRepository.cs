
using SVRepository.Entities;

namespace SVRepository.Intefaces
{
    public interface IMenuRolRepository
    {
        Task<List<MenuRol>> Lista(int idRol);
    }
}
