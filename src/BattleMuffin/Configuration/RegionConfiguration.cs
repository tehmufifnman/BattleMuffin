using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BattleMuffin.Configuration
{
    public class RegionConfiguration
    {
        private const string ApiBaseUrl = "api.blizzard.com";
        private const string OauthBaseUrl = "battle.net";
        internal string OauthHost { get; }
        internal string Host { get; }
        internal IReadOnlyCollection<CultureInfo> AvailableLocales { get; }

        internal CultureInfo DefaultLocale { get; }

        internal RegionConfiguration(string prefix, IReadOnlyCollection<CultureInfo> availableLocales)
        {
            Host = $"https://{prefix}.{ApiBaseUrl}";
            OauthHost = $"https://{prefix}.{OauthBaseUrl}";
            DefaultLocale = availableLocales.First();
            AvailableLocales = availableLocales;
        }

        internal RegionConfiguration(IReadOnlyCollection<CultureInfo> availableLocales,
            string host, string oauthHost)
        {
            Host = host;
            OauthHost = oauthHost;
            DefaultLocale = availableLocales.First();
            AvailableLocales = availableLocales;
        }
    }
}
