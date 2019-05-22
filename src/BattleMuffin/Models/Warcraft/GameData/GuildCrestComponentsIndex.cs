using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildCrestComponentsIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("emblems")]
        public IList<GuildCrestEmblem>? Emblems { get; set; }

        [JsonProperty("borders")]
        public IList<GuildCrestBorder>? Borders { get; set; }
    }
}
