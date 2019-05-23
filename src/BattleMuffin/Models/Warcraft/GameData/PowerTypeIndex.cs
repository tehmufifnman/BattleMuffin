using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PowerTypeIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("power_types")]
        public IEnumerable<PowerType>? PowerTypes { get; set; }
    }
}
