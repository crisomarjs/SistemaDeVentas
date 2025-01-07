using SVRepository.Entities;

namespace SVRepository.Intefaces
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> Lista(string buscar = "");
        Task<string> Crear(Categoria objeto);
        Task<string> Editar(Categoria objeto);
    }
}
