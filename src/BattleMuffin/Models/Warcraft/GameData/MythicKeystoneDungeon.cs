using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class MythicKeystoneDungeon
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("map")]
        public MythicKeystoneDungeonMap? Map { get; set; }

        [JsonProperty("zone")]
        public Zone? Zone { get; set; }

        [JsonProperty("keystone_upgrades")]
        public IEnumerable<MythicKeystoneUpgrade>? KeystoneUpgrades { get; set; }
    }
}
