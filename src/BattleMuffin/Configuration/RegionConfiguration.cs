using System.Collections.Generic;
using System.Linq;
using BattleMuffin.Enums;
using BattleMuffin.Exceptions;

namespace BattleMuffin.Configuration
{
    public class RegionConfiguration
    {
        private const string ApiBaseUrl = "api.blizzard.com";
        private const string OauthBaseUrl = "battle.net";
        internal string Prefix { get; }
        internal string OauthHost { get; }
        internal string Host { get; }
        internal IReadOnlyCollection<Locale> AvailableLocales { get; }

        internal Locale DefaultLocale { get; }

        internal RegionConfiguration(string prefix, Locale defaultLocale, IReadOnlyCollection<Locale> availableLocales)
        {
            Prefix = prefix;
            Host = $"https://{prefix}.{ApiBaseUrl}";
            OauthHost = $"https://{prefix}.{OauthBaseUrl}";
            DefaultLocale = defaultLocale;
            AvailableLocales = availableLocales;
        }

        internal RegionConfiguration(string prefix, Locale defaultLocale, IReadOnlyCollection<Locale> availableLocales,
            string host, string oauthHost)
        {
            Prefix = prefix;
            Host = host;
            OauthHost = oauthHost;
            DefaultLocale = defaultLocale;
            AvailableLocales = availableLocales;
        }

        internal void Validate()
        {
            if (AvailableLocales.All(x => x != DefaultLocale))
                throw new LocaleException("Invalid default locale specified.");
        }
    }
}
