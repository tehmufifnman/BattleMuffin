using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class RealmIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("realms")]
        public IEnumerable<Realm>? Realms { get; set; }
    }
}
