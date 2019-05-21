using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Media
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("assets")]
        public IEnumerable<Asset>? Assets { get; set; }
    }
}
