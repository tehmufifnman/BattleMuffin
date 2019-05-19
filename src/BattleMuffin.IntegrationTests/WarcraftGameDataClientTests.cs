using System;
using BattleMuffin.Clients;
using Xunit;

namespace BattleMuffin.IntegrationTests
{
    public class WarcraftGameDataClientTests
    {
        private WarcraftGameDataClient? _client;

        private WarcraftGameDataClient Client
        {
            get
            {
                if (_client != null)
                {
                    return _client;
                }

                var clientId = Environment.GetEnvironmentVariable("BLIZZARD_CLIENT_ID");
                var clientSecret = Environment.GetEnvironmentVariable("BLIZZARD_CLIENT_SECRET");
                _client = new WarcraftGameDataClient(clientId, clientSecret);
                return _client;
            }
            set => _client = value;
        }

        [Fact]
        public async void GetBattlegroupsAsyncTest()
        {
            var result = await Client.GetAchievementCategoryIndex();
            Assert.NotNull(result.Value);
        }
    }
}
