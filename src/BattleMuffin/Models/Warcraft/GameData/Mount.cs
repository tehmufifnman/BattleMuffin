using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Mount
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("creature_displays")]
        public IEnumerable<CreatureDisplay>? CreatureDisplays { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("source")]
        public MountSource? Source { get; set; }
    }
}
