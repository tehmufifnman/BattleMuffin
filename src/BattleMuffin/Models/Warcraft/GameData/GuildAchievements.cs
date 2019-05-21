using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildAchievements
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }
}
