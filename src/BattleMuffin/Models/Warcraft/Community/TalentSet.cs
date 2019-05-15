using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     A set of talents for a class.
    /// </summary>
    public class TalentSet : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the class specs.
        /// </summary>
        [JsonProperty("specs")]
        public IEnumerable<Spec>? Specs { get; set; }

        /// <summary>
        ///     Gets or sets the pet specs.
        /// </summary>
        [JsonProperty("petSpecs")]
        public IEnumerable<Spec>? PetSpecs { get; set; }

        /// <summary>
        ///     Gets or sets the class talents.
        /// </summary>
        [JsonProperty("talents")]
        public IEnumerable<IEnumerable<IEnumerable<Talent>>>? Talents { get; set; }

        /// <summary>
        ///     Gets or sets the class name.
        /// </summary>
        [JsonProperty("class")]
        public string? Class { get; set; }
    }
}
