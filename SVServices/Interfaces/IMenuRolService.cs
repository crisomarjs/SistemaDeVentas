using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVRepository.Entities;

namespace SVServices.Interfaces
{
    public interface IMenuRolService
    {
        Task<List<MenuRol>> Lista(int idRol);
    }
}
