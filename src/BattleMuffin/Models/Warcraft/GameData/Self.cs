using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Self
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }
}
