using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BattleMuffin.Configuration;
using BattleMuffin.Extensions;
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

        public async Task GetSomeDataExamples()
        {
            //This will run for 10 seconds and then throw a TimeoutException
            var request = new HttpRequestMessage(HttpMethod.Get, $"some/path").SetTimeout(TimeSpan.FromSeconds(10));
            var response = await _httpClient.SendAsync(request);

            //This will run for 2 seconds and then throw a TaskCanceledException
            var request2 = new HttpRequestMessage(HttpMethod.Get, "some/other/path").SetTimeout(TimeSpan.FromSeconds(10));
            var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(2));
            var response2 = await _httpClient.SendAsync(request2, cancellationTokenSource.Token);
        }
    }
}
