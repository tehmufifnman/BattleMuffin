using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneLeaderboard
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("map")]
        public MythicKeystoneDungeonMap? Map { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("period_start_timestamp")]
        public long PeriodStartTimestamp { get; set; }

        [JsonProperty("period_end_timestamp")]
        public long PeriodEndTimestamp { get; set; }

        [JsonProperty("connected_realm")]
        public ConnectedRealm? ConnectedRealm { get; set; }

        [JsonProperty("leading_groups")]
        public IEnumerable<MythicKeystoneLeadingGroup>? LeadingGroups { get; set; }

        [JsonProperty("keystone_affixes")]
        public IEnumerable<MythicKeystoneAffix>? KeystoneAffixes { get; set; }

        [JsonProperty("map_challenge_mode_id")]
        public int MapChallengeModeId { get; set; }
    }
}
