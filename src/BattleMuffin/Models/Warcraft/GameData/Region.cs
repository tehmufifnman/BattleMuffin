using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Region
    {
        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links?Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("tag")]
        public string? Tag { get; set; }
    }
}
