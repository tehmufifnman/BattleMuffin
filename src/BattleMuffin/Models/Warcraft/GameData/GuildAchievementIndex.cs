using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildAchievementIndex
    {
        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("guild")]
        public Guild? Guild { get; set; }

        [JsonProperty("total_quantity")]
        public int TotalQuantity { get; set; }

        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        [JsonProperty("achievements")]
        public IEnumerable<GuildAchievement>? GuildAchievements { get; set; }

        [JsonProperty("category_progress")]
        public IEnumerable<AchievementCategoryProgress>? CategoryProgress { get; set; }

        [JsonProperty("recent_events")]
        public IEnumerable<GuildAchievementRecentEvent>? RecentEvents { get; set; }
    }
}
