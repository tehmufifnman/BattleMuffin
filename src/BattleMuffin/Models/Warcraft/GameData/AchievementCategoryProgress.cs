using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class AchievementCategoryProgress
    {
        [JsonProperty("category")]
        public AchievementCategory? Category { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }
    }
}
