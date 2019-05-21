using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class AchievementCategory
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("achievements")]
        public IEnumerable<Achievement>? Achievements { get; set; }

        [JsonProperty("subcategories")]
        public IEnumerable<AchievementCategory>? Subcategories { get; set; }

        [JsonProperty("is_guild_category")]
        public bool IsGuildCategory { get; set; }

        [JsonProperty("aggregates_by_faction")]
        public AggregatesByFaction? AggregatesByFaction { get; set; }

        [JsonProperty("display_order")]
        public int DisplayOrder { get; set; }
    }
}
