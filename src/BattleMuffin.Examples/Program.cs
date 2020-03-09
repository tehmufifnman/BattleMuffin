using System.Threading.Tasks;
using BattleMuffin.Enums;
using BattleMuffin.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace BattleMuffin.Examples
{
    internal static class Program
    {
        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddWarcraftClient(Region.US, "client-id", "client-secret");
            services.AddTransient<ConsoleApplication>();    return services;
        }

        private static async Task Main()
        {
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            await serviceProvider.GetService<ConsoleApplication>().Run();
        }
    }
}
