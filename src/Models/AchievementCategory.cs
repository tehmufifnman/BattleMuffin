using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     An achievement category.
    /// </summary>
    public class AchievementCategory
    {
        /// <summary>
        ///     Gets or sets the achievment category ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the achievements belonging to this category.
        /// </summary>
        [JsonProperty("achievements")]
        public IEnumerable<Achievement> Achievements { get; set; }

        /// <summary>
        ///     Gets or sets the subcategories belonging to this category.
        /// </summary>
        [JsonProperty("categories")]
        public IEnumerable<AchievementCategory> Categories { get; set; }

        /// <summary>
        ///     Gets or sets the achievment category name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
