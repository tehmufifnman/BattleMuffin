using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     Achievements.
    /// </summary>
    public class Achievements : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the IDs of the achievements completed by this character.
        /// </summary>
        [JsonProperty("achievementsCompleted")]
        public IEnumerable<int>? AchievementsCompleted { get; set; }

        /// <summary>
        ///     Gets or sets the timestamps of when the achievements were completed.
        /// </summary>
        [JsonProperty("achievementsCompletedTimestamp")]
        public IEnumerable<DateTime>? AchievementsCompletedTimestamp { get; set; }

        /// <summary>
        ///     Gets or sets the criteria.
        /// </summary>
        [JsonProperty("criteria")]
        public IEnumerable<int>? Criteria { get; set; }

        /// <summary>
        ///     Gets or sets the criteria quantity.
        /// </summary>
        [JsonProperty("criteriaQuantity")]
        public IEnumerable<long>? CriteriaQuantity { get; set; }

        /// <summary>
        ///     Gets or sets the criteria timestamp.
        /// </summary>
        [JsonProperty("criteriaTimestamp")]
        public IEnumerable<DateTime>? CriteriaTimestamp { get; set; }

        /// <summary>
        ///     Gets or sets the criteria created.
        /// </summary>
        [JsonProperty("criteriaCreated")]
        public IEnumerable<long>? CriteriaCreated { get; set; }
    }
}
