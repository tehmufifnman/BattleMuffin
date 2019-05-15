using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     A PvP leaderboard.
    /// </summary>
    public class PvpLeaderboard : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the characters.
        /// </summary>
        [JsonProperty("rows")]
        public IEnumerable<PvpCharacter>? Characters { get; set; }
    }
}
