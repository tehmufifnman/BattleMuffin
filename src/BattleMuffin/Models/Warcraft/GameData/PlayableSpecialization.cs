using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PlayableSpecialization
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("playable_class")]
        public PlayableClass? PlayableClass { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("gender_description")]
        public GenderName? GenderDescription { get; set; }

        [JsonProperty("media")]
        public Media? Media { get; set; }

        [JsonProperty("role")]
        public PlayableSpecializationRole? Role { get; set; }

        [JsonProperty("talent_tiers")]
        public IEnumerable<PlayableSpecializationTalentTier>? TalentTiers { get; set; }

        [JsonProperty("pvp_talents")]
        public IEnumerable<PlayableSpecializationTalent>? PvpTalents { get; set; }
    }
}
