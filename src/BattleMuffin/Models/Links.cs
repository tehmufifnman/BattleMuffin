using System.Text.Json.Serialization;

namespace BattleMuffin.Models
{
    public class Links
    {
        [JsonPropertyName("self")]
        public Self? Self { get; set; }
    }
}
