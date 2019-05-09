using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A talent.
    /// </summary>
    public class Talent : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the tier number.
        /// </summary>
        [JsonProperty("tier")]
        public int Tier { get; set; }

        /// <summary>
        ///     Gets or sets the column number.
        /// </summary>
        [JsonProperty("column")]
        public int Column { get; set; }

        /// <summary>
        ///     Gets or sets the spell.
        /// </summary>
        [JsonProperty("spell")]
        public Spell? Spell { get; set; }

        /// <summary>
        ///     Gets or sets the spec.
        /// </summary>
        [JsonProperty("spec")]
        public Spec? Spec { get; set; }
    }
}
