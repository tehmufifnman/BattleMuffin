using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PlayableSpecializationTalent
    {
        [JsonProperty("talent")]
        public Talent? Talent { get; set; }

        [JsonProperty("spell_tooltip")]
        public SpellTooltip? SpellTooltip { get; set; }
    }
}
