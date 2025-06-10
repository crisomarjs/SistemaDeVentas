using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVRepository.Entities;

namespace SVRepository.Intefaces
{
    public interface IProductoRepository
    {
        Task<List<Producto>> Lista(string buscar = "");
        Task<string> Crear(Producto objeto);
        Task<string> Editar(Producto objeto);
        Task<Producto> Obtener(string codigo);
    }
}
