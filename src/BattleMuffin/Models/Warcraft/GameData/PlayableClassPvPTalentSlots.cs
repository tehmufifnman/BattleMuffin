using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PlayableClassPvPTalentSlots
    {
        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("talent_slots")]
        public IEnumerable<TalentSlot>? TalentSlots { get; set; }
    }
}
