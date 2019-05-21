using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class CreatureFamilyIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("creature_families")]
        public IEnumerable<CreatureFamily>? CreatureFamilies { get; set; }
    }
}
