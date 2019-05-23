using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PvPTierIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("tiers")]
        public IEnumerable<PvPTier>? Tiers { get; set; }
    }
}
