using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PlayableSpecializationTalentTier
    {
        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("talents")]
        public IEnumerable<PlayableSpecializationTalent>? Talents { get; set; }
    }
}
