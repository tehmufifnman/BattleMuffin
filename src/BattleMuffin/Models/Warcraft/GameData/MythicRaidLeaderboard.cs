using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicRaidLeaderboard
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("criteria_type")]
        public string? CriteriaType { get; set; }

        [JsonProperty("zone")]
        public Zone? Zone { get; set; }

        [JsonProperty("entries")]
        public IEnumerable<MythicRaidLeaderboardEntry>? Entries { get; set; }
    }
}
