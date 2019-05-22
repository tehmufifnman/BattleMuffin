using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class GuildAchievement
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("achievement")]
        public Achievement? Achievement { get; set; }

        [JsonProperty("criteria")]
        public Criteria? Criteria { get; set; }

        [JsonProperty("completed_timestamp")]
        public long CompletedTimestamp { get; set; }
    }
}
