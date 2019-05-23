using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PvPSeasonLeaderboard
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("season")]
        public PvPSeason? Season { get; set; }

        [JsonProperty("bracket")]
        public PvPSeasonBracket? Bracket { get; set; }

        [JsonProperty("entries")]
        public IEnumerable<PvPSeasonLeaderboardEntry>? Entries { get; set; }
    }
}
