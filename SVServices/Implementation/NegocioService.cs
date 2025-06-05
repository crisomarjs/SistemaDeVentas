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
    public class NegocioService : INegocioService
    {
        private readonly INegocioRepository _negocioRepository;
        public NegocioService(INegocioRepository negocioRepository)
        {
            _negocioRepository = negocioRepository;
        }
        public async Task Editar(Negocio negocio)
        {
            await _negocioRepository.Editar(negocio);
        }

        public async Task<Negocio> Obtener()
        {
            return await _negocioRepository.Obtener();
        }
    }
}
