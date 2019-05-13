using System.Net;
using BattleMuffin.Clients;
using BattleMuffin.Enums;
using BattleMuffin.UnitTests.Attributes;
using RichardSzalay.MockHttp;
using Xunit;

namespace BattleMuffin.UnitTests
{
    public class WarcraftClientTests
    {
        [Theory]
        [JsonData("achievement.json")]
        public async void GetAchievementAsyncTest(int achievementId, string achievementResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/achievement/{achievementId}?locale=en_US", achievementResponse);

            var result = await warcraftClient.GetAchievementAsync(achievementId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("auction.json")]
        public async void GetAuctionAsyncTest(string realm, string auctionResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/auction/data/{realm}?locale=en_US", auctionResponse);

            var result = await warcraftClient.GetAuctionAsync(realm);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("auction_snapshot.json")]
        public async void GetAuctionSnapshotAsyncTest(string auctionSnapshotUrl, string auctionSnapshotResponse)
        {
            var warcraftClient = BuildMockClient(auctionSnapshotUrl, auctionSnapshotResponse);

            var result = await warcraftClient.GetAuctionHouseSnapshotAsync(auctionSnapshotUrl);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("bosses.json")]
        public async void GetBossesAsyncTest(string bossesResponse)
        {
            var warcraftClient = BuildMockClient("https://us.api.blizzard.com/wow/boss/?locale=en_US", bossesResponse);

            var result = await warcraftClient.GetBossesAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("boss.json")]
        public async void GetBossAsyncTest(int bossId, string bossResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/boss/{bossId}?locale=en_US", bossResponse);

            var result = await warcraftClient.GetBossAsync(bossId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("challenges_realm.json")]
        public async void GetChallengesRealmAsyncTest(string realm, string challengeRealmResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/challenge/{realm}?locale=en_US", challengeRealmResponse);

            var result = await warcraftClient.GetChallengesAsync(realm);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("challenges_region.json")]
        public async void GetChallengesRegionAsyncTest(string challengeRegionResponse)
        {
            var warcraftClient = BuildMockClient("https://us.api.blizzard.com/wow/challenge/region?locale=en_US", challengeRegionResponse);

            var result = await warcraftClient.GetChallengesAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("character.json")]
        public async void GetCharacterAsyncTest(string realm, string character, string characterResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/character/{realm}/{character}?locale=en_US&fields=achievements,appearance,feed,guild,hunter pets,items,mounts,pets,pet slots,professions,progression,pvp,quests,reputation,statistics,stats,talents,titles,audit", characterResponse);

            var result = await warcraftClient.GetCharacterAsync(realm, character, CharacterFields.All);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("guild.json")]
        public async void GetGuildAsyncTest(string realm, string guild, string guildResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/guild/{realm}/{guild}?locale=en_US&fields=members,achievements,news,challenge", guildResponse);

            var result = await warcraftClient.GetGuildAsync(realm, guild, GuildFields.All);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("item.json")]
        public async void GetItemAsyncTest(int itemId, string itemResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/item/{itemId}?locale=en_US", itemResponse);

            var result = await warcraftClient.GetItemAsync(itemId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("item_set.json")]
        public async void GetItemSetAsyncTest(int itemSetId, string itemSetResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/item/set/{itemSetId}?locale=en_US", itemSetResponse);

            var result = await warcraftClient.GetItemSetAsync(itemSetId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("mounts.json")]
        public async void GetMountsAsyncTest(string mountsResponse)
        {
            var warcraftClient = BuildMockClient("https://us.api.blizzard.com/wow/mount/?locale=en_US", mountsResponse);

            var result = await warcraftClient.GetMountsAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pets.json")]
        public async void GetPetsAsyncTest(string petsResponse)
        {
            var warcraftClient = BuildMockClient("https://us.api.blizzard.com/wow/pet/?locale=en_US", petsResponse);

            var result = await warcraftClient.GetPetsAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pet_abilities.json")]
        public async void GetPetAbilityAsyncTest(int petAbilityId, string petAbilityResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/pet/ability/{petAbilityId}?locale=en_US", petAbilityResponse);

            var result = await warcraftClient.GetPetAbilityAsync(petAbilityId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pet_species.json")]
        public async void GetPetSpeciesAsyncTest(int petSpeciesId, string petSpeciesResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/pet/species/{petSpeciesId}?locale=en_US", petSpeciesResponse);

            var result = await warcraftClient.GetPetSpeciesAsync(petSpeciesId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pet_stats.json")]
        public async void GetPetStatsAsyncTest(int petSpeciesId, int level, int breedId, int quality, string petStatsResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/pet/stats/{petSpeciesId}?level={level}&breedId={breedId}&qualityId={quality}&locale=en_US", petStatsResponse);

            var result = await warcraftClient.GetPetStatsAsync(petSpeciesId, level, breedId, (BattlePetQuality)quality);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pvp_leaderboard.json")]
        public async void GetPvpLeaderboardAsyncTest(string bracket, string pvpLeaderboardResponse)
        {
            var warcraftClient = BuildMockClient($"https://us.api.blizzard.com/wow/leaderboard/{bracket}?locale=en_US", pvpLeaderboardResponse);

            var result = await warcraftClient.GetPvpLeaderboardAsync(bracket);
            Assert.NotNull(result.Value);
        }

        private static IWarcraftClient BuildMockClient(string requestUri, string responseContent, HttpStatusCode? statusCode = null)
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp.When("https://us.battle.net/oauth/token").Respond("application/json", @"{""access_token"": ""ACCESS-TOKEN"", ""token_type"": ""bearer"", ""expires_in"": 12345, ""scope"": ""test.scope""}");

            if (statusCode == null)
            {
                mockHttp.When(requestUri).Respond("application/json", responseContent);
            }
            else
            {
                mockHttp.When(requestUri).Respond(statusCode.Value, "application/json", responseContent);
            }

            return new WarcraftClient("clientIdHere", "clientSecretHere", Region.US, Locale.en_US, mockHttp.ToHttpClient());
        }
    }
}
