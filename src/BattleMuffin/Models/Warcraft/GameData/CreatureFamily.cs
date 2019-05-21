using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class CreatureFamily
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
