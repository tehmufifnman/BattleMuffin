using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Criteria
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}
