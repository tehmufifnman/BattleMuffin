using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A Blizzard user's account details.
    /// </summary>
    public class UserAccount : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the user's BattleTag.
        /// </summary>
        [JsonProperty("battletag")]
        public string? BattleTag { get; set; }

        /// <summary>
        ///     Gets or sets the user's account ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
