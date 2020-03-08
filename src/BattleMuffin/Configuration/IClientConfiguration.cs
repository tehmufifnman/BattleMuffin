using BattleMuffin.Enums;

namespace BattleMuffin.Configuration
{
    public interface IClientConfiguration
    {
        string Host { get; set; }
        Locale Locale { get; set; }
    }
}
