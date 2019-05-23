using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystonePeriodIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("periods")]
        public IEnumerable<MythicKeystonePeriod>? Periods { get; set; }

        [JsonProperty("current_period")]
        public MythicKeystonePeriod? CurrentPeriod { get; set; }
    }
}
