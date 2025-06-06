using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVRepository.Entities;

namespace SVServices.Interfaces
{
    public interface IRolService
    {
        Task<List<Rol>> Lista();
    }
}
