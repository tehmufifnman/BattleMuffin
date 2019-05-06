using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A location.
    /// </summary>
    public class Location
    {
        /// <summary>
        ///     Gets the location ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
