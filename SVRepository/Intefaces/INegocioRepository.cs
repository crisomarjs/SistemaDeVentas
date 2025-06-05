

using SVRepository.Entities;

namespace SVRepository.Intefaces
{
    public interface INegocioRepository
    {
        Task<Negocio> Obtener();
        Task Editar(Negocio negocio);
    }
}
