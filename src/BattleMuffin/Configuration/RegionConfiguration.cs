using System.Collections.Generic;
using System.Linq;
using BattleMuffin.Enums;

namespace BattleMuffin.Configuration
{
    public class RegionConfiguration
    {
        private const string BaseApiUrl = "api.blizzard.com";
        internal string Prefix { get; }
        internal string Host { get; }
        internal IEnumerable<Locale> AvailableLocales { get; }

        internal Locale DefaultLocale => AvailableLocales.First();

        internal RegionConfiguration(string prefix, IEnumerable<Locale> availableLocales)
        {
            Prefix = prefix;
            Host = $"https://{prefix}.{BaseApiUrl}";
            AvailableLocales = availableLocales;
        }

        internal RegionConfiguration(string prefix, string host, IEnumerable<Locale> availableLocales)
        {
            Prefix = prefix;
            Host = host;
            AvailableLocales = availableLocales;
        }
    }
}
