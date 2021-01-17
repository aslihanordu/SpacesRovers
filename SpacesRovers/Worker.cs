using Microsoft.Extensions.Hosting;
using SpacesRovers.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpacesRovers
{
    public class Worker : BackgroundService
    {
        private readonly IRoverCommand _roverCommand;
        public Worker(IRoverCommand roverCommand)
        {
            _roverCommand = roverCommand;
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                _roverCommand.GetPlateau();
                for (int i = 0; i < 2; i++)
                {
                    _roverCommand.GetPositionsRover();
                }
                _roverCommand.GetOutput();
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
       
        }
    }
}
