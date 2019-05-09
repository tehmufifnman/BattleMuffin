using Newtonsoft.Json;

namespace BattleMuffin.Web
{
    /// <summary>
    ///     The response for a failed Blizzard API request.
    /// </summary>
    public class RequestError
    {
        /// <summary>
        ///     The HTTP status code.
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        ///     The HTTP status code type.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        ///     The details of why the request failed.
        /// </summary>
        [JsonProperty("detail")]
        public string? Detail { get; set; }

        /// <summary>
        ///     Blizzard two types of responses, a 404 and anything else.
        ///     The 404 response has a reason and status.
        ///     All other responses have a code, type and detail.
        ///     For ease of use we can merge their functionality.
        /// </summary>
        [JsonProperty("reason")]
        private string Reason
        {
            set => Detail = value;
        }

        /// <summary>
        ///     Blizzard two types of responses, a 404 and anything else.
        ///     The 404 response has a reason and status.
        ///     All other responses have a code, type and detail.
        ///     For ease of use we can merge their functionality.
        /// </summary>
        [JsonProperty("status")]
        private string Status
        {
            set
            {
                Code = "404";
                Type = "Not Found.";
                Detail = value;
            }
        }
    }
}
