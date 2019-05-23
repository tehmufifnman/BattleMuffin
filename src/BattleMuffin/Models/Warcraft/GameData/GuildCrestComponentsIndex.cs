using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildCrestComponentsIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("emblems")]
        public IEnumerable<GuildCrestEmblem>? Emblems { get; set; }

        [JsonProperty("borders")]
        public IEnumerable<GuildCrestBorder>? Borders { get; set; }
    }
}
