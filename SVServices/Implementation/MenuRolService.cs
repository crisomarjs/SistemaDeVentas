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
    public class MenuRolService : IMenuRolService
    {
        private readonly IMenuRolRepository _menuRolRepository;
        public MenuRolService(IMenuRolRepository menuRolRepository)
        {
            _menuRolRepository = menuRolRepository;
        }
        public async Task<List<MenuRol>> Lista(int idRol)
        {
            return await _menuRolRepository.Lista(idRol);
        }
    }
}
