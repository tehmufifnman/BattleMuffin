using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneDungeonIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("dungeons")]
        public IEnumerable<MythicKeystoneDungeon>? Dungeons { get; set; }
    }
}
