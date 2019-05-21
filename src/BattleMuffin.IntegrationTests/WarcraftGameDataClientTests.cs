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

        [Theory]
        [JsonData("GameData/achievement_media.json")]
        public async void GetAchievementMediaAsyncTest(int achievementId)
        {
            var result = await Client.GetAchievementMediaAsync(achievementId);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetConnectedRealmIndexAsyncTest()
        {
            var result = await Client.GetConnectedRealmIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/connected_realm.json")]
        public async void GetConnectedRealmAsyncTest(int connectedRealmId)
        {
            var result = await Client.GetConnectedRealmAsync(connectedRealmId);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCreatureFamilyIndexAsyncTest()
        {
            var result = await Client.GetCreatureFamilyIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/creature_family.json")]
        public async void GetCreatureFamilyAsyncTest(int creatureFamilyId)
        {
            var result = await Client.GetCreatureFamilyAsync(creatureFamilyId);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCreatureTypeIndexAsyncTest()
        {
            var result = await Client.GetCreatureTypeIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/creature_type.json")]
        public async void GetCreatureTypeAsyncTest(int creatureTypeId)
        {
            var result = await Client.GetCreatureTypeAsync(creatureTypeId);
            Assert.NotNull(result.Value);
        }
    }
}
