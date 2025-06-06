using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVRepository.Entities;
using SVRepository.Intefaces;
using SVServices.Interfaces;

namespace SVServices.Implementation
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<string> Crear(Usuario objeto)
        {
            return await _usuarioRepository.Crear(objeto);
        }

        public async Task<string> Editar(Usuario objeto)
        {
            return await _usuarioRepository.Editar(objeto);
        }

        public async Task<List<Usuario>> Lista(string buscar = "")
        {
            return await _usuarioRepository.Lista(buscar);
        }
    }
}
