using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneAffix
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("media")]
        public Media? Media { get; set; }

        [JsonProperty("keystone_affix")]
        public MythicKeystoneAffix? KeystoneAffix { get; set; }

        [JsonProperty("starting_level")]
        public int StartingLevel { get; set; }
    }
}
