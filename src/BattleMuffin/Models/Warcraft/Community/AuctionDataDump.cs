using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     An auction house snapshot, loaded from an auction file.
    /// </summary>
    public class AuctionDataDump : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the realms with access to these auctions.
        /// </summary>
        [JsonProperty("realms")]
        public IEnumerable<AuctionRealm>? Realms { get; set; }

        /// <summary>
        ///     Gets or sets the auctions.
        /// </summary>
        [JsonProperty("auctions")]
        public IEnumerable<Auction>? Auctions { get; set; }
    }
}