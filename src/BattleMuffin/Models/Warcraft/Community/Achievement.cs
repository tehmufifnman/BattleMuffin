using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     An achievement.
    /// </summary>
    public class Achievement : IWarcraftModel
    {
        /// <summary>
        ///     Gets a value indicating whether the achievement is account-wide.
        /// </summary>
        [JsonProperty(PropertyName = "accountWide")]
        public bool AccountWide { get; set; }

        /// <summary>
        ///     Gets the achievement criteria.
        /// </summary>
        [JsonProperty(PropertyName = "criteria")]
        public IEnumerable<Criterion>? Criteria { get; set; }

        /// <summary>
        ///     Gets the achievement description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Gets the faction ID.
        /// </summary>
        [JsonProperty(PropertyName = "factionId")]
        public int FactionId { get; set; }

        /// <summary>
        ///     Gets the name of the icon for the achievement.
        /// </summary>
        [JsonProperty(PropertyName = "icon")]
        public string? Icon { get; set; }

        /// <summary>
        ///     Gets the achievement ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets the number of achievement points for this achievement.
        /// </summary>
        [JsonProperty(PropertyName = "points")]
        public int Points { get; set; }

        /// <summary>
        ///     Gets the name of the achievement reward.
        /// </summary>
        [JsonProperty(PropertyName = "reward")]
        public string? Reward { get; set; }

        /// <summary>
        ///     Gets the reward items.
        /// </summary>
        [JsonProperty(PropertyName = "rewardItems")]
        public IEnumerable<CharacterItem>? RewardItems { get; set; }

        /// <summary>
        ///     Gets the achievement title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string? Title { get; set; }
    }
}
