using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     An achievement criterion.
    /// </summary>
    public class Criterion : IWarcraftModel
    {
        /// <summary>
        ///     Gets the criterion description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Gets the criterion ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets the max number.
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public int Max { get; set; }

        /// <summary>
        ///     Gets the order index.
        /// </summary>
        [JsonProperty(PropertyName = "orderIndex")]
        public int OrderIndex { get; set; }
    }
}
