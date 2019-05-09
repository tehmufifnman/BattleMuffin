using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A boss.
    /// </summary>
    public class Boss : IWarcraftModel
    {
        /// <summary>
        ///     Gets a value indicating whether the boss is available in heroic mode.
        /// </summary>
        [JsonProperty(PropertyName = "availableInHeroicMode")]
        public bool AvailableInHeroicMode { get; set; }

        /// <summary>
        ///     Gets a value indicating whether the boss is available in normal mode.
        /// </summary>
        [JsonProperty(PropertyName = "availableInNormalMode")]
        public bool AvailableInNormalMode { get; set; }

        /// <summary>
        ///     Gets the description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Gets the health.
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public int Health { get; set; }

        /// <summary>
        ///     Gets the heroic health.
        /// </summary>
        [JsonProperty(PropertyName = "heroicHealth")]
        public int HeroicHealth { get; set; }

        /// <summary>
        ///     Gets the heroic level.
        /// </summary>
        [JsonProperty(PropertyName = "heroicLevel")]
        public int HeroicLevel { get; set; }

        /// <summary>
        ///     Gets the boss ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets the journal ID.
        /// </summary>
        [JsonProperty(PropertyName = "journalId")]
        public int JournalId { get; set; }

        /// <summary>
        ///     Gets the level.
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        /// <summary>
        ///     Gets the location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public Location? Location { get; set; }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Gets the NPCs in the boss encounter.
        /// </summary>
        [JsonProperty(PropertyName = "npcs")]
        public IEnumerable<Npc>? Npcs { get; set; }

        /// <summary>
        ///     Gets the URL slug.
        /// </summary>
        [JsonProperty(PropertyName = "urlSlug")]
        public string? UrlSlug { get; set; }

        /// <summary>
        ///     Gets the zone ID.
        /// </summary>
        [JsonProperty(PropertyName = "zoneId")]
        public int ZoneId { get; set; }

        /// <summary>
        ///     Gets the encounter faction.
        /// </summary>
        [JsonProperty(PropertyName = "encounterFaction")]
        public int EncounterFaction { get; set; }
    }
}
