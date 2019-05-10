using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     An auction files listing.
    /// </summary>
    public class AuctionFiles : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the auction file summaries.
        /// </summary>
        [JsonProperty("files")]
        public IEnumerable<AuctionFileSummary>? Files { get; set; }
    }
}
