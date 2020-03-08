using System.Linq;
using BattleMuffin.Enums;
using BattleMuffin.Exceptions;
using JetBrains.Annotations;

namespace BattleMuffin.Configuration
{
    [UsedImplicitly]
    public class ClientConfiguration : IClientConfiguration
    {
        public string Host { get; }
        public Locale Locale { get; }

        public ClientConfiguration(Region region)
        {
            var regionConfig = RegionConfigurationMap.Mapping.ContainsKey(region)
                ? RegionConfigurationMap.Mapping[region]
                : throw new RegionException("Configuration not found for specified region");
            Host = regionConfig.Host;
            Locale = regionConfig.DefaultLocale;
        }

        public ClientConfiguration(Region region, Locale locale)
        {
            var regionConfig = RegionConfigurationMap.Mapping.ContainsKey(region)
                ? RegionConfigurationMap.Mapping[region]
                : throw new RegionException("Configuration not found for specified region");

            if(regionConfig.AvailableLocales.All(x => x != locale))
                throw new LocaleException("Locale not valid for specified region");

            Host = regionConfig.Host;
            Locale = locale;
        }
    }
}
