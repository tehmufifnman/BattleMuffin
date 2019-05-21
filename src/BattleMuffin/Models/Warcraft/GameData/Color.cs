using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Color
    {
        [JsonProperty("r")]
        public int R { get; set; }

        [JsonProperty("g")]
        public int G { get; set; }

        [JsonProperty("b")]
        public int B { get; set; }

        [JsonProperty("a")]
        public double A { get; set; }
    }
}
