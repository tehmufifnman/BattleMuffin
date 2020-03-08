using BattleMuffin.Configuration;

namespace BattleMuffin.Clients
{
    public class BaseClient
    {
        private readonly IClientConfiguration _clientConfiguration;

        public BaseClient(IClientConfiguration clientConfiguration)
        {
            _clientConfiguration = clientConfiguration;
        }
    }
}
