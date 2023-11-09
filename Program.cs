using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebJob1
{
    public class Program
    {
        public static async  Task Main()
        {
            var builder = new HostBuilder();

            // Increases the polling frequency to storage
            builder.UseEnvironment(EnvironmentName.Development);

            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddAzureStorageQueues();
            });

            builder.ConfigureLogging((context, b) =>
            {
                b.AddConsole();
            });

            var host = builder.Build();

            using (host)
            {
                await host.RunAsync();
            }

            // Similar to Function App's, huh?
        }
    }
}