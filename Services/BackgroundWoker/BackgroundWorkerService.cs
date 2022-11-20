﻿using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Services.BackgroundWoker
{
    public class BackgroungQueueService : BackgroundService
    {
        private readonly ILogger _logger;
        public BackgroungQueueService(IBackgroundQueue taskQueue,
            ILoggerFactory loggerFactory)
        {
            TaskQueue = taskQueue;
            _logger = loggerFactory.CreateLogger<BackgroungQueueService>();
        }
        public IBackgroundQueue TaskQueue { get; }
        protected async override Task ExecuteAsync(
            CancellationToken cancellationToken)
        {
            _logger.LogInformation("Queued Hosted Service is starting.");
            while (!cancellationToken.IsCancellationRequested)
            {
                var workItem = await TaskQueue.DequeueAsync(cancellationToken);
                try
                {
                    await workItem(cancellationToken);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex,
                       "Error occurred executing {WorkItem}.", nameof(workItem));
                }
            }
            _logger.LogInformation("Queued Hosted Service is stopping.");
        }
    }
}