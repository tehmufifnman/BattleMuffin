using Newtonsoft.Json;

namespace BattleMuffin.Models
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
