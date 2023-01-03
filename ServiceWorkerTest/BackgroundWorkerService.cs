// 2. added by me
// 3. implement the interface - added by me

namespace ServiceWorkerTest
{
    public class BackgroundWorkerService : BackgroundService
    {
        readonly ILogger<BackgroundWorkerService> _logger;

        public BackgroundWorkerService(ILogger<BackgroundWorkerService> logger)
        {
            _logger = logger;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            ExecuteInst executeInst= new ExecuteInst();
            executeInst.test();

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}