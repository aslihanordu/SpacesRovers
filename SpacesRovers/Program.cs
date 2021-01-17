using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SpacesRovers.Models;
using System;

namespace SpacesRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<IRoverCommand, RoverCommand>();
                    services.AddHostedService<Worker>();
                });
        }
    }
}
