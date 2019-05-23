using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class ConnectedRealm
    {
        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("has_queue")]
        public bool HasQueue { get; set; }

        [JsonProperty("status")]
        public ConnectedRealmStatus? Status { get; set; }

        [JsonProperty("population")]
        public ConnectedRealmPopulation? Population { get; set; }

        [JsonProperty("realms")]
        public IEnumerable<Realm>? Realms { get; set; }

        [JsonProperty("mythic_leaderboards")]
        public MythicKeystoneLeaderboardIndex? MythicLeaderboards { get; set; }
    }
}
