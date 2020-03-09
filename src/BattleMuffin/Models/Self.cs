using System;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace BattleMuffin.Models
{
    [UsedImplicitly]
    public class Self
    {
        [UsedImplicitly]
        [JsonPropertyName("href")]
        public Uri? Href { get; set; }
    }
}
