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
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository;
        public RolService(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }
        public Task<List<Rol>> Lista()
        {
            return _rolRepository.Lista();
        }
    }
}
