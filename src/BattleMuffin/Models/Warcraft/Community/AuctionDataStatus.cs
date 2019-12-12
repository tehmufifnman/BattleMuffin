using System.Collections.Generic;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     An auction files listing.
    /// </summary>
    public abstract class AuctionDataStatus : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the auction file summaries.
        /// </summary>
        public IEnumerable<AuctionDataFile>? Files { get; set; }
    }
}
