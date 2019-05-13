using System;
using BattleMuffin.Clients;
using BattleMuffin.Enums;
using BattleMuffin.IntegrationTests.Attributes;
using Xunit;

namespace BattleMuffin.IntegrationTests
{
    public class WarcraftClientTests
    {
        private WarcraftClient? _client;

        private WarcraftClient Client
        {
            get
            {
                if (_client != null)
                {
                    return _client;
                }

                var clientId = Environment.GetEnvironmentVariable("BLIZZARD_CLIENT_ID");
                var clientSecret = Environment.GetEnvironmentVariable("BLIZZARD_CLIENT_SECRET");
                _client = new WarcraftClient(clientId, clientSecret);
                return _client;
            }
            set => _client = value;
        }

        [Theory]
        [JsonData("achievement.json")]
        public async void GetAchievementAsyncTest(int achievementId)
        {
            var result = await Client.GetAchievementAsync(achievementId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("auction.json")]
        public async void GetAuctionAsyncTest(string realm)
        {
            var result = await Client.GetAuctionAsync(realm);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("auction_snapshot.json")]
        public async void GetAuctionHouseSnapshotAsyncTest(string auctionSnapshotUrl)
        {
            var result = await Client.GetAuctionHouseSnapshotAsync(auctionSnapshotUrl);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("boss.json")]
        public async void GetBossAsyncTest(int bossId)
        {
            var result = await Client.GetBossAsync(bossId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("challenges_realm.json")]
        public async void GetChallengesRealmAsyncTest(string realm)
        {
            var result = await Client.GetChallengesAsync(realm);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("character.json")]
        public async void GetCharacterAsyncTest(string realm, string character)
        {
            var result = await Client.GetCharacterAsync(realm, character, CharacterFields.All);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("guild.json")]
        public async void GetGuildAsyncTest(string realm, string guild)
        {
            var result = await Client.GetGuildAsync(realm, guild, GuildFields.All);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("item.json")]
        public async void GetItemAsyncTest(int itemId)
        {
            var result = await Client.GetItemAsync(itemId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("item_set.json")]
        public async void GetItemSetAsyncTest(int itemSetId)
        {
            var result = await Client.GetItemSetAsync(itemSetId);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetBossesAsyncTest()
        {
            var result = await Client.GetBossesAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetChallengesRegionAsyncTest()
        {
            var result = await Client.GetChallengesAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetMountsAsyncTest()
        {
            var result = await Client.GetMountsAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPetsAsyncTest()
        {
            var result = await Client.GetPetsAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pet_abilities.json")]
        public async void GetPetAbilityAsyncTest(int petAbilityId)
        {
            var result = await Client.GetPetAbilityAsync(petAbilityId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pet_species.json")]
        public async void GetPetSpeciesAsyncTest(int petSpeciesId)
        {
            var result = await Client.GetPetSpeciesAsync(petSpeciesId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pet_stats.json")]
        public async void GetPetStatsAsyncTest(int petSpeciesId, int level, int breedId, int quality)
        {
            var result = await Client.GetPetStatsAsync(petSpeciesId, level, breedId, (BattlePetQuality)quality);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pvp_leaderboard.json")]
        public async void GetPvpLeaderboardAsyncTest(string bracket)
        {
            var result = await Client.GetPvpLeaderboardAsync(bracket);
            Assert.NotNull(result.Value);
        }
    }
}
