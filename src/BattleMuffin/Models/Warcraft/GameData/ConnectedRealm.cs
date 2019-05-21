using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class ConnectedRealm
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }
}
