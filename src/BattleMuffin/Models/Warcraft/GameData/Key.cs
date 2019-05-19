using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Key
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }
}
