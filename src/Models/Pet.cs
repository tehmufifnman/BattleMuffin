using System.Collections.Generic;
using BattleMuffin.Enums;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A pet.
    /// </summary>
    public class Pet
    {
        /// <summary>
        ///     Gets or sets a value indicating whether the pet is a battle pet.
        /// </summary>
        [JsonProperty("canBattle")]
        public bool CanBattle { get; set; }

        /// <summary>
        ///     Gets or sets the creature ID.
        /// </summary>
        [JsonProperty("creatureId")]
        public int CreatureId { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the family.
        /// </summary>
        [JsonProperty("family")]
        public string Family { get; set; }

        /// <summary>
        ///     Gets or sets the icon.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        ///     Gets or sets the quality.
        /// </summary>
        [JsonProperty("qualityId")]
        public BattlePetQuality Quality { get; set; }

        /// <summary>
        ///     Gets or sets the stats.
        /// </summary>
        [JsonProperty("stats")]
        public PetStats Stats { get; set; }

        /// <summary>
        ///     Gets or sets the pet families that this pet is strong against.
        /// </summary>
        [JsonProperty("strongAgainst")]
        public IEnumerable<string> StrongAgainst { get; set; }

        /// <summary>
        ///     Gets or sets the type ID.
        /// </summary>
        [JsonProperty("typeId")]
        public int TypeId { get; set; }

        /// <summary>
        ///     Gets or sets the pet families that this pet is weak against.
        /// </summary>
        [JsonProperty("weakAgainst")]
        public IEnumerable<string> WeakAgainst { get; set; }
    }
}
