using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BattleMuffin.Enums;
using BattleMuffin.Extensions;
using BattleMuffin.Models;
using BattleMuffin.Web;

namespace BattleMuffin.Clients
{
    /// <summary>
    ///     A client for the World of Warcraft Community APIs.
    /// </summary>
    public class WarcraftClient : Client, IWarcraftClient
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="WarcraftClient" /> class.
        /// </summary>
        /// <param name="clientId">The Blizzard OAuth client ID.</param>
        /// <param name="clientSecret">The Blizzard OAuth client secret.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">
        ///     Specifies the language that the result will be in. Visit
        ///     https://dev.battle.net/docs/read/community_apis to see a list of available locales.
        /// </param>
        public WarcraftClient(string clientId, string clientSecret, Region region = Region.US, Locale locale = Locale.en_US) : this(clientId, clientSecret, region, locale, InternalHttpClient.Instance)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WarcraftClient" /> class.
        /// </summary>
        /// <param name="clientId">The Blizzard OAuth client ID.</param>
        /// <param name="clientSecret">The Blizzard OAuth client secret.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">
        ///     Specifies the language that the result will be in. Visit
        ///     https://dev.battle.net/docs/read/community_apis to see a list of available locales.
        /// </param>
        /// <param name="client">The <see cref="HttpClient" /> that communicates with Blizzard.</param>
        public WarcraftClient(string clientId, string clientSecret, Region region, Locale locale, HttpClient client) : base(clientId, clientSecret, region, locale, client)
        {
        }

        /// <summary>
        ///     Get the specified achievement.
        /// </summary>
        /// <param name="id">The achievement ID.</param>
        /// <returns>
        ///     The specified achievement.
        /// </returns>
        public async Task<RequestResult<Achievement>> GetAchievementAsync(int id)
        {
            return await Get<Achievement>($"{Host}/wow/achievement/{id}?locale={Locale}");
        }

        /// <summary>
        ///     Get the specified auction.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <returns>
        ///     The specified auction.
        /// </returns>
        public async Task<RequestResult<AuctionFiles>> GetAuctionAsync(string realm)
        {
            return await Get<AuctionFiles>($"{Host}/wow/auction/data/{realm}?locale={Locale}");
        }

        /// <summary>
        ///     Get the auction house snapshot from the specified file.
        /// </summary>
        /// <param name="url">The URL for the auction house file.</param>
        /// <returns>
        ///     The auction house snapshot from the specified file.
        /// </returns>
        public async Task<RequestResult<AuctionHouseSnapshot>> GetAuctionHouseSnapshotAsync(string url)
        {
            return await Get<AuctionHouseSnapshot>(url);
        }

        /// <summary>
        ///     Get a list of all supported battlegroups.
        /// </summary>
        /// <returns>
        ///     A list of all supported battlegroups.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Battlegroup>>> GetBattlegroupsAsync()
        {
            return await Get<IEnumerable<Battlegroup>>($"{Host}/wow/data/battlegroups/?locale={Locale}", "battlegroups");
        }

        /// <summary>
        ///     Get the specified boss.
        /// </summary>
        /// <remarks>
        ///     A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <param name="id">The boss ID.</param>
        /// <returns>
        ///     The specified boss.
        /// </returns>
        public async Task<RequestResult<Boss>> GetBossAsync(int id)
        {
            return await Get<Boss>($"{Host}/wow/boss/{id}?locale={Locale}");
        }

        /// <summary>
        ///     Get a list of all supported bosses.
        /// </summary>
        /// <remarks>
        ///     A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </remarks>
        /// <returns>
        ///     A list of all supported bosses.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Boss>>> GetBossesAsync()
        {
            return await Get<IEnumerable<Boss>>($"{Host}/wow/boss/?locale={Locale}", "bosses");
        }

        /// <summary>
        ///     Get the challenge mode data for the entire region.
        /// </summary>
        /// <returns>
        ///     The challenge mode data for the entire region.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Challenge>>> GetChallengesAsync()
        {
            return await Get<IEnumerable<Challenge>>($"{Host}/wow/challenge/region?locale={Locale}", "challenge");
        }

        /// <summary>
        ///     Get the challenge mode data for the specified realm.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <returns>
        ///     The challenge mode data for the specified realm.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Challenge>>> GetChallengesAsync(string realm)
        {
            return await Get<IEnumerable<Challenge>>($"{Host}/wow/challenge/{realm}?locale={Locale}", "challenge");
        }

        /// <summary>
        ///     Get the specified character.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="characterName">The character name.</param>
        /// <param name="fields">The character fields to include.</param>
        /// <returns>
        ///     The specified character.
        /// </returns>
        /// >
        public async Task<RequestResult<Character>> GetCharacterAsync(string realm, string characterName, CharacterFields fields = CharacterFields.None)
        {
            var queryStringFields = fields.BuildQueryString();
            return await Get<Character>($"{Host}/wow/character/{realm}/{characterName}?&locale={Locale}{queryStringFields}");
        }

