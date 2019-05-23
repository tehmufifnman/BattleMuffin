using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class BattlePetAbility
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("ability")]
        public BattlePetAbility? Ability { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("required_level")]
        public int RequiredLevel { get; set; }
    }
}
