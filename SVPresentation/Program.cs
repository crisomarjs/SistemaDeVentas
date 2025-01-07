using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
            Application.Run(new Form1());
        }

        //Conexión con el archivo appsettings.json
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
                });
    }
}