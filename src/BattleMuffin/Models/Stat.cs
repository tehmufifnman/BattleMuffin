using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A stat.
    /// </summary>
    public class Stat : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the stat ID.
        /// </summary>
        [JsonProperty("stat")]
        public int StatId { get; set; }

        /// <summary>
        ///     Gets or sets the stat amount.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}
