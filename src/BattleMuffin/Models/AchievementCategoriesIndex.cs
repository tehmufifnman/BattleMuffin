using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BattleMuffin.Models
{
    public class AchievementCategoriesIndex
    {
        [JsonPropertyName("_links")]
        public Links? Links { get; set; }

        [JsonPropertyName("categories")]
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

        [JsonPropertyName("root_categories")]
        public IEnumerable<Category> RootCategories { get; set; } = new List<Category>();

        [JsonPropertyName("guild_categories")]
        public IEnumerable<Category> GuildCategories { get; set; } = new List<Category>();
    }
}
