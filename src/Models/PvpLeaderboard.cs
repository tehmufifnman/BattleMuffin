using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     A PvP leaderboard.
    /// </summary>
    public class PvpLeaderboard
    {
        /// <summary>
        ///     Gets or sets the characters.
        /// </summary>
        [JsonProperty("rows")]
        public IEnumerable<PvpCharacter> Characters { get; set; }
    }
}
