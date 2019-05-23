using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PvPSeasonLeaderboardEntry
    {
        [JsonProperty("character")]
        public Character? Character { get; set; }

        [JsonProperty("faction")]
        public Faction? Faction { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("season_match_statistics")]
        public PvPSeasonMatchStatistics? SeasonMatchStatistics { get; set; }

        [JsonProperty("tier")]
        public PvPSeasonTier? Tier { get; set; }
    }
}
