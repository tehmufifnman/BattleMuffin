namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     A modifier.
    /// </summary>
    public abstract class Modifier : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the modifier type.
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        ///     Gets or sets the modifier value.
        /// </summary>
        public int Value { get; set; }
    }
}