        /// <summary>
        ///     Get a list of all of the achievements that characters can earn as well as the category structure and hierarchy.
        /// </summary>
        /// <returns>
        ///     A list of all of the achievements that characters can earn as well as the category structure and hierarchy.
        /// </returns>
        public async Task<RequestResult<IEnumerable<AchievementCategory>>> GetCharacterAchievementsAsync()
        {
            return await Get<IEnumerable<AchievementCategory>>($"{Host}/wow/data/character/achievements?locale={Locale}", "achievements");
        }

        /// <summary>
        ///     Get a list of all supported character classes.
        /// </summary>
        /// <returns>
        ///     A list of all supported character classes.
        /// </returns>
        public async Task<RequestResult<IEnumerable<CharacterClassData>>> GetCharacterClassesAsync()
        {
            return await Get<IEnumerable<CharacterClassData>>($"{Host}/wow/data/character/classes?locale={Locale}", "classes");
        }

        /// <summary>
        ///     Get a list of all supported character races.
        /// </summary>
        /// <returns>
        ///     A list of all supported character races.
        /// </returns>
        public async Task<RequestResult<IEnumerable<CharacterRace>>> GetCharacterRacesAsync()
        {
            return await Get<IEnumerable<CharacterRace>>($"{Host}/wow/data/character/races?locale={Locale}", "races");
        }

        /// <summary>
        ///     Get the specified guild.
        /// </summary>
        /// <param name="realm">The realm.</param>
        /// <param name="guildName">The guild name.</param>
        /// <param name="fields">The guild fields to include.</param>
        /// <returns>
        ///     The specified guild.
        /// </returns>
        public async Task<RequestResult<Guild>> GetGuildAsync(string realm, string guildName, GuildFields fields = GuildFields.None)
        {
            var queryStringFields = fields.BuildQueryString();
            return await Get<Guild>($"{Host}/wow/guild/{realm}/{Uri.EscapeUriString(guildName)}?locale={Locale}{queryStringFields}");
        }

        /// <summary>
        ///     Get a list of all guild achievements.
        /// </summary>
        /// <returns>
        ///     A list of all guild achievements.
        /// </returns>
        public async Task<RequestResult<IEnumerable<AchievementCategory>>> GetGuildAchievementsAsync()
        {
            return await Get<IEnumerable<AchievementCategory>>($"{Host}/wow/data/guild/achievements?locale={Locale}", "achievements");
        }

        /// <summary>
        ///     Get a list of all guild perks.
        /// </summary>
        /// <returns>
        ///     A list of all guild perks.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Perk>>> GetGuildPerksAsync()
        {
            return await Get<IEnumerable<Perk>>($"{Host}/wow/data/guild/perks?locale={Locale}", "perks");
        }

        /// <summary>
        ///     Get a list of all guild rewards.
        /// </summary>
        /// <returns>
        ///     A list of all guild rewards.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Reward>>> GetGuildRewardsAsync()
        {
            return await Get<IEnumerable<Reward>>($"{Host}/wow/data/guild/rewards?locale={Locale}", "rewards");
        }

        /// <summary>
        ///     Get the specified item.
        /// </summary>
        /// <param name="itemId">The item ID.</param>
        /// <returns>
        ///     The specified item.
        /// </returns>
        public async Task<RequestResult<Item>> GetItemAsync(int itemId)
        {
            return await Get<Item>($"{Host}/wow/item/{itemId}?locale={Locale}");
        }

        /// <summary>
        ///     Get a list of all item classes.
        /// </summary>
        /// <returns>
        ///     A list of all item classes.
        /// </returns>
        public async Task<RequestResult<IEnumerable<ItemClass>>> GetItemClassesAsync()
        {
            return await Get<IEnumerable<ItemClass>>($"{Host}/wow/data/item/classes?locale={Locale}", "classes");
        }

        /// <summary>
        ///     Get the specified item set.
        /// </summary>
        /// <param name="itemSetId">The item set ID.</param>
        /// <returns>
        ///     The specified item set.
        /// </returns>
        public async Task<RequestResult<ItemSet>> GetItemSetAsync(int itemSetId)
        {
            return await Get<ItemSet>($"{Host}/wow/item/set/{itemSetId}?locale={Locale}");
        }

        /// <summary>
        ///     Get a list of all supported mounts.
        /// </summary>
        /// <returns>
        ///     A list of all supported mounts.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Mount>>> GetMountsAsync()
        {
            return await Get<IEnumerable<Mount>>($"{Host}/wow/mount/?locale={Locale}", "mounts");
        }

        /// <summary>
        ///     Get a list of all supported pets.
        /// </summary>
        /// <returns>
        ///     A list of all supported pets.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Pet>>> GetPetsAsync()
        {
            return await Get<IEnumerable<Pet>>($"{Host}/wow/pet/?locale={Locale}", "pets");
        }

