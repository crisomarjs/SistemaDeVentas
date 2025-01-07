﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SVRepository.Implementation;
using SVRepository.Intefaces;

namespace SVRepository
{
    public static class DependencyInjection
    {
        public static void RegisterRepositoryDependencies(this IServiceCollection services) {
            services.AddTransient<IMedidaRepository, MedidaRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
        }
    }
}