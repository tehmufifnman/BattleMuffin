using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.Community
{
    /// <summary>
    ///     A bonus list
    /// </summary>
    public class BonusList : IWarcraftModel
    {
        /// <summary>
        ///     Gets or sets the bonus list ID.
        /// </summary>
        [JsonProperty("bonusListId")]
        public int BonusListId { get; set; }
    }
}
