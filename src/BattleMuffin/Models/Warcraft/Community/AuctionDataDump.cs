using System.Collections.Generic;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     An auction house snapshot, loaded from an auction file.
    /// </summary>
    public abstract class AuctionDataDump : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the realms with access to these auctions.
        /// </summary>
        public IEnumerable<AuctionRealm>? Realms { get; set; }

        /// <summary>
        ///     Gets or sets the auctions.
        /// </summary>
        public IEnumerable<Auction>? Auctions { get; set; }
    }
}
