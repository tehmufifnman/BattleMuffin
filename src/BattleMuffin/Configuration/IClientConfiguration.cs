using System.Globalization;

namespace BattleMuffin.Configuration
{
    public interface IClientConfiguration
    {
        string ClientId { get; }
        string ClientSecret { get; }
        string Host { get; }
        string OauthHost { get; }
        CultureInfo Locale { get; }
    }
}
