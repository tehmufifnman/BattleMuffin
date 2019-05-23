using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicRaidLeaderboardEntry
    {
        [JsonProperty("guild")]
        public Guild? Guild { get; set; }

        [JsonProperty("faction")]
        public Faction? Faction { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("region")]
        public string? Region { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
