using System.Collections.Generic;
using System.Linq;
using BattleMuffin.Enums;
using BattleMuffin.Exceptions;

namespace BattleMuffin.Configuration
{
    public class RegionConfiguration
    {
        private const string BaseApiUrl = "api.blizzard.com";
        internal string Prefix { get; }
        internal string Host { get; }
        internal IReadOnlyCollection<Locale> AvailableLocales { get; }

        internal Locale DefaultLocale { get; }

        internal RegionConfiguration(string prefix, Locale defaultLocale, IReadOnlyCollection<Locale> availableLocales)
        {
            Prefix = prefix;
            Host = $"https://{prefix}.{BaseApiUrl}";
            DefaultLocale = defaultLocale;
            AvailableLocales = availableLocales;
        }

        internal RegionConfiguration(string prefix, Locale defaultLocale, IReadOnlyCollection<Locale> availableLocales, string host)
        {
            Prefix = prefix;
            Host = host;
            DefaultLocale = defaultLocale;
            AvailableLocales = availableLocales;
        }

        internal void Validate()
        {
            if(AvailableLocales.All(x => x != DefaultLocale))
                throw new LocaleException("Invalid default locale specified.");
        }
    }
}
