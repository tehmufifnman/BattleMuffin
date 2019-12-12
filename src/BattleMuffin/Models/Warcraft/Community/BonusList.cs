namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     A bonus list
    /// </summary>
    public abstract class BonusList : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the bonus list ID.
        /// </summary>
        public int BonusListId { get; set; }
    }
}
