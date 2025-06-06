using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVRepository.Entities;

namespace SVServices.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> Lista(string buscar = "");
        Task<string> Crear(Usuario objeto);
        Task<string> Editar(Usuario objeto);
    }
}
