using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BattleMuffin.Enums;
using BattleMuffin.Exceptions;
using BattleMuffin.Extensions;
using BattleMuffin.Models.Shared;
using BattleMuffin.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BattleMuffin.Clients
{
    /// <summary>
    ///     Base Blizzard API client extended by all game-specific clients.
    /// </summary>
    public class BaseClient
    {
        private readonly HttpClient _client;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly Region _region;
        protected readonly string Host;
        protected readonly Locale Locale;

        private OAuthAccessToken? _token;
        private DateTime _tokenExpiration;

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseClient" /> class.
        /// </summary>
        /// <param name="clientId">The Blizzard OAuth client ID.</param>
        /// <param name="clientSecret">The Blizzard OAuth client secret.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">
        ///     Specifies the language that the result will be in. Visit
        ///     https://develop.battle.net/documentation/guides/regionality-partitions-and-localization
        ///     to see a list of available locales.
        /// </param>
        /// <param name="client">HttpClient to use for all API requests.</param>
        protected BaseClient(string clientId, string clientSecret, Region region, Locale locale, HttpClient? client)
        {
            _client = client ?? InternalHttpClient.Instance;
            _clientId = clientId ?? throw new ArgumentNullException(nameof(clientId));
            _clientSecret = clientSecret ?? throw new ArgumentNullException(nameof(clientSecret));

            if (!locale.ValidateRegionLocale(region))
            {
                throw new ArgumentException("The locale selected is not supported by the selected region.");
            }

            _region = region;
            Locale = locale;
            Host = GetHost(region);
        }

        /// <summary>
        ///     Get an OAuth token.
        /// </summary>
        /// <returns>
        ///     An OAuth token.
        /// </returns>
        private async Task<OAuthAccessToken> GetOAuthToken()
        {
            var credentials = $"{_clientId}:{_clientSecret}";
            var oauthHost = GetOAuthHost(_region);

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials)));

            var requestBody = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            });

            var request = await _client.PostAsync($"{oauthHost}/oauth/token", requestBody);
            var response = await request.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<OAuthAccessToken>(response);
        }

        /// <summary>
        ///     Retrieve an item of type <typeparamref name="T" /> from the Blizzard Community
        ///     or Game Data API.
        /// </summary>
        /// <typeparam name="T">
        ///     The return type.
        /// </typeparam>
        /// <param name="requestUri">
        ///     The URI the request is sent to.
        /// </param>
        /// <param name="arrayName">
        ///     The name of the array to deserialize to prevent the use of JSON root objects.
        /// </param>
        /// <returns>
        ///     The JSON response, deserialized to an object of type <typeparamref name="T" />.
        /// </returns>
        protected async Task<RequestResult<T>> Get<T>(string requestUri, string? arrayName = null) where T : class
        {
            // Acquire a new OAuth token if we don't have one. Get a new one if it's expired.
            if (_token == null || DateTime.UtcNow >= _tokenExpiration)
            {
                _token = await GetOAuthToken().ConfigureAwait(false);
                _tokenExpiration = DateTime.UtcNow.AddSeconds(_token.ExpiresIn).AddSeconds(-30);
            }

            // Add an authentication header with the token.
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token.AccessToken);

            // Retrieve the response.
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            using var response = await _client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, token).ConfigureAwait(false);

            if (response.IsSuccessStatusCode && response.Content != null)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                var json = await StreamToStringAsync(stream);

                if (string.IsNullOrEmpty(json))
                {
                    var requestError = JsonConvert.DeserializeObject<RequestError>(json);
                    return requestError;
                }

                try
                {
                    if (arrayName != null)
                    {
                        json = JObject.Parse(json).SelectToken(arrayName).ToString();
                    }

                    RequestResult<T> requestResult = JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
                    {
                        ContractResolver = new BaseClientContractResolver(),
                        MissingMemberHandling = MissingMemberHandling.Error
                    });

                    return requestResult;
                }
                catch (JsonReaderException ex)
                {
                    var requestError = new RequestError
                    {
                        Code = string.Empty,
                        Detail = ex.Message,
                        Type = typeof(JsonReaderException).ToString()
                    };
                    return new RequestResult<T>(requestError);
                }
            }

            // If not then it is most likely a problem on our end due to an HTTP error.
            var message = $"Response code {(int) response.StatusCode} ({response.ReasonPhrase}) does not indicate success. Request: {requestUri}";
            throw new HttpRequestException(message);
        }

        /// <summary>
        ///     Get the host for the specified region.
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <returns>
        ///     The host for the specified region.
        /// </returns>
        private static string GetHost(Region region)
        {
            switch (region)
            {
                case Region.China:
                    return "https://cn.api.blizzard.com";
                case Region.Europe:
                    return "https://eu.api.blizzard.com";
                case Region.Korea:
                    return "https://kr.api.blizzard.com";
                case Region.Taiwan:
                    return "https://tw.api.blizzard.com";
                case Region.Us:
                    return "https://us.api.blizzard.com";
                default:
                    return "https://us.api.blizzard.com";
            }
        }

        /// <summary>
        ///     Get the OAuth host for the specified region.
        /// </summary>
        /// <param name="region">Specifies the region for which an OAuth token will be acquired.</param>
        /// <returns>
        ///     The OAuth host for the specified region.
        /// </returns>
        private static string GetOAuthHost(Region region)
        {
            switch (region)
            {
                case Region.China:
                    return "https://cn.battle.net";
                case Region.Europe:
                    return "https://eu.battle.net";
                case Region.Korea:
                    return "https://kr.battle.net";
                case Region.Taiwan:
                    return "https://tw.battle.net";
                case Region.Us:
                    return "https://us.battle.net";
                default:
                    return "https://us.battle.net";
            }
        }

        /// <summary>
        ///     Get the namespace regionality for the specified region and namespace category
        /// </summary>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="namespaceCategory">The namespace category depending on type of API data.</param>
        /// <returns>
        ///     The namespace regionality for the specified region and namespace category
        /// </returns>
        protected string GetNamespace(NamespaceCategory namespaceCategory)
        {
            switch (_region)
            {
                case Region.China:
                    throw new InvalidRegionException(_region);
                case Region.Europe:
                    return $"{namespaceCategory.ToString().ToLower()}-eu";
                case Region.Korea:
                    return $"{namespaceCategory.ToString().ToLower()}-kr";
                case Region.Taiwan:
                    return $"{namespaceCategory.ToString().ToLower()}-tw";
                case Region.Us:
                    return $"{namespaceCategory.ToString().ToLower()}-us";
                default:
                    return $"{namespaceCategory.ToString().ToLower()}-us";
            }
        }

        /// <summary>
        ///     Get a streams content as a string.
        /// </summary>
        /// <param name="stream">The stream to retrieve content from.</param>
        /// <returns>
        ///     The streams content as a string.
        /// </returns>
        private static async Task<string?> StreamToStringAsync(Stream stream)
        {
            if (stream == null)
            {
                return null;
            }

            using var sr = new StreamReader(stream);
            var content = await sr.ReadToEndAsync();
            stream.Close();
            return content;
        }
    }
}
