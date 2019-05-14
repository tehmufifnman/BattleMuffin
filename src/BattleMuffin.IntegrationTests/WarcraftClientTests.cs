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
            var result = await Client.GetPetStatsAsync(petSpeciesId, level, breedId, (BattlePetQuality) quality);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pvp_leaderboard.json")]
        public async void GetPvpLeaderboardAsyncTest(string bracket)
        {
            var result = await Client.GetPvpLeaderboardAsync(bracket);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("quest.json")]
        public async void GetQuestAsyncTest(int questId)
        {
            var result = await Client.GetQuestAsync(questId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("recipe.json")]
        public async void GetRecipeAsyncTest(int recipeId)
        {
            var result = await Client.GetRecipeAsync(recipeId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("recipe.json")]
        public async void GetSpellAsyncTest(int spellId)
        {
            var result = await Client.GetSpellAsync(spellId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("zone.json")]
        public async void GetZoneAsyncTest(int zoneId)
        {
            var result = await Client.GetZoneAsync(zoneId);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetBattlegroupsAsyncTest()
        {
            var result = await Client.GetBattlegroupsAsync();
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
        public async void GetCharacterAchievementsAsyncTest()
        {
            var result = await Client.GetCharacterAchievementsAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCharacterClassesAsyncTest()
        {
            var result = await Client.GetCharacterClassesAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCharacterRacesAsyncTest()
        {
            var result = await Client.GetCharacterRacesAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetGuildAchievementsAsyncTest()
        {
            var result = await Client.GetGuildAchievementsAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetGuildPerksAsyncTest()
        {
            var result = await Client.GetGuildPerksAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetGuildRewardsAsyncTest()
        {
            var result = await Client.GetGuildRewardsAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetItemClassesAsyncTest()
        {
            var result = await Client.GetItemClassesAsync();
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

        [Fact]
        public async void GetPetTypesAsyncTest()
        {
            var result = await Client.GetPetTypesAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetRealmStatusAsyncTest()
        {
            var result = await Client.GetRealmStatusAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetTalentsAsyncTest()
        {
            var result = await Client.GetTalentsAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetZonesAsyncTest()
        {
            var result = await Client.GetZonesAsync();
            Assert.NotNull(result.Value);
        }
    }
}
