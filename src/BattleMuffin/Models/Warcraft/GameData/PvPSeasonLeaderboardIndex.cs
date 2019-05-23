using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PvPSeasonLeaderboardIndex
    {
        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("season")]
        public PvPSeason? Season { get; set; }

        [JsonProperty("leaderboards")]
        public IEnumerable<PvPSeasonLeaderboard>? Leaderboards { get; set; }
    }
}
