using Newtonsoft.Json;

namespace BattleMuffin.Auth
{
    /// <summary>
    ///     An OAuth access token for the Blizzard API.
    /// </summary>
    internal abstract class OAuthAccessToken
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
