using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     An item source.
    /// </summary>
    public class ItemSource : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the source ID.
        /// </summary>
        [JsonProperty("sourceId")]
        public int SourceId { get; set; }

        /// <summary>
        ///     Gets or sets the source type.
        /// </summary>
        [JsonProperty("sourceType")]
        public string? SourceType { get; set; }
    }
}