using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicLeaderboards
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }
}
