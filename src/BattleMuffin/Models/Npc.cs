using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     An NPC.
    /// </summary>
    public class Npc : IWarcraftModel
    {
        /// <summary>
        ///     Gets the creature display ID.
        /// </summary>
        [JsonProperty(PropertyName = "creatureDisplayId")]
        public int CreatureDisplayId { get; set; }

        /// <summary>
        ///     Gets the NPC ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Gets the URL slug.
        /// </summary>
        [JsonProperty(PropertyName = "urlSlug")]
        public string? UrlSlug { get; set; }
    }
}
