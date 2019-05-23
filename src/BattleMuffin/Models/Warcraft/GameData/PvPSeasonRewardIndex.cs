using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PvPSeasonRewardIndex
    {
        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("season")]
        public PvPSeason? Season { get; set; }

        [JsonProperty("rewards")]
        public IEnumerable<PvPSeasonReward>? Rewards { get; set; }
    }
}
