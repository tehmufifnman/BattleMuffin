using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MountIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("mounts")]
        public IEnumerable<Mount>? Mounts { get; set; }
    }
}
