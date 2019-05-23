using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneLeaderboardIndex
    {
        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("current_leaderboards")]
        public IEnumerable<MythicKeystoneLeaderboard>? CurrentLeaderboards { get; set; }
    }
}
