using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class ConnectedRealmIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("connected_realms")]
        public IEnumerable<ConnectedRealm>? ConnectedRealms { get; set; }
    }
}
