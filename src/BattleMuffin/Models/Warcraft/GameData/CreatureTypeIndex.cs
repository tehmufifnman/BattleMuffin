using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class CreatureTypeIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("creature_types")]
        public IEnumerable<CreatureType>? CreatureTypes { get; set; }
    }
}
