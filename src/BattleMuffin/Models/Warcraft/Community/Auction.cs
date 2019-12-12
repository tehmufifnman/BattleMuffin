using System.Collections.Generic;
using BattleMuffin.Enums;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     An auction.
    /// </summary>
    public abstract class Auction : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the auction ID.
        /// </summary>
        public int Auc { get; set; }

        /// <summary>
        ///     Gets or sets the item ID.
        /// </summary>
        public int Item { get; set; }

        /// <summary>
        ///     Gets or sets the owner's name.
        /// </summary>
        public string? Owner { get; set; }

        /// <summary>
        ///     Gets or sets the owner's realm name.
        /// </summary>
        public string? OwnerRealm { get; set; }

        /// <summary>
        ///     Gets or sets the current bid.
        /// </summary>
        public long Bid { get; set; }

        /// <summary>
        ///     Gets or sets the buyout.
        /// </summary>
        public long Buyout { get; set; }

        /// <summary>
        ///     Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        ///     Gets or sets the time left.
        /// </summary>
        public string? TimeLeft { get; set; }

        /// <summary>
        ///     Gets or sets the rand.
        /// </summary>
        public int Rand { get; set; }

        /// <summary>
        ///     Gets or sets the seed.
        /// </summary>
        public long Seed { get; set; }

        /// <summary>
        ///     Gets or sets the context.
        /// </summary>
        public int Context { get; set; }

        /// <summary>
        ///     Gets or sets the bonus lists.
        /// </summary>
        public IEnumerable<BonusList>? BonusLists { get; set; }

        /// <summary>
        ///     Gets or sets the modifiers.
        /// </summary>
        public IEnumerable<Modifier>? Modifiers { get; set; }

        /// <summary>
        ///     Gets or sets the pet species ID.
        /// </summary>
        public int? PetSpeciesId { get; set; }

        /// <summary>
        ///     Gets or sets the pet breed ID.
        /// </summary>
        public int? PetBreedId { get; set; }

        /// <summary>
        ///     Gets or sets the pet level.
        /// </summary>
        public int? PetLevel { get; set; }

        /// <summary>
        ///     Gets or sets the battle pet quality.
        /// </summary>
        public BattlePetQuality? PetQuality { get; set; }
    }
}
