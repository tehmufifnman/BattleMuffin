using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneAffixIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("affixes")]
        public IEnumerable<MythicKeystoneAffix>? Affixes { get; set; }
    }
}
