using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Character
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("realm")]
        public Realm? Realm { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("playable_class")]
        public PlayableClass? PlayableClass { get; set; }

        [JsonProperty("playable_race")]
        public PlayableRace? PlayableRace { get; set; }
    }
}
