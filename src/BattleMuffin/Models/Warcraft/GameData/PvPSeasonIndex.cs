using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PvPSeasonIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("seasons")]
        public IEnumerable<PvPSeason>? Seasons { get; set; }

        [JsonProperty("current_season")]
        public PvPSeason? CurrentSeason { get; set; }
    }
}
