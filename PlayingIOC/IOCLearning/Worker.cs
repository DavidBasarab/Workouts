using Microsoft.Extensions.Hosting;

namespace IOCLearning;

public sealed class Worker(IMessageWriter messageWriter) : BackgroundService
{
    public override Task StartAsync(CancellationToken cancellationToken)
    {
        messageWriter.Write("Starting worker");

        return base.StartAsync(cancellationToken);
    }

    public override Task StopAsync(CancellationToken cancellationToken)
    {
        messageWriter.Write("Stopping worker");

        return base.StopAsync(cancellationToken);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            messageWriter.Write($"Worker running at: {DateTimeOffset.Now}");
            await Task.Delay(1_000, stoppingToken);
        }
    }
}
