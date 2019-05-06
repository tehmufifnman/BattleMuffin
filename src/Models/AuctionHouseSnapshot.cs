using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     An auction house snapshot, loaded from an auction file.
    /// </summary>
    public class AuctionHouseSnapshot
    {
        /// <summary>
        ///     Gets or sets the realms with access to these auctions.
        /// </summary>
        [JsonProperty("realms")]
        public IEnumerable<AuctionRealm> Realms { get; set; }

        /// <summary>
        ///     Gets or sets the auctions.
        /// </summary>
        [JsonProperty("auctions")]
        public IEnumerable<Auction> Auctions { get; set; }
    }
}
