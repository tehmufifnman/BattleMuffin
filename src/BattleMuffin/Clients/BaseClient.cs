using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BattleMuffin.Auth;
using BattleMuffin.Config;
using BattleMuffin.Enums;
using BattleMuffin.Exceptions;
using BattleMuffin.Extensions;
using BattleMuffin.Web;

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
                throw new ArgumentException("The locale selected is not supported by the selected region.");

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
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials)));

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            });

            var request = CreateRequest(HttpMethod.Post, $"{oauthHost}/oauth/token", content);
            var response = await _client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead)
                .ConfigureAwait(false);
            await using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            return await JsonSerializer.DeserializeAsync<OAuthAccessToken>(stream,
                DefaultJsonSerializerOptions.Options);
        }

        private static HttpRequestMessage CreateRequest(HttpMethod method, string url, HttpContent? content = null)
        {
            return content != null
                ? new HttpRequestMessage(method, url) {Content = content}
                : new HttpRequestMessage(method, url);
        }

        /// <summary>
        ///     Retrieve an item of type <typeparamref name="T" /> from the Blizzard Community
        ///     or Game Data API.
        /// </summary>
        /// <typeparam name="T">
        ///     The return type.
        /// </typeparam>
        /// <param name="url">
        ///     The URI the request is sent to.
        /// </param>
        /// <param name="arrayName">
        ///     The name of the array to deserialize to prevent the use of JSON root objects.
        /// </param>
        /// <returns>
        ///     The JSON response, deserialized to an object of type <typeparamref name="T" />.
        /// </returns>
        protected Task<RequestResult<T>> Get<T>(string url, string? arrayName = null) where T : class
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            return Get<T>(url, token, arrayName);
        }

        /// <summary>
        ///     Retrieve an item of type <typeparamref name="T" /> from the Blizzard Community
        ///     or Game Data API.
        /// </summary>
        /// <typeparam name="T">
        ///     The return type.
        /// </typeparam>
        /// <param name="url">
        ///     The URI the request is sent to.
        /// </param>
        /// <param name="token">
        ///     Custom cancellation token.
        /// </param>
        /// <param name="arrayName">
        ///     The name of the array to deserialize to prevent the use of JSON root objects.
        /// </param>
        /// <returns>
        ///     The JSON response, deserialized to an object of type <typeparamref name="T" />.
        /// </returns>
        protected async Task<RequestResult<T>> Get<T>(string url, CancellationToken token, string? arrayName = null) where T : class
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
            var request = CreateRequest(HttpMethod.Get, url);
            using var response = await _client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, token)
                .ConfigureAwait(false);

            if (response.IsSuccessStatusCode && response.Content != null)
            {
                await using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                try
                {
                    if (arrayName != null)
                    {
                        var json = await StreamToStringAsync(stream);

                        if (string.IsNullOrEmpty(json))
                        {
                            var error = await JsonSerializer.DeserializeAsync<RequestError>(stream, DefaultJsonSerializerOptions.Options, token);
                            return error;
                        }

                        json = JsonDocument.Parse(json).RootElement.GetProperty(arrayName).ToString();
                        return JsonSerializer.Deserialize<T>(json, DefaultJsonSerializerOptions.Options);
                    }

                    RequestResult<T> requestResult =
                        await JsonSerializer.DeserializeAsync<T>(stream, DefaultJsonSerializerOptions.Options, token);
                    return requestResult;
                }
                catch (Exception ex)
                {
                    var requestError = new RequestError
                    {
                        Code = string.Empty,
                        Detail = ex.Message,
                        Type = typeof(Exception).ToString()
                    };
                    return new RequestResult<T>(requestError);
                }
            }

            // If not then it is most likely a problem on our end due to an HTTP error.
            var message =
                $"Response code {(int) response.StatusCode} ({response.ReasonPhrase}) does not indicate success. Request: {url}";
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
            return region switch
            {
                Region.China => "https://cn.api.blizzard.com",
                Region.Europe => "https://eu.api.blizzard.com",
                Region.Korea => "https://kr.api.blizzard.com",
                Region.Taiwan => "https://tw.api.blizzard.com",
                Region.US => "https://us.api.blizzard.com",
                _ => "https://us.api.blizzard.com"
            };
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
            return region switch
            {
                Region.China => "https://cn.battle.net",
                Region.Europe => "https://eu.battle.net",
                Region.Korea => "https://kr.battle.net",
                Region.Taiwan => "https://tw.battle.net",
                Region.US => "https://us.battle.net",
                _ => "https://us.battle.net"
            };
        }

        /// <summary>
        ///     Get the namespace regionality for the specified region and namespace category
        /// </summary>
        /// <param name="namespaceCategory">The namespace category depending on type of API data.</param>
        /// <returns>
        ///     The namespace regionality for the specified region and namespace category
        /// </returns>
        protected string GetNamespace(NamespaceCategory namespaceCategory)
        {
            return _region switch
            {
                Region.China => throw new InvalidRegionException(_region),
                Region.Europe => $"{namespaceCategory.ToString().ToLower()}-eu",
                Region.Korea => $"{namespaceCategory.ToString().ToLower()}-kr",
                Region.Taiwan => $"{namespaceCategory.ToString().ToLower()}-tw",
                Region.US => $"{namespaceCategory.ToString().ToLower()}-us",
                _ => $"{namespaceCategory.ToString().ToLower()}-us"
            };
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
            if (stream == null) return null;

            using var sr = new StreamReader(stream);
            var content = await sr.ReadToEndAsync().ConfigureAwait(false);
            stream.Close();
            return content;
        }
    }
}
