using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildCrestEmblem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("color")]
        public Color? Color { get; set; }

        [JsonProperty("media")]
        public Media? Media { get; set; }
    }
}
