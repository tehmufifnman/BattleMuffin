using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class AggregatesByFaction
    {
        [JsonProperty("alliance")]
        public FactionAggregate? Alliance { get; set; }

        [JsonProperty("horde")]
        public FactionAggregate? Horde { get; set; }
    }
}
