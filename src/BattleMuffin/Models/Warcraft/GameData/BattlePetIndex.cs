using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class BattlePetIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("pets")]
        public IEnumerable<BattlePet>? Pets { get; set; }
    }
}
