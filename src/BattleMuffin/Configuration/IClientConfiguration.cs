using BattleMuffin.Enums;

namespace BattleMuffin.Configuration
{
    public interface IClientConfiguration
    {
        string ClientId { get; }
        string ClientSecret { get; }
        string Host { get; }
        string OauthHost { get; }
        Locale Locale { get; }
    }
}
