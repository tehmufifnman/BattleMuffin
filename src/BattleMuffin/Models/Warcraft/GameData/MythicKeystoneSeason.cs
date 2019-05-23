using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneSeason
    {
        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("start_timestamp")]
        public long StartTimestamp { get; set; }

        [JsonProperty("end_timestamp")]
        public long EndTimestamp { get; set; }

        [JsonProperty("periods")]
        public IEnumerable<MythicKeystonePeriod>? Periods { get; set; }
    }
}
