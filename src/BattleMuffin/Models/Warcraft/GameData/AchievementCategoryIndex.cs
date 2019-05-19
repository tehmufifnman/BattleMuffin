using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class AchievementCategoryIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("categories")]
        public IEnumerable<AchievementCategory>? Categories { get; set; }

        [JsonProperty("root_categories")]
        public IEnumerable<AchievementCategory>? RootCategories { get; set; }

        [JsonProperty("guild_categories")]
        public IEnumerable<AchievementCategory>? GuildCategories { get; set; }
    }
}
