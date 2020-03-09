using System.Globalization;
using System.Linq;
using BattleMuffin.Enums;
using BattleMuffin.Exceptions;
using JetBrains.Annotations;

namespace BattleMuffin.Configuration
{
    [UsedImplicitly]
    public class ClientConfiguration : IClientConfiguration
    {
        public ClientConfiguration(Region region, string clientId, string clientSecret, CultureInfo? locale = null)
        {
            var regionConfig = RegionConfigurationMap.Mapping.ContainsKey(region)
                ? RegionConfigurationMap.Mapping[region]
                : throw new RegionException("Configuration not found for specified region");

            if (locale != null && !regionConfig.AvailableLocales.Any(x => x.Equals(locale)))
            {
                throw new LocaleException("Locale not valid for specified region");
            }

            Host = regionConfig.Host;
            OauthHost = regionConfig.OauthHost;
            Locale = locale ?? regionConfig.DefaultLocale;
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        public string ClientId { get; }
        public string ClientSecret { get; }
        public string Host { get; }
        public string OauthHost { get; }
        public CultureInfo Locale { get; }
    }
}
