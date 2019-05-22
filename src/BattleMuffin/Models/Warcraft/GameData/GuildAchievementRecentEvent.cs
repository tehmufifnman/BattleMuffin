using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildAchievementRecentEvent
    {
        [JsonProperty("achievement")]
        public Achievement? Achievement { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
