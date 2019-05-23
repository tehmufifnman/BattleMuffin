using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneSeasonIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("seasons")]
        public IEnumerable<MythicKeystoneSeason>? Seasons { get; set; }

        [JsonProperty("current_season")]
        public MythicKeystoneSeason? CurrentSeason { get; set; }
    }
}
