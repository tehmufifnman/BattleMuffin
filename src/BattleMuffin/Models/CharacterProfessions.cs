using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     Information about a character's professions.
    /// </summary>
    public class CharacterProfessions : IWarcraftModel
    {
        /// <summary>
        ///     The primary professions.
        /// </summary>
        [JsonProperty("primary")]
        public IEnumerable<Profession>? Primary { get; set; }

        /// <summary>
        ///     The secondary professions.
        /// </summary>
        [JsonProperty("secondary")]
        public IEnumerable<Profession>? Secondary { get; set; }
    }
}
