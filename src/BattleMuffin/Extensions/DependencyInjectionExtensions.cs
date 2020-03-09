using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using BattleMuffin.Clients;
using BattleMuffin.Configuration;
using BattleMuffin.Enums;
using JetBrains.Annotations;
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
        
        [UsedImplicitly]
        public static void AddWarcraftClient(this IServiceCollection serviceCollection, Region region, string clientId, string clientSecret, CultureInfo? locale = null)
        {
            serviceCollection.AddSingleton<IClientConfiguration>(x => new ClientConfiguration(region, clientId, clientSecret, locale));
            serviceCollection.AddBattleMuffinHttpClient();
            serviceCollection.AddSingleton<IWarcraftClient, WarcraftClient>();
        }
    }
}
