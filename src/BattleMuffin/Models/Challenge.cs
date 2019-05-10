using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A challenge mode dungeon.
    /// </summary>
    public class Challenge : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the realm.
        /// </summary>
        [JsonProperty("realm")]
        public Realm? Realm { get; set; }

        /// <summary>
        ///     Gets or sets the map.
        /// </summary>
        [JsonProperty("map")]
        public Map? Map { get; set; }

        /// <summary>
        ///     Gets or sets the groups.
        /// </summary>
        [JsonProperty("groups")]
        public IEnumerable<Group>? Groups { get; set; }
    }
}
