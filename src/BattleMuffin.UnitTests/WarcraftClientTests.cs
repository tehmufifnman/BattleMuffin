using System.Net;
using BattleMuffin.Clients;
using BattleMuffin.Enums;
using BattleMuffin.UnitTests.Attributes;
using RichardSzalay.MockHttp;
using Xunit;

namespace BattleMuffin.UnitTests
{
    public class WarcraftClientTests
    {
        [Theory]
        [JsonData("achievement.json")]
        public async void GetAchievementAsyncTest(int achievementId, string achievementResponse)
        {
            var warcraftClient = BuildMockClient(
                $"https://us.api.blizzard.com/wow/achievement/{achievementId}?locale=en_US",
                achievementResponse);

            var result = await warcraftClient.GetAchievementAsync(achievementId);
            Assert.NotNull(result.Value);
        }

        private static IWarcraftClient BuildMockClient(string requestUri, string responseContent,
            HttpStatusCode? statusCode = null)
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp
                .When("https://us.battle.net/oauth/token")
                .Respond(
                    "application/json",
                    @"{""access_token"": ""ACCESS-TOKEN"", ""token_type"": ""bearer"", ""expires_in"": 12345, ""scope"": ""test.scope""}");

            if (statusCode == null)
            {
                mockHttp
                    .When(requestUri)
                    .Respond(
                        "application/json",
                        responseContent);
            }
            else
            {
                mockHttp
                    .When(requestUri)
                    .Respond(
                        statusCode.Value,
                        "application/json",
                        responseContent);
            }

            return new WarcraftClient(
                "clientIdHere",
                "clientSecretHere",
                Region.US,
                Locale.en_US,
                mockHttp.ToHttpClient());
        }
    }
}
