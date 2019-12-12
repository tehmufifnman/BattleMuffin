using System;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     An auction file.
    /// </summary>
    public abstract class AuctionDataFile : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the URL for the JSON-formatted auction data file.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        ///     Gets or sets the last modified timestamp.
        /// </summary>
        public DateTime? LastModified { get; set; }
    }
}
