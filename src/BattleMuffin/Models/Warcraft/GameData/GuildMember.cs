using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildMember
    {
        [JsonProperty("character")]
        public Character? Character { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
