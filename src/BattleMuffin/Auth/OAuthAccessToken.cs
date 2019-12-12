namespace BattleMuffin.Auth
{
    /// <summary>
    ///     An OAuth access token for the Blizzard API.
    /// </summary>
    public class OAuthAccessToken
    {
        public string? AccessToken { get; set; } = string.Empty;

        public string? TokenType { get; set; }

        public long ExpiresIn { get; set; }

        public string? Scope { get; set; }
    }
}
