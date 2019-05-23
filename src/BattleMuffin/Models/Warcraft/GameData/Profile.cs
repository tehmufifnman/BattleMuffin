using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class Profile
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("realm")]
        public Realm? Realm { get; set; }
    }
}
