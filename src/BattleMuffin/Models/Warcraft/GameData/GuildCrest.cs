using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildCrest
    {
        [JsonProperty("emblem")]
        public GuildCrestEmblem? Emblem { get; set; }

        [JsonProperty("border")]
        public GuildCrestBorder? Border { get; set; }

        [JsonProperty("background")]
        public GuildCrestBackground? Background { get; set; }
    }
}
