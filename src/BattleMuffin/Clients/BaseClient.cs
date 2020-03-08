using System;
using System.Net.Http;
using BattleMuffin.Configuration;
using BattleMuffin.Web;

namespace BattleMuffin.Clients
{
    public class BaseClient
    {
        private readonly IClientConfiguration _clientConfiguration;
        private readonly HttpClient _httpClient;

        public BaseClient(IClientConfiguration clientConfiguration)
        {
            _clientConfiguration = clientConfiguration ?? throw new ArgumentNullException(nameof(clientConfiguration));
            _httpClient = InternalHttpClient.GetInstance(_clientConfiguration.Host);
        }
    }
}
