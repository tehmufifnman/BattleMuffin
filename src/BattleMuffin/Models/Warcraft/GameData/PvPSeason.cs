using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PvPSeason
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("leaderboards")]
        public PvPSeasonLeaderboardIndex? Leaderboards { get; set; }

        [JsonProperty("rewards")]
        public PvPSeasonRewardIndex? Rewards { get; set; }

        [JsonProperty("season_start_timestamp")]
        public long SeasonStartTimestamp { get; set; }
    }
}
