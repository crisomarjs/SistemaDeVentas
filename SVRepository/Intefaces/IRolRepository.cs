using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVRepository.Entities;

namespace SVRepository.Intefaces
{
    public interface IRolRepository
    {
        Task<List<Rol>> Lista();
    }
}
