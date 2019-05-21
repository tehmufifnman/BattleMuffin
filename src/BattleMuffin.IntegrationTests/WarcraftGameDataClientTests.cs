using System;
using BattleMuffin.Clients;
using BattleMuffin.IntegrationTests.Attributes;
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
        }

        [Fact]
        public async void GetAchievementCategoryIndexAsyncTest()
        {
            var result = await Client.GetAchievementCategoryIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/achievement_category.json")]
        public async void GetAchievementCategoryAsyncTest(int achievementCategoryId)
        {
            var result = await Client.GetAchievementCategoryAsync(achievementCategoryId);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetAchievementIndexAsyncTest()
        {
            var result = await Client.GetAchievementIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/achievement.json")]
        public async void GetAchievementAsyncTest(int achievementId)
        {
            var result = await Client.GetAchievementAsync(achievementId);
            Assert.NotNull(result.Value);
        }
    }
}
