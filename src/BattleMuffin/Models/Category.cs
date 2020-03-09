using System.Text.Json.Serialization;

namespace BattleMuffin.Models
{
    public class Category
    {
        [JsonPropertyName("key")]
        public Self? Key { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
