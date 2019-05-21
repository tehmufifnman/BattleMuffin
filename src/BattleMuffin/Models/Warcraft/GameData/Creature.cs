using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Creature
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("type")]
        public CreatureType? Type { get; set; }

        [JsonProperty("family")]
        public CreatureFamily? Family { get; set; }

        [JsonProperty("creature_displays")]
        public IEnumerable<CreatureDisplay>? CreatureDisplays { get; set; }

        [JsonProperty("is_tameable")]
        public bool IsTameable { get; set; }
    }
}
