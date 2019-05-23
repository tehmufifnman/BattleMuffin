using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class RegionIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("regions")]
        public IList<Region>? Regions { get; set; }
    }
}
