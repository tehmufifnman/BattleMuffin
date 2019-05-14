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
    ///     A client for the World of Warcraft Community & Game Data APIs.
    /// </summary>
    public class WarcraftClient : BaseClient, IWarcraftClient
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="WarcraftClient" /> class.
        /// </summary>
        /// <param name="clientId">The Blizzard OAuth client ID.</param>
        /// <param name="clientSecret">The Blizzard OAuth client secret.</param>
        /// <param name="region">Specifies the <see cref="Region" /> that the API will retrieve its data from.</param>
        /// <param name="locale">
        ///     Specifies the language that the result will be localized in. Visit
        ///     https://develop.battle.net/documentation/guides/regionality-partitions-and-localization
        ///     to see a list of available locales.
        /// </param>
        /// <param name="client">The <see cref="HttpClient" /> to use for all API requests.</param>
        public WarcraftClient(string clientId, string clientSecret, Region region = Region.US, Locale locale = Locale.en_US, HttpClient? client = null) : base(clientId, clientSecret, region, locale, client)
        {
        }

        /// <summary>
        ///     Returns data about an individual achievement.
        /// </summary>
        /// <param name="id">The ID of the achievement to retrieve.</param>
        /// <returns>
        ///     The specified achievement.
        /// </returns>
        public async Task<RequestResult<Achievement>> GetAchievementAsync(int id)
        {
            return await Get<Achievement>($"{Host}/wow/achievement/{id}?locale={Locale}");
        }

        /// <summary>
        ///     This API resource provides a per-realm list of recently generated auction house data dumps.
        /// </summary>
        /// <remarks>
        ///     Auction APIs currently provide rolling batches of data about current auctions. Fetching auction dumps
        ///     is a two-step process that involves checking a per-realm index file to determine if a recent dump has
        ///     been generated and then fetching the most recently generated dump file (if necessary).
        /// </remarks>
        /// <param name="realm">The realm to request.</param>
        /// <returns>
        ///     The specified auction house status.
        /// </returns>
        public async Task<RequestResult<AuctionDataStatus>> GetAuctionDataStatusAsync(string realm)
        {
            return await Get<AuctionDataStatus>($"{Host}/wow/auction/data/{realm}?locale={Locale}");
        }

        /// <summary>
        ///     Get the auction house data dump from the specified file.
        /// </summary>
        /// <param name="url">The URL for the auction house data dump.</param>
        /// <returns>
        ///     The auction house data dump from the specified file.
        /// </returns>
        public async Task<RequestResult<AuctionDataDump>> GetAuctionHouseDataDumpAsync(string url)
        {
            return await Get<AuctionDataDump>(url);
        }

        /// <summary>
        ///     Returns a list of battlegroups for the specified region.
        /// </summary>
        /// <returns>
        ///     A list of battlegroups for the specified region.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Battlegroup>>> GetBattlegroupsAsync()
        {
            return await Get<IEnumerable<Battlegroup>>($"{Host}/wow/data/battlegroups/?locale={Locale}", "battlegroups");
        }

        /// <summary>
        ///     The boss API provides information about bosses.
        ///     A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </summary>
        /// <param name="id">The ID of the boss to retrieve.</param>
        /// <returns>
        ///     The specified boss.
        /// </returns>
        public async Task<RequestResult<Boss>> GetBossAsync(int id)
        {
            return await Get<Boss>($"{Host}/wow/boss/{id}?locale={Locale}");
        }

        /// <summary>
        ///     Returns a list of all supported bosses.
        ///     A "boss" in this context should be considered a boss encounter, which may include more than one NPC.
        /// </summary>
        /// <returns>
        ///     A list of all supported bosses.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Boss>>> GetBossesAsync()
        {
            return await Get<IEnumerable<Boss>>($"{Host}/wow/boss/?locale={Locale}", "bosses");
        }

        /// <summary>
        ///     The region leaderboard has the exact same data format as the realm leaderboards except there is
        ///     no realm field. Instead, the response has the top 100 results gathered for each map for all of the
        ///     available realm leaderboards in a region.
        /// </summary>
        /// <returns>
        ///     The challenge mode leaderboard for the entire region.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Challenge>>> GetChallengesAsync()
        {
            return await Get<IEnumerable<Challenge>>($"{Host}/wow/challenge/region?locale={Locale}", "challenge");
        }

        /// <summary>
        ///     The request returns data for all nine challenge mode maps (currently). The map field includes the
        ///     current medal times for each dungeon. Each ladder provides data about each character that was part of
        ///     each run. The character data includes the current cached specialization of the character while the
        ///     member field includes the specialization of the character during the challenge mode run.
        /// </summary>
        /// <param name="realm">The realm to request.</param>
        /// <returns>
        ///     The challenge mode leaderboard for the specified realm.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Challenge>>> GetChallengesAsync(string realm)
        {
            return await Get<IEnumerable<Challenge>>($"{Host}/wow/challenge/{realm}?locale={Locale}", "challenge");
        }

        /// <summary>
        ///     The Character Profile API is the primary way to access character information. This API can be used to
        ///     fetch a single character at a time through an HTTP GET request to a URL describing the character
        ///     profile resource. By default, these requests return a basic dataset, and each request can return zero
        ///     or more additional fields. To access this API, craft a resource URL pointing to the desired character
        ///     for which to retrieve information.
        /// </summary>
        /// <param name="realm">
        ///     The character's realm.
        ///     Can be provided as the proper realm name or the normalized realm name.
        /// </param>
        /// <param name="characterName">The name of the character to retrieve.</param>
        /// <param name="fields">
        ///     The dataset to retrieve for the character. Each field value is explained in more detail in the
        ///     following requests. If no fields are specified the API will only return basic data about the character.
        ///     <seealso cref="CharacterFields" />
        /// </param>
        /// <returns>
        ///     The specified character profile and additional data.
        /// </returns>
        /// >
        public async Task<RequestResult<Character>> GetCharacterAsync(string realm, string characterName, CharacterFields fields = CharacterFields.None)
        {
            var queryStringFields = fields.BuildQueryString();
            return await Get<Character>($"{Host}/wow/character/{realm}/{characterName}?&locale={Locale}{queryStringFields}");
        }

        /// <summary>
        ///     Returns a list of all achievements that characters can earn as well as the category structure and hierarchy.
        /// </summary>
        /// <returns>
        ///     A list of all achievements that characters can earn as well as the category structure and hierarchy.
        /// </returns>
        public async Task<RequestResult<IEnumerable<AchievementCategory>>> GetCharacterAchievementsAsync()
        {
            return await Get<IEnumerable<AchievementCategory>>($"{Host}/wow/data/character/achievements?locale={Locale}", "achievements");
        }

        /// <summary>
        ///     Returns a list of character classes.
        /// </summary>
        /// <returns>
        ///     A list of character classes.
        /// </returns>
        public async Task<RequestResult<IEnumerable<CharacterClassData>>> GetCharacterClassesAsync()
        {
            return await Get<IEnumerable<CharacterClassData>>($"{Host}/wow/data/character/classes?locale={Locale}", "classes");
        }

        /// <summary>
        ///     Returns a list of races and their associated faction, name, unique ID, and skin.
        /// </summary>
        /// <returns>
        ///     A list of races and their associated faction, name, unique ID, and skin.
        /// </returns>
        public async Task<RequestResult<IEnumerable<CharacterRace>>> GetCharacterRacesAsync()
        {
            return await Get<IEnumerable<CharacterRace>>($"{Host}/wow/data/character/races?locale={Locale}", "races");
        }

        /// <summary>
        ///     The guild profile API is the primary way to access guild information. This API can fetch a single
        ///     guild at a time through an HTTP GET request to a URL describing the guild profile resource. By default,
        ///     these requests return a basic dataset and each request can retrieve zero or more additional fields.
        ///     Although this endpoint has no required query string parameters, requests can optionally pass the fields
        ///     query string parameter to indicate that one or more of the optional datasets is to be retrieved.
        ///     Those additional fields are listed in the method titled "Optional Fields".
        /// </summary>
        /// <param name="realm">The guild's realm.</param>
        /// <param name="guildName">The name of the guild to query.</param>
        /// <param name="fields">
        ///     The optional data to retrieve about the guild. Each field value is explained in more detail in the
        ///     following methods. If no fields are specified the API will only return basic guild data.
        ///     <seealso cref="GuildFields" />
        /// </param>
        /// <returns>
        ///     The specified guild profile and additional data.
        /// </returns>
        public async Task<RequestResult<Guild>> GetGuildAsync(string realm, string guildName, GuildFields fields = GuildFields.None)
        {
            var queryStringFields = fields.BuildQueryString();
            return await Get<Guild>($"{Host}/wow/guild/{realm}/{Uri.EscapeUriString(guildName)}?locale={Locale}{queryStringFields}");
        }

        /// <summary>
        ///     Returns a list of all guild achievements as well as the category structure and hierarchy.
        /// </summary>
        /// <returns>
        ///     A list of all guild achievements as well as the category structure and hierarchy.
        /// </returns>
        public async Task<RequestResult<IEnumerable<AchievementCategory>>> GetGuildAchievementsAsync()
        {
            return await Get<IEnumerable<AchievementCategory>>($"{Host}/wow/data/guild/achievements?locale={Locale}", "achievements");
        }

        /// <summary>
        ///     Returns a list of all guild perks.
        /// </summary>
        /// <returns>
        ///     A list of all guild perks.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Perk>>> GetGuildPerksAsync()
        {
            return await Get<IEnumerable<Perk>>($"{Host}/wow/data/guild/perks?locale={Locale}", "perks");
        }

        /// <summary>
        ///     The guild rewards data API provides a list of all guild rewards.
        /// </summary>
        /// <returns>
        ///     A list of all guild rewards.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Reward>>> GetGuildRewardsAsync()
        {
            return await Get<IEnumerable<Reward>>($"{Host}/wow/data/guild/rewards?locale={Locale}", "rewards");
        }

        /// <summary>
        ///     The item API provides detailed item information, including item set information.
        /// </summary>
        /// <param name="itemId">The requested item's unique ID.</param>
        /// <returns>
        ///     The specified item.
        /// </returns>
        public async Task<RequestResult<Item>> GetItemAsync(int itemId)
        {
            return await Get<Item>($"{Host}/wow/item/{itemId}?locale={Locale}");
        }

        /// <summary>
        ///     Returns a list of item classes.
        /// </summary>
        /// <returns>
        ///     A list of item classes.
        /// </returns>
        public async Task<RequestResult<IEnumerable<ItemClass>>> GetItemClassesAsync()
        {
            return await Get<IEnumerable<ItemClass>>($"{Host}/wow/data/item/classes?locale={Locale}", "classes");
        }

        /// <summary>
        ///     The item API provides detailed item information, including item set information.
        /// </summary>
        /// <param name="itemSetId">The requested set's unique ID.</param>
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
        ///     Returns a list of all supported battle and vanity pets.
        /// </summary>
        /// <returns>
        ///     A list of all supported battle and vanity pets.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Pet>>> GetPetsAsync()
        {
            return await Get<IEnumerable<Pet>>($"{Host}/wow/pet/?locale={Locale}", "pets");
        }

        /// <summary>
        ///     Returns data about a individual battle pet ability ID. This resource does not provide ability tooltips.
        /// </summary>
        /// <param name="abilityId">The ID of the ability to retrieve.</param>
        /// <returns>
        ///     The specified pet ability.
        /// </returns>
        public async Task<RequestResult<PetAbility>> GetPetAbilityAsync(int abilityId)
        {
            return await Get<PetAbility>($"{Host}/wow/pet/ability/{abilityId}?locale={Locale}");
        }

        /// <summary>
        ///     Returns data about an individual pet species. Use pets as the field value in a character profile
        ///     request to get species IDs. Each species also has data about its six abilities.
        /// </summary>
        /// <param name="speciesId">The species for which to retrieve data.</param>
        /// <returns>
        ///     The specified pet species.
        /// </returns>
        public async Task<RequestResult<PetSpecies>> GetPetSpeciesAsync(int speciesId)
        {
            return await Get<PetSpecies>($"{Host}/wow/pet/species/{speciesId}?locale={Locale}");
        }

        /// <summary>
        ///     Returns detailed information about a given species of pet.
        /// </summary>
        /// <param name="speciesId">
        ///     The pet's species ID. This can be found by querying a user's list of pets via the
        ///     Character Profile API.
        /// </param>
        /// <param name="level">
        ///     The pet's level. Pet levels max out at 25. If omitted,
        ///     the API assumes a default value of 1.
        /// </param>
        /// <param name="breedId">
        ///     The pet's breed. Retrievable via the Character Profile API.
        ///     If omitted the API assumes a default value of 3.
        /// </param>
        /// <param name="quality">
        ///     The pet's quality. Retrievable via the Character Profile API. Pet quality can range from 0 to 5
        ///     (0 is poor quality and 5 is legendary). If omitted, the API will assume a default value of 1.
        /// </param>
        /// <returns>
        ///     The pet stats for the specified pet species, level, breed, and quality.
        /// </returns>
        public async Task<RequestResult<PetStats>> GetPetStatsAsync(int speciesId, int level, int breedId, BattlePetQuality quality)
        {
            return await Get<PetStats>($"{Host}/wow/pet/stats/{speciesId}?level={level}&breedId={breedId}&qualityId={quality:D}&locale={Locale}");
        }

        /// <summary>
        ///     Returns a list of the different battle pet types, including what they are strong and weak against.
        /// </summary>
        /// <returns>
        ///     A list of the different battle pet types, including what they are strong and weak against.
        /// </returns>
        public async Task<RequestResult<IEnumerable<PetType>>> GetPetTypesAsync()
        {
            return await Get<IEnumerable<PetType>>($"{Host}/wow/data/pet/types?locale={Locale}", "petTypes");
        }

        /// <summary>
        ///     The Leaderboard API endpoint provides leaderboard information for the 2v2, 3v3, 5v5,
        ///     and Rated Battleground leaderboards.
        /// </summary>
        /// <param name="bracket">The type of leaderboard to retrieve. Valid entries are 2v2, 3v3, 5v5, and rbg.</param>
        /// <returns>
        ///     The specified PvP leaderboard.
        /// </returns>
        public async Task<RequestResult<PvpLeaderboard>> GetPvpLeaderboardAsync(string bracket)
        {
            return await Get<PvpLeaderboard>($"{Host}/wow/leaderboard/{bracket}?locale={Locale}");
        }

        /// <summary>
        ///     Returns metadata for a specified quest.
        /// </summary>
        /// <param name="questId">The ID of the quest to retrieve.</param>
        /// <returns>
        ///     Metadata for a specified quest.
        /// </returns>
        public async Task<RequestResult<Quest>> GetQuestAsync(int questId)
        {
            return await Get<Quest>($"{Host}/wow/quest/{questId}?locale={Locale}");
        }

        /// <summary>
        ///     The realm status API allows developers to retrieve realm status information. This information is
        ///     limited to whether or not the realm is up, the type and state of the realm, and the current population.
        ///     Although this endpoint has no required query string parameters, use the optional realms parameter to
        ///     limit the realms returned to a specific set of realms.
        /// </summary>
        /// <returns>
        ///     The statuses for all realms.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Realm>>> GetRealmStatusAsync()
        {
            return await Get<IEnumerable<Realm>>($"{Host}/wow/realm/status?locale={Locale}", "realms");
        }

        /// <summary>
        ///     Returns basic recipe information.
        /// </summary>
        /// <param name="recipeId">Unique ID for the desired recipe.</param>
        /// <returns>
        ///     The specified recipe information.
        /// </returns>
        public async Task<RequestResult<Recipe>> GetRecipeAsync(int recipeId)
        {
            return await Get<Recipe>($"{Host}/wow/recipe/{recipeId}?locale={Locale}");
        }

        /// <summary>
        ///     Returns information about spells.
        /// </summary>
        /// <param name="spellId">The ID of the spell to retrieve.</param>
        /// <returns>
        ///     The specified spell information.
        /// </returns>
        public async Task<RequestResult<Spell>> GetSpellAsync(int spellId)
        {
            return await Get<Spell>($"{Host}/wow/spell/{spellId}?locale={Locale}");
        }

        /// <summary>
        ///     Returns a list of talents, specs, and glyphs for each class.
        /// </summary>
        /// <returns>
        ///     A list of talents, specs, and glyphs for each class.
        /// </returns>
        public async Task<RequestResult<IDictionary<CharacterClass, TalentSet>>> GetTalentsAsync()
        {
            return await Get<IDictionary<CharacterClass, TalentSet>>($"{Host}/wow/data/talents?locale={Locale}");
        }

        /// <summary>
        ///     Returns information about zones.
        /// </summary>
        /// <param name="zoneId">The ID of the zone to retrieve.</param>
        /// <returns>
        ///     The specified zone information.
        /// </returns>
        public async Task<RequestResult<Zone>> GetZoneAsync(int zoneId)
        {
            return await Get<Zone>($"{Host}/wow/zone/{zoneId}?locale={Locale}");
        }

        /// <summary>
        ///     Returns a list of all supported zones and their bosses. A "zone" in this context should be considered
        ///     a dungeon or a raid, not a world zone. A "boss" in this context should be considered a boss encounter,
        ///     which may include more than one NPC.
        /// </summary>
        /// <returns>
        ///     A list of all supported zones and their bosses.
        /// </returns>
        public async Task<RequestResult<IEnumerable<Zone>>> GetZonesAsync()
        {
            return await Get<IEnumerable<Zone>>($"{Host}/wow/zone/?locale={Locale}", "zones");
        }
    }
}
