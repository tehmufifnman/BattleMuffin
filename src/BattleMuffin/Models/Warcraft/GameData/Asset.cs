using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Asset
    {
        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}
