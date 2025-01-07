﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SVRepository.Implementation;
using SVRepository.Intefaces;
using SVServices.Implementation;
using SVServices.Interfaces;

namespace SVServices
{
    public static class DependencyInjection
    {
        public static void RegisterServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IMedidaService, MedidaService>();
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IProductoService, ProductoService>();
        }
    }
}
