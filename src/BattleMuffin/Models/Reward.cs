using System.Collections.Generic;
using BattleMuffin.Enums;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A guild reward.
    /// </summary>
    public class Reward : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the minimum guild level.
        /// </summary>
        [JsonProperty("minGuildLevel")]
        public int MinGuildLevel { get; set; }

        /// <summary>
        ///     Gets or sets the minimum guild reputation level.
        /// </summary>
        [JsonProperty("minGuildRepLevel")]
        public int MinGuildRepLevel { get; set; }

        /// <summary>
        ///     Gets or sets the achievement associated with the reward.
        /// </summary>
        [JsonProperty("achievement")]
        public Achievement? Achievement { get; set; }

        /// <summary>
        ///     Gets or sets the reward item.
        /// </summary>
        [JsonProperty("item")]
        public CharacterItem? Item { get; set; }

        /// <summary>
        ///     Gets or sets the races.
        /// </summary>
        [JsonProperty("races")]
        public IEnumerable<Race>? Races { get; set; }
    }
}
