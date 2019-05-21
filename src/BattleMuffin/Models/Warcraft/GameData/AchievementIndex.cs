using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class AchievementIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("achievements")]
        public IEnumerable<Achievement>? Achievements { get; set; }
    }
}
