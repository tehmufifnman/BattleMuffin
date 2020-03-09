using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace BattleMuffin.Models
{
    [UsedImplicitly]
    public class Links
    {
        [UsedImplicitly]
        [JsonPropertyName("self")]
        public Self? Self { get; set; }
    }
}
