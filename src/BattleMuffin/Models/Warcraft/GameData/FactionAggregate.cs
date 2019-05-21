using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class FactionAggregate
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }
    }
}
