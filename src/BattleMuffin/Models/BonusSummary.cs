using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A bonus summary.
    /// </summary>
    public class BonusSummary : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the default bonus lists.
        /// </summary>
        [JsonProperty("defaultBonusLists")]
        public IEnumerable<int>? DefaultBonusLists { get; set; }

        /// <summary>
        ///     Gets or sets the chance bonus lists.
        /// </summary>
        [JsonProperty("chanceBonusLists")]
        public IEnumerable<int>? ChanceBonusLists { get; set; }

        /// <summary>
        ///     Gets or sets the bonus chances.
        /// </summary>
        [JsonProperty("bonusChances")]
        public IEnumerable<int>? BonusChances { get; set; }
    }
}
