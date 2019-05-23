using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PvPSeasonBracket
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}
