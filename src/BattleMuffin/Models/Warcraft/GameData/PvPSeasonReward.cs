using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PvPSeasonReward
    {
        [JsonProperty("bracket")]
        public PvPBracket? Bracket { get; set; }

        [JsonProperty("achievement")]
        public Achievement? Achievement { get; set; }

        [JsonProperty("rating_cutoff")]
        public int RatingCutoff { get; set; }

        [JsonProperty("faction")]
        public Faction? Faction { get; set; }
    }
}
