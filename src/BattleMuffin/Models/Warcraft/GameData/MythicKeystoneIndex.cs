using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("seasons")]
        public MythicKeystoneSeason? Seasons { get; set; }

        [JsonProperty("dungeons")]
        public MythicKeystoneDungeon? Dungeons { get; set; }
    }
}
