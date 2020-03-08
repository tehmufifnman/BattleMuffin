using BattleMuffin.Enums;

namespace BattleMuffin.Configuration
{
    public interface IClientConfiguration
    {
        string Host { get; }
        Locale Locale { get; }
    }
}
