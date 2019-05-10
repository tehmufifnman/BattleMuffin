using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A modifier.
    /// </summary>
    public class Modifier : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the modifier type.
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        ///     Gets or sets the modifier value.
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
