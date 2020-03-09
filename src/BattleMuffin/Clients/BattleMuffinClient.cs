using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BattleMuffin.Attributes;
using BattleMuffin.Configuration;
using BattleMuffin.Extensions;
using IdentityModel.Client;
using JetBrains.Annotations;
using Microsoft.AspNetCore.WebUtilities;

namespace BattleMuffin.Clients
{
    [UsedImplicitly]
    internal class BattleMuffinClient
    {
        private readonly IClientConfiguration _clientConfiguration;
        private readonly HttpClient _httpClient;
        private TokenResponse? _tokenResponse;
        private DiscoveryDocumentResponse? _discoveryDocumentResponse;
        private DateTime _tokenExpiration;

        public BattleMuffinClient(IClientConfiguration clientConfiguration, HttpClient httpClient)
        {
            _clientConfiguration = clientConfiguration ?? throw new ArgumentNullException(nameof(clientConfiguration));
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _httpClient.BaseAddress = new Uri(_clientConfiguration.Host);
        }

        internal async Task RefreshToken()
        {
            if (_discoveryDocumentResponse == null)
            {
                _discoveryDocumentResponse = await _httpClient.GetDiscoveryDocumentAsync(new DiscoveryDocumentRequest
                {
                    Address = $"{_clientConfiguration.OauthHost}/oauth/.well-known/openid-configuration"
                }).ConfigureAwait(false);
            }
            if (_tokenResponse == null || DateTime.UtcNow >= _tokenExpiration)
            {
                _tokenResponse = await _httpClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
                {
                    Address = _discoveryDocumentResponse.TokenEndpoint,
                    ClientId = _clientConfiguration.ClientId,
                    ClientSecret = _clientConfiguration.ClientSecret,
                    Scope = "openid",
                    GrantType = "client_credentials"
                }).ConfigureAwait(false);

                _tokenExpiration = DateTime.UtcNow.AddSeconds(_tokenResponse.ExpiresIn).AddSeconds(-30);
            }
        }

        internal async Task<T> Get<T>(string requestPath, string requestNamespace, Dictionary<string, string>? parameters = null) where T : class
        {
            await RefreshToken();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _tokenResponse?.AccessToken);

            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;

            parameters ??= new Dictionary<string, string>();
            parameters.Add("locale", _clientConfiguration.Locale.GetAttribute<RfcTagAttribute>().Tag);
            parameters.Add("namespace", requestNamespace);

            var requestUri = QueryHelpers.AddQueryString($"{requestPath}", parameters);
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, token).ConfigureAwait(false);

            if (response.IsSuccessStatusCode && response.Content != null)
            {
                await using var contentStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<T>(contentStream, new JsonSerializerOptions {PropertyNameCaseInsensitive = true}, token);
            }

            var message = $"Response code {(int) response.StatusCode} ({response.ReasonPhrase}) does not indicate success. Request: {requestUri}";
            throw new HttpRequestException(message);
        }
    }
}