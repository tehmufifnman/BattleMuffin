using System;
using System.Text.Json.Serialization;

namespace BattleMuffin.Models
{
    public class Self
    {
        [JsonPropertyName("href")]
        public Uri? Href { get; set; }
    }
}
