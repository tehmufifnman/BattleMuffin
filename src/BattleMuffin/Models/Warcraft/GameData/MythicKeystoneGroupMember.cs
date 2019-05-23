using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneGroupMember
    {
        [JsonProperty("profile")]
        public Profile? Profile { get; set; }

        [JsonProperty("faction")]
        public Faction? Faction { get; set; }

        [JsonProperty("specialization")]
        public PlayableSpecialization? Specialization { get; set; }
    }
}
