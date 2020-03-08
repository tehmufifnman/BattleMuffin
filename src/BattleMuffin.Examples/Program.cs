using BattleMuffin.Clients;
using BattleMuffin.Configuration;
using BattleMuffin.Enums;

namespace BattleMuffin.Examples
{
    internal static class Program
    {
        private static void Main()
        {
            //Consumer of lib would DI the client configuration
            var client1 = new BaseClient(
                new ClientConfiguration(Region.US, "client-id", "client-secret")
            );

            var client2 = new BaseClient(
                new ClientConfiguration(Region.US, "client-id", "client-secret", Locale.SpanishMX)
            );
        }
    }
}
