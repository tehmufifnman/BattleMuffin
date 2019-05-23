using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class WoWTokenIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("last_updated_timestamp")]
        public long LastUpdatedTimestamp { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }
    }
}
