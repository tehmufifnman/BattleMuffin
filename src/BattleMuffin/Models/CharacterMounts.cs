using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     Information about a character's mounts.
    /// </summary>
    public class CharacterMounts : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the number of mounts collected.
        /// </summary>
        [JsonProperty("numCollected")]
        public int NumCollected { get; set; }

        /// <summary>
        ///     Gets or sets the number of mounts not collected.
        /// </summary>
        [JsonProperty("numNotCollected")]
        public int NumNotCollected { get; set; }

        /// <summary>
        ///     Gets or sets the collected mounts.
        /// </summary>
        [JsonProperty("collected")]
        public IEnumerable<Mount>? Collected { get; set; }
    }
}
