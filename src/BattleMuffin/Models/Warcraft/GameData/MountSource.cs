using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MountSource
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
