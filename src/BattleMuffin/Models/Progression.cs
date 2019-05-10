using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     Character raid progression.
    /// </summary>
    public class Progression : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets progression information for raids.
        /// </summary>
        [JsonProperty("raids")]
        public IEnumerable<Raid>? Raids { get; set; }
    }
}
