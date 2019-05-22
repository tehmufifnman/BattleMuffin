using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildRoster
    {
        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("guild")]
        public Guild? Guild { get; set; }

        [JsonProperty("members")]
        public IEnumerable<GuildMember>? Members { get; set; }
    }
}
