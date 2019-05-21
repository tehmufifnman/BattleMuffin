using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildCrestBackground
    {
        [JsonProperty("color")]
        public Color? Color { get; set; }
    }
}
