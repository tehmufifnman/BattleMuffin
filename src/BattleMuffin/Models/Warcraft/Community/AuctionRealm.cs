namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     A realm.
    /// </summary>
    public abstract class AuctionRealm : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the realm name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        ///     Gets or sets the realm slug.
        /// </summary>
        public string? Slug { get; set; }
    }
}
