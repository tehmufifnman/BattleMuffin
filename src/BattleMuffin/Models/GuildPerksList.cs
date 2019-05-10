using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A guild perks list.
    /// </summary>
    public class GuildPerksList : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the guild perks.
        /// </summary>
        [JsonProperty("perks")]
        public IEnumerable<Perk>? Perks { get; set; }
    }
}
