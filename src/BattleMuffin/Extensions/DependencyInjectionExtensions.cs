using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using BattleMuffin.Clients;
using BattleMuffin.Configuration;
using BattleMuffin.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace BattleMuffin.Extensions
{
    public static class DependencyInjectionExtensions
    {
        private static void AddBattleMuffinHttpClient(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddHttpClient<BattleMuffinClient>("BattleMuffinClient", client =>
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            })
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
            });

            serviceCollection.AddSingleton<BattleMuffinClientFactory>();
        }

        public static void AddWarcraftClient(this IServiceCollection serviceCollection, Region region, string clientId, string clientSecret)
        {
            serviceCollection.AddSingleton<IClientConfiguration>(x => new ClientConfiguration(region, clientId, clientSecret));
            serviceCollection.AddBattleMuffinHttpClient();
            serviceCollection.AddSingleton<IWarcraftClient, WarcraftClient>();
        }

        public static void AddWarcraftClient(this IServiceCollection serviceCollection, Region region, string clientId, string clientSecret, Locale locale)
        {
            serviceCollection.AddSingleton<IClientConfiguration>(x => new ClientConfiguration(region, clientId, clientSecret, locale));
            serviceCollection.AddBattleMuffinHttpClient();
            serviceCollection.AddSingleton<IWarcraftClient, WarcraftClient>();
        }
    }
}
