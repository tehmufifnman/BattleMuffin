using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Links
    {
        [JsonProperty("self")]
        public Self? Self { get; set; }
    }
}
