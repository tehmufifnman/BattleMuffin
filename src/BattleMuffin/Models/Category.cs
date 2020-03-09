using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace BattleMuffin.Models
{
    [UsedImplicitly]
    public class Category
    {
        [UsedImplicitly]
        [JsonPropertyName("key")]
        public Self? Key { get; set; }

        [UsedImplicitly]
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [UsedImplicitly]
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
