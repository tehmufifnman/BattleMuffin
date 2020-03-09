using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace BattleMuffin.Models
{
    [UsedImplicitly]
    public class AchievementCategoriesIndex
    {
        [UsedImplicitly]
        [JsonPropertyName("_links")]
        public Links? Links { get; set; }

        [UsedImplicitly]
        [JsonPropertyName("categories")]
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

        [UsedImplicitly]
        [JsonPropertyName("root_categories")]
        public IEnumerable<Category> RootCategories { get; set; } = new List<Category>();

        [UsedImplicitly]
        [JsonPropertyName("guild_categories")]
        public IEnumerable<Category> GuildCategories { get; set; } = new List<Category>();
    }
}
