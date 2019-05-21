using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Realm
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("region")]
        public ConnectedRealmRegion? Region { get; set; }

        [JsonProperty("connected_realm")]
        public ConnectedRealm? ConnectedRealm { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("category")]
        public string? Category { get; set; }

        [JsonProperty("locale")]
        public string? Locale { get; set; }

        [JsonProperty("timezone")]
        public string? Timezone { get; set; }

        [JsonProperty("type")]
        public ConnectedRealmType? Type { get; set; }

        [JsonProperty("is_tournament")]
        public bool IsTournament { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }
    }
}
