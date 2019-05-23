using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PlayableClass
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("gender_name")]
        public GenderName? GenderName { get; set; }

        [JsonProperty("power_type")]
        public PowerType? PowerType { get; set; }

        [JsonProperty("specializations")]
        public IEnumerable<PlayableSpecialization>? Specializations { get; set; }

        [JsonProperty("media")]
        public Media? Media { get; set; }

        [JsonProperty("pvp_talent_slots")]
        public PlayableClassPvPTalentSlots? PvpTalentSlots { get; set; }
    }
}
