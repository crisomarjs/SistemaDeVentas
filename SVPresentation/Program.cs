using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SVPresentation.Formularios;
using SVRepository;
using SVRepository.Implementation;
using SVRepository.Intefaces;
using SVServices;
using SVServices.Implementation;
using SVServices.Interfaces;

namespace SVPresentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();

            var formService = host.Services.GetRequiredService<frmLogin>();

            Application.Run(formService);
        }

        //Conexi�n con el archivo appsettings.json
        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange:true);
                })
                .ConfigureServices((context,services) =>
                {
                    services.RegisterRepositoryDependencies();
                    services.RegisterServiceDependencies();

                    services.AddTransient<frmCategoria>();
                    services.AddTransient<frmProducto>();
                    services.AddTransient<frmNegocio>();
                    services.AddTransient<frmUsuario>();
                    services.AddTransient<frmVenta>();
                    services.AddTransient<frmBuscarProducto>();
                    services.AddTransient<frmHistorial>();
                    services.AddTransient<frmDetalleVenta>();
                    services.AddTransient<frmReporteVenta>();
                    services.AddTransient<frmLogin>();
                    services.AddTransient<frmActualizarClave>();
                    services.AddTransient<Layout>();
                });
    }
}