        /// <summary>
        ///     Get the specified pet ability.
        /// </summary>
        /// <param name="abilityId">The pet ability ID.</param>
        /// <returns>
        ///     The specified pet ability.
        /// </returns>
        public async Task<RequestResult<PetAbility>> GetPetAbilityAsync(int abilityId)
        {
            return await Get<PetAbility>($"{Host}/wow/pet/ability/{abilityId}?locale={Locale}");
        }

        /// <summary>
        ///     Get the specified pet species.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <returns>
        ///     The specified pet species.
        /// </returns>
        public async Task<RequestResult<PetSpecies>> GetPetSpeciesAsync(int speciesId)
        {
            return await Get<PetSpecies>($"{Host}/wow/pet/species/{speciesId}?locale={Locale}");
        }

        /// <summary>
        ///     Get the pet stats for the specified pet species, level, breed, and quality.
        /// </summary>
        /// <param name="speciesId">The pet species ID.</param>
        /// <param name="level">The pet level.</param>
        /// <param name="breedId">The breed ID.</param>
        /// <param name="quality">The quality.</param>
        /// <returns>
        ///     The pet stats for the specified pet species, level, breed, and quality.
        /// </returns>
        public async Task<RequestResult<PetStats>> GetPetStatsAsync(int speciesId, int level, int breedId, BattlePetQuality quality)
        {
            return await Get<PetStats>($"{Host}/wow/pet/stats/{speciesId}?level={level}&breedId={breedId}&qualityId={quality:D}&locale={Locale}");
        }

        /// <summary>
        ///     Get a list of all pet types.
        /// </summary>
        /// <returns>
        ///     A list of all pet types.
        /// </returns>
        public async Task<RequestResult<IEnumerable<PetType>>> GetPetTypesAsync()
        {
            return await Get<IEnumerable<PetType>>($"{Host}/wow/data/pet/types?locale={Locale}", "petTypes");
        }

        /// <summary>
        ///     Get the PvP leaderboard for the specified bracket.
        /// </summary>
        /// <param name="bracket">The PvP leaderboard bracket.  Valid entries are 2v2, 3v3, 5v5, and rbg.</param>
        /// <returns>
        ///     The PvP leaderboard for the specified bracket.
        /// </returns>
        public async Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(string bracket)
        {
            return await Get<PvpLeaderboard>($"{Host}/wow/leaderboard/{bracket}?locale={Locale}");
        }

        /// <summary>
        ///     Get the specified quest.
        /// </summary>
        /// <param name="questId">The quest ID.</param>
        /// <returns>
        ///     The specified quest.
        /// </returns>
        public async Task<RequestResult<Quest>> GetQuestAsync(int questId)
        {
            return await Get<Quest>($"{Host}/wow/quest/{questId}?locale={Locale}");
        }

        /// <summary>
        ///     Get the statuses for all realms.
        /// </summary>
        /// <returns>
        ///     The statuses for all realms.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Realm>>> GetRealmStatusAsync()
        {
            return await Get<IEnumerable<Realm>>($"{Host}/wow/realm/status?locale={Locale}", "realms");
        }

        /// <summary>
        ///     Get the specified recipe.
        /// </summary>
        /// <param name="recipeId">The recipe ID.</param>
        /// <returns>
        ///     The specified recipe.
        /// </returns>
        public async Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId)
        {
            return await Get<Recipe>($"{Host}/wow/recipe/{recipeId}?locale={Locale}");
        }

        /// <summary>
        ///     Get the specified spell.
        /// </summary>
        /// <param name="spellId">The spell ID.</param>
        /// <returns>
        ///     The specified spell.
        /// </returns>
        public async Task<RequestResult<Spell>> GetSpellAsync(int spellId)
        {
            return await Get<Spell>($"{Host}/wow/spell/{spellId}?locale={Locale}");
        }

        /// <summary>
        ///     Get a dictionary of talents, indexed by character class.
        /// </summary>
        /// <returns>
        ///     A dictionary of talents, indexed by character class.
        /// </returns>
        public async Task<RequestResult<IDictionary<CharacterClass, TalentSet>>> GetTalentsAsync()
        {
            return await Get<IDictionary<CharacterClass, TalentSet>>($"{Host}/wow/data/talents?locale={Locale}");
        }

        /// <summary>
        ///     Get the specified zone.
        /// </summary>
        /// <param name="zoneId">The zone ID.</param>
        /// <returns>
        ///     The specified zone.
        /// </returns>
        public async Task<RequestResult<Zone>> GetZoneAsync(int zoneId)
        {
            return await Get<Zone>($"{Host}/wow/zone/{zoneId}?locale={Locale}");
        }

        /// <summary>
        ///     Get a list of all supported zones.
        /// </summary>
        /// <returns>
        ///     A list of all supported zones.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Zone>>> GetZonesAsync()
        {
            return await Get<IEnumerable<Zone>>($"{Host}/wow/zone/?locale={Locale}", "zones");
        }
    }
}
