using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class SpellTooltip
    {
      [JsonProperty("description")]
      public string? Description { get; set; }

      [JsonProperty("cast_time")]
      public string? CastTime { get; set; }

      [JsonProperty("range")]
      public string? Range { get; set; }

      [JsonProperty("cooldown")]
      public string? Cooldown { get; set; }

      [JsonProperty("power_cost")]
      public string? PowerCost { get; set; }
    }
}
