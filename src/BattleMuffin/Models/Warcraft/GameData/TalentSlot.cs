using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class TalentSlot
    {
        [JsonProperty("slot_number")]
        public int SlotNumber { get; set; }

        [JsonProperty("unlock_player_level")]
        public int UnlockPlayerLevel { get; set; }
    }
}
