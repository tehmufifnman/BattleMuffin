using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneUpgrade
    {
        [JsonProperty("upgrade_level")]
        public int? UpgradeLevel { get; set; }

        [JsonProperty("qualifying_duration")]
        public int? QualifyingDuration { get; set; }
    }
}
