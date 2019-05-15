using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     PvP information for a character.
    /// </summary>
    public class Pvp : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the PvP brackets.
        /// </summary>
        [JsonProperty("brackets")]
        public PvpBrackets? Brackets { get; set; }
    }
}
