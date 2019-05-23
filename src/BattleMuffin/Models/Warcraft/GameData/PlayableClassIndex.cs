using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PlayableClassIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("classes")]
        public IEnumerable<PlayableClass>? Classes { get; set; }
    }
}
