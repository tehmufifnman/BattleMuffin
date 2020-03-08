using System.Linq;
using BattleMuffin.Enums;
using BattleMuffin.Exceptions;
using JetBrains.Annotations;

namespace BattleMuffin.Configuration
{
    [UsedImplicitly]
    public class ClientConfiguration : IClientConfiguration
    {
        public string ClientId { get; }
        public string ClientSecret { get; }
        public string Host { get; }
        public Locale Locale { get; }

        public ClientConfiguration(Region region, string clientId, string clientSecret)
        {
            var regionConfig = RegionConfigurationMap.Mapping.ContainsKey(region)
                ? RegionConfigurationMap.Mapping[region]
                : throw new RegionException("Configuration not found for specified region");

            Host = regionConfig.Host;
            Locale = regionConfig.DefaultLocale;
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        public ClientConfiguration(Region region, string clientId, string clientSecret, Locale locale)
        {
            var regionConfig = RegionConfigurationMap.Mapping.ContainsKey(region)
                ? RegionConfigurationMap.Mapping[region]
                : throw new RegionException("Configuration not found for specified region");

            if(regionConfig.AvailableLocales.Any(x => x == locale))
                throw new LocaleException("Locale not valid for specified region");

            Host = regionConfig.Host;
            Locale = locale;
            ClientId = clientId;
            ClientSecret = clientSecret;
        }
    }
}
