using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVRepository.Entities;

namespace SVRepository.Intefaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> Lista(string buscar = "");
        Task<string> Crear(Usuario objeto);
        Task<string> Editar(Usuario objeto);
        Task<Usuario> Login(string usuario, string clave);
        Task<int> VerificarCorreo(string correo);
        Task ActualizarClave(int idUsuario, string nuevaClave, int resetear);
    }
}
