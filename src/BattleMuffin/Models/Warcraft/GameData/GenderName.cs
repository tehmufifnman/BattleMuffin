using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GenderName
    {
        [JsonProperty("male")]
        public string? Male { get; set; }

        [JsonProperty("female")]
        public string? Female { get; set; }
    }
}
