using System;
using Newtonsoft.Json;

namespace BattleMuffin.Models
{
    /// <summary>
    ///     An OAuth access token for the Blizzard API.
    /// </summary>
    public class OAuthAccessToken : IWarcraftModel
    {
        [JsonProperty("access_token")]
        public string? AccessToken { get; set; } = string.Empty;

        [JsonProperty("token_type")]
        public string? TokenType { get; set; }

        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }

        [JsonProperty("scope")]
        public string? Scope { get; set; }
    }
}
