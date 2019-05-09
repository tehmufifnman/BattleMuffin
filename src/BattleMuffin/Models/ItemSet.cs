using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     An item set.
    /// </summary>
    public class ItemSet : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the item set ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the item set name.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Gets or sets the set bonuses.
        /// </summary>
        [JsonProperty("setBonuses")]
        public IEnumerable<SetBonus>? SetBonuses { get; set; }

        /// <summary>
        ///     Gets or sets the IDs of the items that belong to the set.
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<int>? Items { get; set; }
    }
}
