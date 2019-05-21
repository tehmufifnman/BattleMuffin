using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Guild
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("faction")]
        public Faction? Faction { get; set; }

        [JsonProperty("achievement_points")]
        public int AchievementPoints { get; set; }

        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        [JsonProperty("realm")]
        public Realm? Realm { get; set; }

        [JsonProperty("crest")]
        public GuildCrest? Crest { get; set; }

        [JsonProperty("roster")]
        public GuildRoster? Roster { get; set; }

        [JsonProperty("achievements")]
        public GuildAchievements? Achievements { get; set; }

        [JsonProperty("created_timestamp")]
        public long CreatedTimestamp { get; set; }
    }
}
