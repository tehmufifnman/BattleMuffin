using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A recipe.
    /// </summary>
    public class Recipe : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the recipe ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the recipe name.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Gets or sets the profession.
        /// </summary>
        [JsonProperty("profession")]
        public string? Profession { get; set; }

        /// <summary>
        ///     Gets or sets the icon.
        /// </summary>
        [JsonProperty("icon")]
        public string? Icon { get; set; }
    }
}
