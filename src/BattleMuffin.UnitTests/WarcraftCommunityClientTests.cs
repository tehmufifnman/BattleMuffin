using System.Net;
using BattleMuffin.Clients;
using BattleMuffin.Enums;
using BattleMuffin.UnitTests.Attributes;
using RichardSzalay.MockHttp;
using Xunit;

namespace BattleMuffin.UnitTests
{
    public class WarcraftCommunityClientTests
    {
        [Theory]
        [JsonData("achievement.json")]
        public async void GetAchievementAsyncTest(int achievementId, string achievementResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/achievement/{achievementId}?locale=en_US", achievementResponse);

            var result = await warcraftCommunityClient.GetAchievementAsync(achievementId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("auction.json")]
        public async void GetAuctionAsyncTest(string realm, string auctionDataStatusResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/auction/data/{realm}?locale=en_US", auctionDataStatusResponse);

            var result = await warcraftCommunityClient.GetAuctionDataStatusAsync(realm);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("auction_snapshot.json")]
        public async void GetAuctionSnapshotAsyncTest(string auctionDataDumpUrl, string auctionDataDumpResponse)
        {
            var warcraftCommunityClient = BuildMockClient(auctionDataDumpUrl, auctionDataDumpResponse);

            var result = await warcraftCommunityClient.GetAuctionHouseDataDumpAsync(auctionDataDumpUrl);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("bosses.json")]
        public async void GetBossesAsyncTest(string bossesResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/boss/?locale=en_US", bossesResponse);

            var result = await warcraftCommunityClient.GetBossesAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("boss.json")]
        public async void GetBossAsyncTest(int bossId, string bossResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/boss/{bossId}?locale=en_US", bossResponse);

            var result = await warcraftCommunityClient.GetBossAsync(bossId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("challenges_realm.json")]
        public async void GetChallengesRealmAsyncTest(string realm, string challengeRealmResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/challenge/{realm}?locale=en_US", challengeRealmResponse);

            var result = await warcraftCommunityClient.GetChallengesAsync(realm);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("challenges_region.json")]
        public async void GetChallengesRegionAsyncTest(string challengeRegionResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/challenge/region?locale=en_US", challengeRegionResponse);

            var result = await warcraftCommunityClient.GetChallengesAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("character.json")]
        public async void GetCharacterAsyncTest(string realm, string character, string characterResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/character/{realm}/{character}?locale=en_US&fields=achievements,appearance,feed,guild,hunter pets,items,mounts,pets,pet slots,professions,progression,pvp,quests,reputation,statistics,stats,talents,titles,audit", characterResponse);

            var result = await warcraftCommunityClient.GetCharacterAsync(realm, character, CharacterFields.All);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("guild.json")]
        public async void GetGuildAsyncTest(string realm, string guild, string guildResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/guild/{realm}/{guild}?locale=en_US&fields=members,achievements,news,challenge", guildResponse);

            var result = await warcraftCommunityClient.GetGuildAsync(realm, guild, GuildFields.All);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("item.json")]
        public async void GetItemAsyncTest(int itemId, string itemResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/item/{itemId}?locale=en_US", itemResponse);

            var result = await warcraftCommunityClient.GetItemAsync(itemId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("item_set.json")]
        public async void GetItemSetAsyncTest(int itemSetId, string itemSetResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/item/set/{itemSetId}?locale=en_US", itemSetResponse);

            var result = await warcraftCommunityClient.GetItemSetAsync(itemSetId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("mounts.json")]
        public async void GetMountsAsyncTest(string mountsResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/mount/?locale=en_US", mountsResponse);

            var result = await warcraftCommunityClient.GetMountsAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pets.json")]
        public async void GetPetsAsyncTest(string petsResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/pet/?locale=en_US", petsResponse);

            var result = await warcraftCommunityClient.GetPetsAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pet_abilities.json")]
        public async void GetPetAbilityAsyncTest(int petAbilityId, string petAbilityResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/pet/ability/{petAbilityId}?locale=en_US", petAbilityResponse);

            var result = await warcraftCommunityClient.GetPetAbilityAsync(petAbilityId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pet_species.json")]
        public async void GetPetSpeciesAsyncTest(int petSpeciesId, string petSpeciesResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/pet/species/{petSpeciesId}?locale=en_US", petSpeciesResponse);

            var result = await warcraftCommunityClient.GetPetSpeciesAsync(petSpeciesId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pet_stats.json")]
        public async void GetPetStatsAsyncTest(int petSpeciesId, int level, int breedId, int quality, string petStatsResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/pet/stats/{petSpeciesId}?level={level}&breedId={breedId}&qualityId={quality}&locale=en_US", petStatsResponse);

            var result = await warcraftCommunityClient.GetPetStatsAsync(petSpeciesId, level, breedId, (BattlePetQuality) quality);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pvp_leaderboard.json")]
        public async void GetPvpLeaderboardAsyncTest(string bracket, string pvpLeaderboardResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/leaderboard/{bracket}?locale=en_US", pvpLeaderboardResponse);

            var result = await warcraftCommunityClient.GetPvpLeaderboardAsync(bracket);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("quest.json")]
        public async void GetQuestAsyncTest(int questId, string questResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/quest/{questId}?locale=en_US", questResponse);

            var result = await warcraftCommunityClient.GetQuestAsync(questId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("realm_status.json")]
        public async void GetRealmStatusAsyncTest(string realmStatusResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/realm/status?locale=en_US", realmStatusResponse);

            var result = await warcraftCommunityClient.GetRealmStatusAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("recipe.json")]
        public async void GetRecipeAsyncTest(int recipeId, string recipeResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/recipe/{recipeId}?locale=en_US", recipeResponse);

            var result = await warcraftCommunityClient.GetRecipeAsync(recipeId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("spell.json")]
        public async void GetSpellAsyncTest(int spellId, string spellResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/spell/{spellId}", spellResponse);

            var result = await warcraftCommunityClient.GetSpellAsync(spellId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("zones.json")]
        public async void GetZonesAsyncTest(string zonesResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/zone/?locale=en_US", zonesResponse);

            var result = await warcraftCommunityClient.GetZonesAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("zone.json")]
        public async void GetZoneAsyncTest(int zoneId, string zoneResponse)
        {
            var warcraftCommunityClient = BuildMockClient($"https://us.api.blizzard.com/wow/zone/{zoneId}?locale=en_US", zoneResponse);

            var result = await warcraftCommunityClient.GetZoneAsync(zoneId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("battlegroups.json")]
        public async void GetBattlegroupsAsyncTest(string battlegroupsResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/data/battlegroups/?locale=en_US", battlegroupsResponse);

            var result = await warcraftCommunityClient.GetBattlegroupsAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("character_races.json")]
        public async void GetCharacterRacesAsyncTest(string characterRacesResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/data/character/races", characterRacesResponse);

            var result = await warcraftCommunityClient.GetCharacterRacesAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("character_classes.json")]
        public async void GetCharacterClassesAsyncTest(string characterClassesResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/data/character/classes?locale=en_US", characterClassesResponse);

            var result = await warcraftCommunityClient.GetCharacterClassesAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("character_achievements.json")]
        public async void GetCharacterAchievementsAsyncTest(string characterAchievementsResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/data/character/achievements?locale=en_US", characterAchievementsResponse);

            var result = await warcraftCommunityClient.GetCharacterAchievementsAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("guild_rewards.json")]
        public async void GetGuildRewardsAsyncTest(string guildRewardsResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/data/guild/rewards?locale=en_US", guildRewardsResponse);

            var result = await warcraftCommunityClient.GetGuildRewardsAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("guild_perks.json")]
        public async void GetGuildPerksAsyncTest(string guildPerksResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/data/guild/perks?locale=en_US", guildPerksResponse);

            var result = await warcraftCommunityClient.GetGuildPerksAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("guild_achievements.json")]
        public async void GetGuildAchievementsAsyncTest(string guildAchievementsResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/data/guild/achievements?locale=en_US", guildAchievementsResponse);

            var result = await warcraftCommunityClient.GetGuildAchievementsAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("item_classes.json")]
        public async void GetItemClassesAsyncTest(string itemClassesResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/data/item/classes?locale=en_US", itemClassesResponse);

            var result = await warcraftCommunityClient.GetItemClassesAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("talents.json")]
        public async void GetTalentsAsyncTest(string talentsResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/data/talents?locale=en_US", talentsResponse);

            var result = await warcraftCommunityClient.GetTalentsAsync();
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("pet_types.json")]
        public async void GetPetTypesAsyncTest(string petTypesResponse)
        {
            var warcraftCommunityClient = BuildMockClient("https://us.api.blizzard.com/wow/data/pet/types?locale=en_US", petTypesResponse);

            var result = await warcraftCommunityClient.GetPetTypesAsync();
            Assert.NotNull(result.Value);
        }

        private static IWarcraftCommunityClient BuildMockClient(string requestUri, string responseContent, HttpStatusCode? statusCode = null)
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

            return new WarcraftCommunityClient("clientIdHere", "clientSecretHere", Region.Us, Locale.EnUs, mockHttp.ToHttpClient());
        }
    }
}
