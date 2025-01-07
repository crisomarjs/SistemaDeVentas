

using SVRepository.Entities;

namespace SVRepository.Intefaces
{
    public interface IMedidaRepository
    {
        Task<List<Medida>> Lista();
    }
}
