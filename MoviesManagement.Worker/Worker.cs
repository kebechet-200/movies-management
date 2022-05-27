using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MoviesManagement.Data.Repository_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MoviesManagement.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _serviceProvider;

        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            _logger.LogInformation("Logger Started by Lasha Suliashvili");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var movie = scope.ServiceProvider.GetRequiredService<IMovieRepository>();

                        var ticket = scope.ServiceProvider.GetRequiredService<ITicketRepository>();

                        await movie.MovieExpiration();

                        await ticket.CancelExpiredMovieTickets();
                    }
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                    await Task.Delay(1000*60*60, stoppingToken);
                }
                catch(Exception ex)
                {
                    _logger.LogError(ex.Message);
                }
            }
        }
    }
}
