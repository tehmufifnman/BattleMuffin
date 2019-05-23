using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Zone
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
