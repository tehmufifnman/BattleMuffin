using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildRoster
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }
}
