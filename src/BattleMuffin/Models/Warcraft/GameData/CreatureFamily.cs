using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class CreatureFamily
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("specialization")]
        public CreatureFamilySpecialization? Specialization { get; set; }

        [JsonProperty("media")]
        public Media? Media { get; set; }
    }
}
