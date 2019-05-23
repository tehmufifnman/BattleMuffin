using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneLeadingGroup
    {
        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("completed_timestamp")]
        public long CompletedTimestamp { get; set; }

        [JsonProperty("keystone_level")]
        public int KeystoneLevel { get; set; }

        [JsonProperty("members")]
        public IEnumerable<MythicKeystoneGroupMember>? Members { get; set; }
    }
}
