using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Achievement
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("category")]
        public AchievementCategory? Category { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("is_account_wide")]
        public bool IsAccountWide { get; set; }

        [JsonProperty("criteria")]
        public Criteria? Criteria { get; set; }

        [JsonProperty("next_achievement")]
        public Achievement? NextAchievement { get; set; }

        [JsonProperty("media")]
        public Media? Media { get; set; }

        [JsonProperty("display_order")]
        public int DisplayOrder { get; set; }
    }
}
