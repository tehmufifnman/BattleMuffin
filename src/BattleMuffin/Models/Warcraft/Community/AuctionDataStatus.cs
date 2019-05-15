using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     An auction files listing.
    /// </summary>
    public class AuctionDataStatus : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the auction file summaries.
        /// </summary>
        [JsonProperty("files")]
        public IEnumerable<AuctionDataFile>? Files { get; set; }
    }
}
