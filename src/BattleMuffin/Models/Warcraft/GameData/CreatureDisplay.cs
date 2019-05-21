using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class CreatureDisplay
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }
    }
}
